import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApiService, Rental } from '../services/api.service';

@Component({
  selector: 'app-rentals',
  standalone: true,
  imports: [CommonModule],
  template: `
    <h2>Rentals</h2>
    <div *ngIf="loading">Loading...</div>
    <div *ngIf="!loading">
      <table border="1" cellpadding="5" cellspacing="0">
        <thead>
          <tr>
            <th>Agreement Number</th>
            <th>Customer ID</th>
            <th>Vehicle ID</th>
            <th>Pickup Date</th>
            <th>Expected Return</th>
            <th>Status</th>
          </tr>
        </thead>
        <tbody>
          <tr *ngFor="let rental of rentals">
            <td>{{ rental.agreementNumber }}</td>
            <td>{{ rental.customerId }}</td>
            <td>{{ rental.vehicleId }}</td>
            <td>{{ rental.pickupDate | date: 'shortDate' }}</td>
            <td>{{ rental.expectedReturnDate | date: 'shortDate' }}</td>
            <td>{{ getStatusName(rental.status) }}</td>
          </tr>
        </tbody>
      </table>
    </div>
  `,
})
export class RentalsComponent implements OnInit {
  rentals: Rental[] = [];
  loading = true;

  constructor(private apiService: ApiService) {}

  ngOnInit() {
    this.apiService.getAllRentals().subscribe((data) => {
      this.rentals = data;
      this.loading = false;
    });
  }

  getStatusName(statusEnum: any): string {
    const statusMap: { [key: number]: string } = {
      0: 'Active',
      1: 'Completed',
      2: 'Cancelled',
    };
    return statusMap[Number(statusEnum)] || statusEnum;
  }
}
