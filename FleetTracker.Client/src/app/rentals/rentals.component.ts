import { Component, OnInit, inject } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { RouterLink } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { FleetStore } from '../store/fleet.store';
import { ApiService } from '../services/api.service';
import { ToastService } from '../services/toast.service';

@Component({
  selector: 'app-rentals',
  standalone: true,
  imports: [CommonModule, DatePipe, RouterLink, FormsModule],
  templateUrl: './rentals.component.html',
})
export class RentalsComponent implements OnInit {
  store = inject(FleetStore);
  apiService = inject(ApiService);
  toast = inject(ToastService);

  statusFilter = '';
  searchQuery = '';

  get filteredRentals() {
    let rentals = this.store.allRentals();
    if (this.statusFilter) {
      rentals = rentals.filter(r => 
        this.statusFilter === 'Active' ? Number(r.status) === 0 : Number(r.status) === 1
      );
    }
    if (this.searchQuery) {
      const q = this.searchQuery.toLowerCase();
      rentals = rentals.filter(r => {
        const v = this.store.vehicles().find(x => x.id === r.vehicleId);
        const c = this.store.customers().find(x => x.id === r.customerId);
        
        const vStr = v ? `${v.make} ${v.model} ${v.licensePlate}`.toLowerCase() : '';
        const cStr = c ? (c.contact?.name || '').toLowerCase() : '';
        const aStr = (r.agreementNumber || '').toLowerCase();

        return vStr.includes(q) || cStr.includes(q) || aStr.includes(q);
      });
    }
    return rentals;
  }

  ngOnInit() {
    this.store.loadAllRentals();
    if (!this.store.vehicles().length) this.store.loadVehicles();
    if (!this.store.customers().length) this.store.loadCustomers();
  }

  getVehicleName(id: string | undefined): string {
    if (!id) return 'Unknown Vehicle';
    const v = this.store.vehicles().find(x => x.id === id);
    return v ? `${v.make} ${v.model} (${v.licensePlate})` : id;
  }

  getCustomerName(id: string | undefined): string {
    if (!id) return 'Unknown Customer';
    const c = this.store.customers().find(x => x.id === id);
    return c && c.contact ? c.contact.name || id : id;
  }

  completeRental(id: string | undefined, event: Event) {
    event.stopPropagation();
    if (!id) return;
    const mileage = prompt('Enter ending mileage:');
    if (mileage) {
      this.apiService.completeRental(id, Number(mileage)).subscribe({
        next: () => {
          this.toast.success('Rental completed');
          this.store.loadAllRentals();
          this.store.loadVehicles();
        },
        error: (err) => this.toast.error(err.message)
      });
    }
  }
}
