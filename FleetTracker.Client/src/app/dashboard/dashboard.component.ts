import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApiService, Vehicle, Rental } from '../services/api.service';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [CommonModule],
  template: `
    <h2>Dashboard Overview</h2>
    <div *ngIf="loading">Loading...</div>
    <div *ngIf="!loading">
      <h3>Available Vehicles</h3>
      <table border="1" cellpadding="5" cellspacing="0" style="margin-bottom: 20px;">
        <thead>
          <tr>
            <th>Name</th>
            <th>License Plate</th>
            <th>Status</th>
            <th>Daily Rate</th>
          </tr>
        </thead>
        <tbody>
          <tr *ngFor="let vehicle of availableVehicles">
            <td>{{ vehicle.make }} {{ vehicle.model }}</td>
            <td>{{ vehicle.licensePlate }}</td>
            <td>{{ getStatusName(vehicle.status) }}</td>
            <td>{{ vehicle.dailyRate | currency }}</td>
          </tr>
          <tr *ngIf="availableVehicles.length === 0">
            <td colspan="4">No vehicles available.</td>
          </tr>
        </tbody>
      </table>

      <h3>Currently Rented Vehicles</h3>
      <table border="1" cellpadding="5" cellspacing="0">
        <thead>
          <tr>
            <th>Name</th>
            <th>License Plate</th>
            <th>Status</th>
            <th>Daily Rate</th>
            <th>Start Date</th>
            <th>Expected Return</th>
          </tr>
        </thead>
        <tbody>
          <tr *ngFor="let rentalInfo of rentedVehiclesInfo">
            <td>{{ rentalInfo.vehicle?.make }} {{ rentalInfo.vehicle?.model }}</td>
            <td>{{ rentalInfo.vehicle?.licensePlate }}</td>
            <td>{{ getStatusName(rentalInfo.vehicle?.status) }}</td>
            <td>{{ rentalInfo.vehicle?.dailyRate | currency }}</td>
            <td>{{ rentalInfo.rental.pickupDate | date: 'shortDate' }}</td>
            <td>{{ rentalInfo.rental.expectedReturnDate | date: 'shortDate' }}</td>
          </tr>
          <tr *ngIf="rentedVehiclesInfo.length === 0">
            <td colspan="6">No active rentals.</td>
          </tr>
        </tbody>
      </table>
    </div>
  `,
})
export class DashboardComponent implements OnInit {
  vehicles: Vehicle[] = [];
  availableVehicles: Vehicle[] = [];
  activeRentals: Rental[] = [];
  rentedVehiclesInfo: { vehicle: Vehicle | undefined; rental: Rental }[] = [];
  loading = true;

  constructor(private apiService: ApiService) {}

  ngOnInit() {
    this.apiService.getVehicles().subscribe((v) => {
      this.vehicles = v;
      this.availableVehicles = this.vehicles.filter((veh) => this.isAvailable(veh));

      this.apiService.getActiveRentals().subscribe((r) => {
        this.activeRentals = r;
        this.rentedVehiclesInfo = this.activeRentals.map((rental) => {
          return {
            rental: rental,
            vehicle: this.vehicles.find((veh) => veh.id === rental.vehicleId),
          };
        });
        this.loading = false;
      });
    });
  }

  getStatusName(statusEnum: any): string {
    if (statusEnum === undefined || statusEnum === null) return '';
    const statusMap: { [key: number]: string } = {
      0: 'Available',
      1: 'Rented',
      2: 'InMaintenance',
      3: 'Unavailable',
    };
    return statusMap[Number(statusEnum)] || statusEnum;
  }

  isAvailable(vehicle: Vehicle): boolean {
    return Number(vehicle.status) === 0 || vehicle.status === 'Available';
  }
}
