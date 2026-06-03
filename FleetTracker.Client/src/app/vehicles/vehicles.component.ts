import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApiService, Vehicle } from '../services/api.service';

@Component({
  selector: 'app-vehicles',
  standalone: true,
  imports: [CommonModule],
  template: `
    <h2>Vehicles</h2>
    <div *ngIf="loading">Loading...</div>
    <div *ngIf="!loading">
      <table border="1" cellpadding="5" cellspacing="0">
        <thead>
          <tr>
            <th>VIN</th>
            <th>Name</th>
            <th>Year</th>
            <th>License Plate</th>
            <th>Status</th>
            <th>Daily Rate</th>
            <th>Maintenance Info</th>
          </tr>
        </thead>
        <tbody>
          <tr *ngFor="let vehicle of vehicles">
            <td>{{ vehicle.vin }}</td>
            <td>{{ vehicle.make }} {{ vehicle.model }}</td>
            <td>{{ vehicle.year }}</td>
            <td>{{ vehicle.licensePlate }}</td>
            <td>{{ getStatusName(vehicle.status) }}</td>
            <td>{{ vehicle.dailyRate | currency }}</td>
            <td>
              <span *ngIf="isVehicleInMaintenance(vehicle)">
                Reason: {{ getLatestMaintenance(vehicle)?.description }} | Cost:
                {{ getLatestMaintenance(vehicle)?.cost | currency }}
              </span>
              <span *ngIf="!isVehicleInMaintenance(vehicle)">-</span>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  `,
})
export class VehiclesComponent implements OnInit {
  vehicles: Vehicle[] = [];
  loading = true;

  constructor(private apiService: ApiService) {}

  ngOnInit() {
    this.apiService.getVehicles().subscribe((data) => {
      this.vehicles = data;
      this.loading = false;
    });
  }

  getStatusName(statusEnum: any): string {
    const statusMap: { [key: number]: string } = {
      0: 'Available',
      1: 'Rented',
      2: 'InMaintenance',
      3: 'Unavailable',
    };
    return statusMap[Number(statusEnum)] || statusEnum;
  }

  isVehicleInMaintenance(vehicle: Vehicle): boolean {
    return Number(vehicle.status) === 2 || vehicle.status === 'InMaintenance';
  }

  getLatestMaintenance(vehicle: Vehicle): any {
    if (vehicle.maintenanceHistory && vehicle.maintenanceHistory.length > 0) {
      return vehicle.maintenanceHistory[vehicle.maintenanceHistory.length - 1];
    }
    return null;
  }
}
