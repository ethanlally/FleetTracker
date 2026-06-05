import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { ApiService, Rental } from '../services/api.service';
import { ToastService } from '../services/toast.service';
import { FleetStore } from '../store/fleet.store';
import { CommonModule } from '@angular/common';
import { getRentalStatusName } from '../models/enums';

@Component({
  selector: 'app-rental-manage',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule, RouterLink],
  template: `
    <h2>Edit Rental Details</h2>
    
    <div style="display: flex; gap: 30px; flex-wrap: wrap;">
      <form [formGroup]="rentalForm" (ngSubmit)="onSubmit()" style="flex: 1; min-width: 300px; max-width: 500px; display: flex; flex-direction: column; gap: 15px;">
        
        <fieldset style="display: flex; flex-direction: column; gap: 10px;">
          <legend>Agreement #{{ currentRental?.agreementNumber || 'Loading...' }}</legend>
          
          <label>Expected Return Date: <input formControlName="expectedReturnDate" type="date" /></label>
          <label>Starting Mileage: <input formControlName="startingMileage" type="number" /></label>
          <label>Actual Return Date: <input formControlName="actualReturnDate" type="date" /></label>
          <label>Ending Mileage: <input formControlName="endingMileage" type="number" /></label>
          <label>Total Cost ($): <input formControlName="totalCost" type="number" step="0.01" /></label>
          <label>Status: 
            <select formControlName="status" style="padding: 4px;">
              <option [ngValue]="0">Active</option>
              <option [ngValue]="1">Completed</option>
              <option [ngValue]="2">Cancelled</option>
            </select>
          </label>
        </fieldset>

        <div style="display: flex; gap: 10px; margin-top: 20px;">
          <button type="submit" [disabled]="rentalForm.invalid" style="padding: 8px 16px; cursor: pointer;">Save Rental</button>
          <button type="button" (click)="goBack()" style="padding: 8px 16px; cursor: pointer;">Cancel</button>
        </div>
      </form>

      <div style="flex: 1; min-width: 300px; padding: 20px; border: 1px solid #ccc; border-radius: 8px;">
        <h3>Rental Reference</h3>
        <p><strong>Customer:</strong>&nbsp;<a [routerLink]="['/customers', currentRental?.customerId]" style="color: #007bff; text-decoration: none;">{{ getCustomerName(currentRental?.customerId) }}</a></p>
        <p><strong>Vehicle:</strong>&nbsp;<a [routerLink]="['/vehicles', currentRental?.vehicleId]" style="color: #007bff; text-decoration: none;">{{ getVehicleName(currentRental?.vehicleId) }}</a></p>
        <p><strong>Pickup Date:</strong>&nbsp;{{ currentRental?.pickupDate | date:'medium' }}</p>
        <p><strong>Current Status:</strong>&nbsp;{{ getStatusName(currentRental?.status) }}</p>
      </div>
    </div>
  `,
})
export class RentalManageComponent implements OnInit {
  private fb = inject(FormBuilder);
  private route = inject(ActivatedRoute);
  private router = inject(Router);
  private apiService = inject(ApiService);
  private toast = inject(ToastService);
  private store = inject(FleetStore);

  rentalId: string | null = null;
  currentRental: Rental | null = null;

  rentalForm: FormGroup = this.fb.group({
    expectedReturnDate: ['', Validators.required],
    startingMileage: [0, [Validators.required, Validators.min(0)]],
    actualReturnDate: [''],
    endingMileage: [''],
    totalCost: [''],
    status: [0, Validators.required],
  });

  getStatusName = getRentalStatusName;

  ngOnInit() {
    this.rentalId = this.route.snapshot.paramMap.get('id');
    if (this.rentalId) {
      this.loadRentalData();
    }
    if (!this.store.vehicles().length) this.store.loadVehicles();
    if (!this.store.customers().length) this.store.loadCustomers();
  }

  getVehicleName(id: string | undefined): string {
    if (!id) return 'Unknown Vehicle';
    const v = this.store.vehicles().find(x => x.id === id);
    return v ? `${v.make} ${v.model}` : id;
  }

  getCustomerName(id: string | undefined): string {
    if (!id) return 'Unknown Customer';
    const c = this.store.customers().find(x => x.id === id);
    return c && c.contact ? c.contact.name || id : id;
  }

  loadRentalData() {
    this.apiService.getAllRentals().subscribe({
      next: (rentals) => {
        const r = rentals.find(x => x.id === this.rentalId);
        if (r) {
          this.currentRental = r;
          this.patchForm(r);
        } else {
          this.toast.error('Rental not found');
          this.goBack();
        }
      },
      error: () => this.toast.error('Failed to load rental')
    });
  }

  patchForm(rental: Rental) {
    let expected = rental.expectedReturnDate;
    if (expected && expected.includes('T')) {
      expected = expected.split('T')[0];
    }
    
    let actual = rental.actualReturnDate;
    if (actual && actual.includes('T')) {
      actual = actual.split('T')[0];
    }

    this.rentalForm.patchValue({
      expectedReturnDate: expected,
      startingMileage: rental.startingMileage,
      actualReturnDate: actual,
      endingMileage: rental.endingMileage,
      totalCost: rental.totalCost,
      status: rental.status
    });
  }

  onSubmit() {
    if (this.rentalForm.invalid || !this.rentalId) return;

    const formValue = this.rentalForm.getRawValue();

    this.apiService.updateRental(this.rentalId, formValue).subscribe({
      next: () => {
        this.toast.success('Rental updated successfully!');
        this.goBack();
      },
      error: (err) => this.toast.error(err.message)
    });
  }

  goBack() {
    this.router.navigate(['/rentals']);
  }
}
