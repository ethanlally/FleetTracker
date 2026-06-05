import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ApiService } from '../services/api.service';
import { ToastService } from '../services/toast.service';
import { FleetStore } from '../store/fleet.store';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-rental-create',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  template: `
    <h2>Start New Rental</h2>
    
    <form [formGroup]="rentalForm" (ngSubmit)="onSubmit()" style="max-width: 500px; display: flex; flex-direction: column; gap: 15px;">
      
      <fieldset style="display: flex; flex-direction: column; gap: 10px;">
        <legend>Rental Details</legend>
        
        <label>Customer:
          <select formControlName="customerId">
            <option value="">-- Select Customer --</option>
            @for (c of store.customers(); track c.id) {
              <option [value]="c.id">{{ c.contact?.name || c.id }}</option>
            }
          </select>
        </label>
        
        <label>Vehicle:
          <select formControlName="vehicleId">
            <option value="">-- Select Available Vehicle --</option>
            @for (v of store.availableVehicles(); track v.id) {
              <option [value]="v.id">{{ v.make }} {{ v.model }} ({{ v.vin }})</option>
            }
          </select>
        </label>

        <label>Expected Return Date: <input formControlName="expectedReturnDate" type="date" /></label>
        <label>Starting Mileage: <input formControlName="startingMileage" type="number" /></label>
        <label>Pickup Date (optional): <input formControlName="pickupDate" type="date" /></label>
      </fieldset>

      <div style="display: flex; gap: 10px; margin-top: 20px;">
        <button type="submit" [disabled]="rentalForm.invalid" style="padding: 8px 16px; cursor: pointer;">Start Rental</button>
        <button type="button" (click)="goBack()" style="padding: 8px 16px; cursor: pointer;">Cancel</button>
      </div>

    </form>
  `,
})
export class RentalCreateComponent implements OnInit {
  private fb = inject(FormBuilder);
  private router = inject(Router);
  private apiService = inject(ApiService);
  private toast = inject(ToastService);
  store = inject(FleetStore);

  rentalForm: FormGroup = this.fb.group({
    customerId: ['', Validators.required],
    vehicleId: ['', Validators.required],
    expectedReturnDate: ['', Validators.required],
    startingMileage: [0, Validators.required],
    pickupDate: ['']
  });

  ngOnInit() {
    this.store.loadCustomers();
    this.store.loadVehicles();
  }

  onSubmit() {
    if (this.rentalForm.invalid) return;

    const formValue = { ...this.rentalForm.value };
    if (!formValue.pickupDate) delete formValue.pickupDate;

    this.apiService.startRental(formValue).subscribe({
      next: () => {
        this.toast.success('Rental started successfully!');
        this.store.loadAllRentals();
        this.store.loadVehicles();
        this.goBack();
      },
      error: (err) => this.toast.error(err.message)
    });
  }

  goBack() {
    this.router.navigate(['/rentals']);
  }
}
