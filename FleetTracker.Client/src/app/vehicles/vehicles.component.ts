import { Component, OnInit, inject } from '@angular/core';
import { CommonModule, CurrencyPipe } from '@angular/common';
import { RouterLink } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { FleetStore } from '../store/fleet.store';
import { getVehicleStatusName } from '../models/enums';

@Component({
  selector: 'app-vehicles',
  standalone: true,
  imports: [CommonModule, CurrencyPipe, RouterLink, FormsModule],
  templateUrl: './vehicles.component.html',
})
export class VehiclesComponent implements OnInit {
  store = inject(FleetStore);
  statusFilter = '';
  searchQuery = '';

  get filteredVehicles() {
    let v = this.store.vehicles();
    if (this.statusFilter) {
      v = v.filter(x => this.getStatusName(x.status) === this.statusFilter);
    }
    if (this.searchQuery) {
      const q = this.searchQuery.toLowerCase();
      v = v.filter(x => {
        const vStr = `${x.make} ${x.model} ${x.licensePlate}`.toLowerCase();
        return vStr.includes(q);
      });
    }
    return v;
  }

  ngOnInit() {
    this.store.loadVehicles();
  }

  getStatusName(statusEnum: any): string {
    return getVehicleStatusName(statusEnum);
  }
}
