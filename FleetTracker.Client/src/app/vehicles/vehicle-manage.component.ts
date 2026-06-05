import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { ApiService, Vehicle, Rental } from '../services/api.service';
import { ToastService } from '../services/toast.service';
import { FleetStore } from '../store/fleet.store';
import { CommonModule } from '@angular/common';
import { getMaintenanceTypeName, getRentalStatusName } from '../models/enums';

@Component({
  selector: 'app-vehicle-manage',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule, RouterLink],
  template: `
    <h2>{{ isEditMode ? 'Manage Vehicle' : 'New Vehicle' }}</h2>
    
    <div style="display: flex; gap: 30px; flex-wrap: wrap;">
      <form [formGroup]="vehicleForm" (ngSubmit)="onSubmit()" style="flex: 1; min-width: 300px; max-width: 500px; display: flex; flex-direction: column; gap: 15px;">
        
        <fieldset style="display: flex; flex-direction: column; gap: 10px;">
          <legend>Vehicle Details</legend>
          <label>VIN: <input formControlName="vin" type="text" [readonly]="isEditMode" /></label>
          <label>License Plate: <input formControlName="licensePlate" type="text" /></label>
          <label>Make: <input formControlName="make" type="text" /></label>
          <label>Model: <input formControlName="model" type="text" /></label>
          <label>Year: <input formControlName="year" type="number" /></label>
          <label>Class: 
            <select formControlName="class" style="padding: 4px;">
              <option [ngValue]="0">Compact</option>
              <option [ngValue]="1">Sedan</option>
              <option [ngValue]="2">SUV</option>
              <option [ngValue]="3">Truck</option>
              <option [ngValue]="4">Luxury</option>
            </select>
          </label>
          <label>Daily Rate ($): <input formControlName="dailyRate" type="number" step="0.01" /></label>
        </fieldset>

        <div style="display: flex; gap: 10px; margin-top: 20px;">
          <button type="submit" [disabled]="vehicleForm.invalid" style="padding: 8px 16px; cursor: pointer;">Save Vehicle</button>
          <button type="button" (click)="goBack()" style="padding: 8px 16px; cursor: pointer;">Cancel</button>
          @if (isEditMode) {
            <button type="button" (click)="deleteVehicle()" style="padding: 8px 16px; background-color: #f44336; color: white; border: none; cursor: pointer; margin-left: auto;">Delete</button>
          }
        </div>
      </form>

      @if (isEditMode) {
        <div style="flex: 1; min-width: 300px; padding: 20px; border: 1px solid #ccc; border-radius: 8px;">
          <h3>Actions</h3>
          <div style="display: flex; flex-direction: column; gap: 15px;">
            <p><strong>Current Status:</strong> {{ vehicleStatusText }}</p>
            
            @if (canStartMaintenance) {
              <div style="border: 1px solid #eee; padding: 10px;">
                <h4>Send to Maintenance</h4>
                <div style="display: flex; flex-direction: column; gap: 10px;">
                  <label>Type: 
                    <select #mType style="padding: 4px;">
                      <option value="0">Routine</option>
                      <option value="1">Repair</option>
                      <option value="2">Inspection</option>
                    </select>
                  </label>
                  <label>Description: <input #desc type="text" placeholder="Description" style="width: 100%" /></label>
                  <label>Cost ($): <input #cost type="number" placeholder="Cost" step="0.01" style="width: 100%" /></label>
                  <button (click)="startMaintenance(desc.value, cost.value, mType.value)" style="padding: 6px;">Submit Maintenance</button>
                </div>
              </div>
            }
            
            @if (canReturnMaintenance) {
              <button (click)="returnMaintenance()" style="padding: 10px; background-color: #4caf50; color: white; border: none; cursor: pointer;">
                Return From Maintenance
              </button>
            }

            @if (canToggleAvailability) {
              <button (click)="toggleAvailability()" style="padding: 10px; background-color: #ff9800; color: white; border: none; cursor: pointer; margin-top: 10px;">
                Toggle Availability
              </button>
            }
          </div>
        </div>
      }
    </div>

    @if (isEditMode) {
      <div style="margin-top: 40px; display: flex; flex-direction: column; gap: 30px;">
        
        <div>
          <h3>Maintenance History</h3>
          @if (currentVehicle?.maintenanceHistory?.length) {
            <table style="width: 100%; border-collapse: collapse; text-align: left;">
              <thead>
                <tr style="border-bottom: 2px solid #ccc;">
                  <th style="padding: 8px;">Date</th>
                  <th style="padding: 8px;">Type</th>
                  <th style="padding: 8px;">Description</th>
                  <th style="padding: 8px;">Cost</th>
                </tr>
              </thead>
              <tbody>
                @for (record of currentVehicle?.maintenanceHistory; track record.serviceDate) {
                  <tr style="border-bottom: 1px solid #eee;">
                    <td style="padding: 8px;">{{ record.serviceDate | date:'short' }}</td>
                    <td style="padding: 8px;">{{ getMaintenanceName(record.type) }}</td>
                    <td style="padding: 8px;">{{ record.description }}</td>
                    <td style="padding: 8px;">{{ record.cost | currency }}</td>
                  </tr>
                }
              </tbody>
            </table>
          } @else {
            <p>No maintenance records found.</p>
          }
        </div>

        <div>
          <h3>Rental History</h3>
          @if (rentalHistory.length) {
            <table style="width: 100%; border-collapse: collapse; text-align: left;">
              <thead>
                <tr style="border-bottom: 2px solid #ccc;">
                  <th style="padding: 8px;">Agreement #</th>
                  <th style="padding: 8px;">Customer</th>
                  <th style="padding: 8px;">Pickup</th>
                  <th style="padding: 8px;">Expected Return</th>
                  <th style="padding: 8px;">Status</th>
                </tr>
              </thead>
              <tbody>
                @for (rental of rentalHistory; track rental.id) {
                  <tr style="border-bottom: 1px solid #eee; cursor: pointer;" [routerLink]="['/rentals', rental.id]">
                    <td style="padding: 8px;">{{ rental.agreementNumber }}</td>
                    <td style="padding: 8px;">
                      <a [routerLink]="['/customers', rental.customerId]" (click)="$event.stopPropagation()" style="color: #007bff; text-decoration: none;">
                        {{ getCustomerName(rental.customerId) }}
                      </a>
                    </td>
                    <td style="padding: 8px;">{{ rental.pickupDate | date:'short' }}</td>
                    <td style="padding: 8px;">{{ rental.expectedReturnDate | date:'shortDate' }}</td>
                    <td style="padding: 8px;">{{ getStatusName(rental.status) }}</td>
                  </tr>
                }
              </tbody>
            </table>
          } @else {
            <p>No rental history found.</p>
          }
        </div>

      </div>
    }
  `,
})
export class VehicleManageComponent implements OnInit {
  private fb = inject(FormBuilder);
  private route = inject(ActivatedRoute);
  private router = inject(Router);
  private apiService = inject(ApiService);
  private toast = inject(ToastService);
  private store = inject(FleetStore);

  vehicleVin: string | null = null;
  isEditMode = false;
  currentVehicle: Vehicle | null = null;
  rentalHistory: Rental[] = [];

  vehicleForm: FormGroup = this.fb.group({
    vin: ['', Validators.required],
    licensePlate: ['', Validators.required],
    make: ['', Validators.required],
    model: ['', Validators.required],
    year: ['', [Validators.required, Validators.min(1900)]],
    class: [0, Validators.required],
    dailyRate: ['', [Validators.required, Validators.min(0)]],
  });

  getMaintenanceName = getMaintenanceTypeName;
  getStatusName = getRentalStatusName;

  get vehicleStatusText() {
    if (!this.currentVehicle) return '';
    const status = Number(this.currentVehicle.status);
    return status === 0 ? 'Available' : status === 1 ? 'Rented' : status === 2 ? 'InMaintenance' : 'Unavailable';
  }

  get canToggleAvailability() {
    return this.currentVehicle && (Number(this.currentVehicle.status) === 0 || Number(this.currentVehicle.status) === 3);
  }

  get canStartMaintenance() {
    return this.currentVehicle && Number(this.currentVehicle.status) !== 1 && Number(this.currentVehicle.status) !== 2;
  }

  get canReturnMaintenance() {
    return this.currentVehicle && Number(this.currentVehicle.status) === 2;
  }

  ngOnInit() {
    this.vehicleVin = this.route.snapshot.paramMap.get('vin');
    if (this.vehicleVin) {
      this.isEditMode = true;
      this.loadVehicleData();
    }
    if (!this.store.customers().length) this.store.loadCustomers();
  }

  getCustomerName(id: string | undefined): string {
    if (!id) return 'Unknown Customer';
    const c = this.store.customers().find(x => x.id === id);
    return c && c.contact ? c.contact.name || id : id;
  }

  loadVehicleData() {
    const existing = this.store.vehicles().find(v => v.vin === this.vehicleVin || v.id === this.vehicleVin);
    if (existing) {
      this.currentVehicle = existing;
      this.patchForm(existing);
      if (existing.id) {
        this.loadRentals(existing.id);
      }
    } else {
      this.apiService.getVehicles().subscribe({
        next: (vehicles) => {
          const v = vehicles.find(x => x.vin === this.vehicleVin || x.id === this.vehicleVin);
          if (v) {
            this.currentVehicle = v;
            this.patchForm(v);
            if (v.id) {
              this.loadRentals(v.id);
            }
          }
        },
        error: () => this.toast.error('Failed to load vehicle')
      });
    }
  }

  loadRentals(vehicleId: string) {
    this.apiService.getRentalsByVehicleId(vehicleId).subscribe({
      next: (rentals) => {
        this.rentalHistory = rentals;
      },
      error: () => {
        this.toast.error('Failed to load rental history');
      }
    });
  }

  patchForm(vehicle: Vehicle) {
    this.vehicleForm.patchValue({
      vin: vehicle.vin,
      licensePlate: vehicle.licensePlate,
      make: vehicle.make,
      model: vehicle.model,
      year: vehicle.year,
      class: vehicle.class,
      dailyRate: vehicle.dailyRate
    });
  }

  onSubmit() {
    if (this.vehicleForm.invalid) return;

    const formValue = this.vehicleForm.getRawValue();

    if (this.isEditMode && this.vehicleVin) {
      this.apiService.updateVehicle(this.vehicleVin, formValue).subscribe({
        next: () => {
          this.toast.success('Vehicle updated successfully!');
          this.store.loadVehicles();
          this.goBack();
        },
        error: (err) => this.toast.error(err.message)
      });
    } else {
      this.apiService.createVehicle(formValue).subscribe({
        next: () => {
          this.toast.success('Vehicle created successfully!');
          this.store.loadVehicles();
          this.goBack();
        },
        error: (err) => this.toast.error(err.message)
      });
    }
  }

  deleteVehicle() {
    if (confirm('Are you sure you want to delete this vehicle?')) {
      if (this.currentVehicle?.id) {
        this.store.deleteVehicle(this.currentVehicle.id);
        this.toast.success('Vehicle deleted.');
        this.goBack();
      }
    }
  }

  startMaintenance(description: string, costStr: string, typeStr: string) {
    if (!description || !costStr) {
      this.toast.error('Please provide description and cost');
      return;
    }
    if (this.currentVehicle?.vin) {
      this.store.startMaintenance({ 
        vin: this.currentVehicle.vin, 
        payload: { description, cost: Number(costStr), type: Number(typeStr) } 
      });
      this.toast.success('Sent to maintenance.');
      setTimeout(() => this.loadVehicleData(), 500);
    }
  }

  returnMaintenance() {
    if (this.currentVehicle?.vin) {
      this.store.returnMaintenance(this.currentVehicle.vin);
      this.toast.success('Returned from maintenance.');
      setTimeout(() => this.loadVehicleData(), 500);
    }
  }

  toggleAvailability() {
    if (this.currentVehicle?.vin) {
      this.apiService.toggleAvailability(this.currentVehicle.vin).subscribe({
        next: (res) => {
          this.toast.success(res.message || 'Availability toggled.');
          if (this.currentVehicle) {
            this.currentVehicle.status = Number(this.currentVehicle.status) === 0 ? 3 : 0;
          }
          this.store.loadVehicles();
        },
        error: (err) => this.toast.error(err.message)
      });
    }
  }

  goBack() {
    this.router.navigate(['/vehicles']);
  }
}
