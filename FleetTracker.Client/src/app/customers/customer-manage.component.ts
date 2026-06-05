import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { ApiService, Customer, Rental } from '../services/api.service';
import { ToastService } from '../services/toast.service';
import { FleetStore } from '../store/fleet.store';
import { CommonModule } from '@angular/common';
import { getRentalStatusName } from '../models/enums';

@Component({
  selector: 'app-customer-manage',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule, RouterLink],
  template: `
    <h2>{{ isEditMode ? 'Edit Customer' : 'New Customer' }}</h2>
    
    <div style="display: flex; gap: 30px; flex-wrap: wrap;">
      <form [formGroup]="customerForm" (ngSubmit)="onSubmit()" style="flex: 1; min-width: 300px; max-width: 500px; display: flex; flex-direction: column; gap: 15px;">
        
        <fieldset style="display: flex; flex-direction: column; gap: 10px;">
          <legend>Basic Info</legend>
          <label>Driver's License: <input formControlName="driversLicense" type="text" /></label>
          <label>Date of Birth: <input formControlName="dateOfBirth" type="date" /></label>
        </fieldset>

        <fieldset formGroupName="contact" style="display: flex; flex-direction: column; gap: 10px;">
          <legend>Contact Info</legend>
          <label>Name: <input formControlName="name" type="text" /></label>
          <label>Email: <input formControlName="email" type="email" /></label>
          <label>Phone: <input formControlName="phoneNumber" type="text" /></label>
        </fieldset>

        <fieldset formGroupName="homeAddress" style="display: flex; flex-direction: column; gap: 10px;">
          <legend>Home Address</legend>
          <label>Street: <input formControlName="street" type="text" /></label>
          <label>City: <input formControlName="city" type="text" /></label>
          <label>State: <input formControlName="state" type="text" /></label>
          <label>Zip: <input formControlName="zip" type="text" /></label>
          <label>Country: <input formControlName="country" type="text" /></label>
        </fieldset>

        <fieldset formGroupName="paymentInformation" style="display: flex; flex-direction: column; gap: 10px;">
          <legend>Payment Info</legend>
          
          <div formGroupName="creditCard" style="display: flex; flex-direction: column; gap: 10px;">
            <label>Cardholder Name: <input formControlName="cardHolderName" type="text" /></label>
            <label>Card Number: <input formControlName="cardNumber" type="text" /></label>
            <label>Expiration Date: <input formControlName="expirationDate" type="text" placeholder="MM/YY" /></label>
            <label>CVV: <input formControlName="cvv" type="text" /></label>
          </div>

          <label style="margin-top: 10px; font-weight: bold;">
            <input type="checkbox" [checked]="sameAsHome" (change)="toggleSameAsHome($event)" />
            Billing address is same as Home address
          </label>

          @if (!sameAsHome) {
            <div formGroupName="billingAddress" style="display: flex; flex-direction: column; gap: 10px; margin-top: 10px; padding-left: 10px; border-left: 2px solid #ccc;">
              <label>Street: <input formControlName="street" type="text" /></label>
              <label>City: <input formControlName="city" type="text" /></label>
              <label>State: <input formControlName="state" type="text" /></label>
              <label>Zip: <input formControlName="zip" type="text" /></label>
              <label>Country: <input formControlName="country" type="text" /></label>
            </div>
          }
        </fieldset>

        <div style="display: flex; gap: 10px; margin-top: 20px;">
          <button type="submit" [disabled]="customerForm.invalid" style="padding: 8px 16px; cursor: pointer;">Save Customer</button>
          <button type="button" (click)="goBack()" style="padding: 8px 16px; cursor: pointer;">Cancel</button>
          @if (isEditMode) {
            <button type="button" (click)="deleteCustomer()" style="padding: 8px 16px; background-color: #f44336; color: white; border: none; cursor: pointer; margin-left: auto;">Delete</button>
          }
        </div>
      </form>

      @if (isEditMode) {
        <div style="flex: 1; min-width: 300px; padding: 20px; border: 1px solid #ccc; border-radius: 8px;">
          <h3>Rental History</h3>
          @if (rentalHistory.length) {
            <table style="width: 100%; border-collapse: collapse; text-align: left;">
              <thead>
                <tr style="border-bottom: 2px solid #ccc;">
                  <th style="padding: 8px;">Agreement #</th>
                  <th style="padding: 8px;">Vehicle</th>
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
                      <a [routerLink]="['/vehicles', rental.vehicleId]" (click)="$event.stopPropagation()" style="color: #007bff; text-decoration: none;">
                        {{ getVehicleName(rental.vehicleId) }}
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
      }
    </div>
  `,
})
export class CustomerManageComponent implements OnInit {
  private fb = inject(FormBuilder);
  private route = inject(ActivatedRoute);
  private router = inject(Router);
  private apiService = inject(ApiService);
  private toast = inject(ToastService);
  private store = inject(FleetStore);

  customerId: string | null = null;
  isEditMode = false;
  sameAsHome = true;
  rentalHistory: Rental[] = [];

  customerForm: FormGroup = this.fb.group({
    driversLicense: ['', Validators.required],
    dateOfBirth: ['', Validators.required],
    contact: this.fb.group({
      name: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      phoneNumber: ['', Validators.required],
    }),
    homeAddress: this.fb.group({
      street: [''],
      city: [''],
      state: [''],
      zip: [''],
      country: [''],
    }),
    paymentInformation: this.fb.group({
      creditCard: this.fb.group({
        cardNumber: [''],
        cardHolderName: [''],
        expirationDate: [''],
        cvv: [''],
      }),
      billingAddress: this.fb.group({
        street: [''],
        city: [''],
        state: [''],
        zip: [''],
        country: [''],
      })
    })
  });

  getStatusName = getRentalStatusName;

  ngOnInit() {
    this.customerId = this.route.snapshot.paramMap.get('id');
    if (this.customerId) {
      this.isEditMode = true;
      this.loadCustomerData();
      this.loadRentals(this.customerId);
    }
    if (!this.store.vehicles().length) this.store.loadVehicles();
  }

  getVehicleName(id: string | undefined): string {
    if (!id) return 'Unknown Vehicle';
    const v = this.store.vehicles().find(x => x.id === id);
    return v ? `${v.make} ${v.model}` : id;
  }

  toggleSameAsHome(event: any) {
    this.sameAsHome = event.target.checked;
  }

  loadRentals(customerId: string) {
    this.apiService.getRentalsByCustomerId(customerId).subscribe({
      next: (rentals) => {
        this.rentalHistory = rentals;
      },
      error: () => {
        this.toast.error('Failed to load rental history');
      }
    });
  }

  loadCustomerData() {
    const existingCustomer = this.store.customers().find(c => c.id === this.customerId);
    if (existingCustomer) {
      this.patchForm(existingCustomer);
    } else {
      this.apiService.getCustomers().subscribe({
        next: (customers) => {
          const c = customers.find(x => x.id === this.customerId);
          if (c) this.patchForm(c);
        },
        error: () => this.toast.error('Failed to load customer')
      });
    }
  }

  patchForm(customer: Customer) {
    let dob = customer.dateOfBirth;
    if (dob && dob.includes('T')) {
      dob = dob.split('T')[0];
    }

    let isSame = true;
    if (customer.paymentInformation?.billingAddress && customer.homeAddress) {
      const b = customer.paymentInformation.billingAddress;
      const h = customer.homeAddress;
      if (b.street !== h.street || b.city !== h.city || b.state !== h.state || b.zip !== h.zip || b.country !== h.country) {
        isSame = false;
      }
    }
    this.sameAsHome = isSame;

    this.customerForm.patchValue({
      driversLicense: customer.driversLicense,
      dateOfBirth: dob,
      contact: customer.contact || {},
      homeAddress: customer.homeAddress || {},
      paymentInformation: {
        creditCard: customer.paymentInformation?.creditCard || {},
        billingAddress: customer.paymentInformation?.billingAddress || {}
      }
    });
  }

  onSubmit() {
    if (this.customerForm.invalid) return;

    const formValue = JSON.parse(JSON.stringify(this.customerForm.value));
    
    if (!formValue.paymentInformation.creditCard.cardNumber) {
      delete formValue.paymentInformation;
    } else {
      if (this.sameAsHome) {
        formValue.paymentInformation.billingAddress = formValue.homeAddress;
      }
    }
    
    if (!formValue.homeAddress.street) {
      delete formValue.homeAddress;
    }

    if (this.isEditMode && this.customerId) {
      this.apiService.updateCustomer(this.customerId, formValue).subscribe({
        next: () => {
          this.toast.success('Customer updated successfully!');
          this.store.loadCustomers(); 
          this.goBack();
        },
        error: (err) => this.toast.error(err.message)
      });
    } else {
      this.apiService.createCustomer(formValue).subscribe({
        next: () => {
          this.toast.success('Customer created successfully!');
          this.store.loadCustomers(); 
          this.goBack();
        },
        error: (err) => this.toast.error(err.message)
      });
    }
  }

  deleteCustomer() {
    if (confirm('Are you sure you want to delete this customer?')) {
      if (this.customerId) {
        this.store.deleteCustomer(this.customerId);
        this.toast.success('Customer deleted.');
        this.goBack();
      }
    }
  }

  goBack() {
    this.router.navigate(['/customers']);
  }
}
