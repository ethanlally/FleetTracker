import { Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { VehiclesComponent } from './vehicles/vehicles.component';
import { VehicleManageComponent } from './vehicles/vehicle-manage.component';
import { RentalsComponent } from './rentals/rentals.component';
import { RentalCreateComponent } from './rentals/rental-create.component';
import { CustomersComponent } from './customers/customers.component';
import { CustomerManageComponent } from './customers/customer-manage.component';
import { RentalManageComponent } from './rentals/rental-manage.component';

export const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'vehicles', component: VehiclesComponent },
  { path: 'vehicles/new', component: VehicleManageComponent },
  { path: 'vehicles/:vin', component: VehicleManageComponent },
  { path: 'rentals', component: RentalsComponent },
  { path: 'rentals/new', component: RentalCreateComponent },
  { path: 'rentals/:id', component: RentalManageComponent },
  { path: 'customers', component: CustomersComponent },
  { path: 'customers/new', component: CustomerManageComponent },
  { path: 'customers/:id', component: CustomerManageComponent },
];
