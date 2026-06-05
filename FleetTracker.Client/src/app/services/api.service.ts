import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

export interface Address {
  street?: string;
  city?: string;
  state?: string;
  zip?: string;
  country?: string;
}

export interface CreditCard {
  cardNumber?: string;
  cardHolderName?: string;
  expirationDate?: string;
  cvv?: string;
}

export interface PaymentInformation {
  billingAddress?: Address;
  creditCard?: CreditCard;
}

export interface Vehicle {
  id?: string;
  vin?: string;
  licensePlate?: string;
  make?: string;
  model?: string;
  year?: number;
  class?: number;
  dailyRate?: number;
  status?: string | number;
  maintenanceHistory?: {
    description: string;
    cost: number;
    serviceDate: string;
    type: number;
  }[];
}

export interface Rental {
  id?: string;
  agreementNumber?: string;
  vehicleId?: string;
  customerId?: string;
  pickupDate?: string;
  expectedReturnDate?: string;
  actualReturnDate?: string;
  startingMileage?: number;
  endingMileage?: number;
  totalCost?: number;
  status?: string | number;
}

export interface Customer {
  id?: string;
  driversLicense?: string;
  dateOfBirth?: string;
  contact?: {
    name?: string;
    email?: string;
    phoneNumber?: string;
  };
  homeAddress?: Address;
  paymentInformation?: PaymentInformation;
}

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  private baseUrl = '/api';

  constructor(private http: HttpClient) {}

  // --- Vehicles ---
  getVehicles(): Observable<Vehicle[]> {
    return this.http.get<Vehicle[]>(`${this.baseUrl}/vehicles`).pipe(catchError(this.handleError));
  }

  createVehicle(vehicle: Partial<Vehicle>): Observable<Vehicle> {
    return this.http.post<Vehicle>(`${this.baseUrl}/vehicles`, vehicle).pipe(catchError(this.handleError));
  }

  updateVehicle(vin: string, vehicle: Partial<Vehicle>): Observable<Vehicle> {
    return this.http.put<Vehicle>(`${this.baseUrl}/vehicles/${vin}`, vehicle).pipe(catchError(this.handleError));
  }

  deleteVehicle(id: string): Observable<void> {
    return this.http.delete<void>(`${this.baseUrl}/vehicles/${id}`).pipe(catchError(this.handleError));
  }

  toggleAvailability(vin: string): Observable<any> {
    return this.http.post<any>(`${this.baseUrl}/vehicles/${vin}/toggle`, {}).pipe(catchError(this.handleError));
  }

  startMaintenance(vin: string, payload: any): Observable<void> {
    return this.http.post<void>(`${this.baseUrl}/vehicles/${vin}/maintenance/start`, payload).pipe(catchError(this.handleError));
  }

  returnMaintenance(vin: string): Observable<void> {
    return this.http.post<void>(`${this.baseUrl}/vehicles/${vin}/maintenance/return`, {}).pipe(catchError(this.handleError));
  }

  // --- Rentals ---
  getActiveRentals(): Observable<Rental[]> {
    return this.http.get<Rental[]>(`${this.baseUrl}/rentals/active`).pipe(catchError(this.handleError));
  }

  getAllRentals(): Observable<Rental[]> {
    return this.http.get<Rental[]>(`${this.baseUrl}/rentals`).pipe(catchError(this.handleError));
  }

  getRentalsByCustomerId(customerId: string): Observable<Rental[]> {
    return this.http.get<Rental[]>(`${this.baseUrl}/rentals/customer/${customerId}`).pipe(catchError(this.handleError));
  }

  getRentalsByVehicleId(vehicleId: string): Observable<Rental[]> {
    return this.http.get<Rental[]>(`${this.baseUrl}/rentals/vehicle/${vehicleId}`).pipe(catchError(this.handleError));
  }

  startRental(rental: Partial<Rental>): Observable<Rental> {
    return this.http.post<Rental>(`${this.baseUrl}/rentals/start`, rental).pipe(catchError(this.handleError));
  }

  updateRental(id: string, rental: any): Observable<Rental> {
    return this.http.put<Rental>(`${this.baseUrl}/rentals/${id}`, rental).pipe(catchError(this.handleError));
  }

  completeRental(id: string, endingMileage: number): Observable<void> {
    return this.http.post<void>(`${this.baseUrl}/rentals/${id}/complete`, { endingMileage }).pipe(catchError(this.handleError));
  }

  // --- Customers ---
  getCustomers(): Observable<Customer[]> {
    return this.http.get<Customer[]>(`${this.baseUrl}/customers`).pipe(catchError(this.handleError));
  }

  createCustomer(customer: Partial<Customer>): Observable<Customer> {
    return this.http.post<Customer>(`${this.baseUrl}/customers`, customer).pipe(catchError(this.handleError));
  }

  updateCustomer(id: string, customer: Partial<Customer>): Observable<Customer> {
    return this.http.put<Customer>(`${this.baseUrl}/customers/${id}`, customer).pipe(catchError(this.handleError));
  }

  deleteCustomer(id: string): Observable<void> {
    return this.http.delete<void>(`${this.baseUrl}/customers/${id}`).pipe(catchError(this.handleError));
  }

  private handleError(error: HttpErrorResponse) {
    console.error('API Error:', error);
    let msg = 'Something went wrong. Please try again later.';
    
    if (error.error) {
      if (typeof error.error === 'string') {
        msg = error.error;
      } else if (error.error.errors) {
        const errors = Object.entries(error.error.errors).map(([key, messages]: [string, any]) => {
          return `${key}: ${messages.join(', ')}`;
        });
        msg = errors.join(' | ');
      } else if (error.error.title) {
        msg = error.error.title;
      }
    }
    
    return throwError(() => new Error(msg));
  }
}
