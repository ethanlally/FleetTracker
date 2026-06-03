import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApiService, Customer } from '../services/api.service';

@Component({
  selector: 'app-customers',
  standalone: true,
  imports: [CommonModule],
  template: `
    <h2>Customers</h2>
    <div *ngIf="loading">Loading...</div>
    <div *ngIf="!loading">
      <table border="1" cellpadding="5" cellspacing="0">
        <thead>
          <tr>
            <th>Name</th>
            <th>Email</th>
            <th>Phone Number</th>
            <th>Driver's License</th>
            <th>Date of Birth</th>
          </tr>
        </thead>
        <tbody>
          <tr *ngFor="let customer of customers">
            <td>{{ customer.contact?.name }}</td>
            <td>{{ customer.contact?.email }}</td>
            <td>{{ customer.contact?.phoneNumber }}</td>
            <td>{{ customer.driversLicense }}</td>
            <td>{{ customer.dateOfBirth | date: 'shortDate' }}</td>
          </tr>
        </tbody>
      </table>
    </div>
  `,
})
export class CustomersComponent implements OnInit {
  customers: Customer[] = [];
  loading = true;

  constructor(private apiService: ApiService) {}

  ngOnInit() {
    this.apiService.getCustomers().subscribe((data) => {
      this.customers = data;
      this.loading = false;
    });
  }
}
