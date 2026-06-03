import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Vehicle {
  id: string;
  vin: string;
  licensePlate: string;
  make: string;
  model: string;
  year: number;
  class: number;
  dailyRate: number;
  status: string;
  maintenanceHistory?: {
    description: string;
    cost: number;
    serviceDate: string;
  }[];
}

export interface Rental {
  id: string;
  agreementNumber: string;
  vehicleId: string;
  customerId: string;
  pickupDate: string;
  expectedReturnDate: string;
  status: string;
}

export interface Customer {
  id: string;
  driversLicense: string;
  dateOfBirth: string;
  contact: {
    name: string;
    email: string;
    phoneNumber: string;
  };
}

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  // Using relative path for the Aspire proxy to route correctly
  private baseUrl = '/api';

  constructor(private http: HttpClient) {}

  getVehicles(): Observable<Vehicle[]> {
    return this.http.get<Vehicle[]>(`${this.baseUrl}/vehicles`);
  }

  getActiveRentals(): Observable<Rental[]> {
    return this.http.get<Rental[]>(`${this.baseUrl}/rentals/active`);
  }

  getAllRentals(): Observable<Rental[]> {
    return this.http.get<Rental[]>(`${this.baseUrl}/rentals`);
  }

  getCustomers(): Observable<Customer[]> {
    return this.http.get<Customer[]>(`${this.baseUrl}/customers`);
  }
}
