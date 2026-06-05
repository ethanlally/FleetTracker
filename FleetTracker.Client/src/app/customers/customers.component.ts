import { Component, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { FleetStore } from '../store/fleet.store';
import { PhonePipe } from '../pipes/phone.pipe';

@Component({
  selector: 'app-customers',
  standalone: true,
  imports: [CommonModule, RouterLink, FormsModule, PhonePipe],
  templateUrl: './customers.component.html',
})
export class CustomersComponent implements OnInit {
  store = inject(FleetStore);
  filterText = '';

  get filteredCustomers() {
    if (!this.filterText) return this.store.customers();
    const lower = this.filterText.toLowerCase();
    return this.store.customers().filter(c => 
      c.contact?.name?.toLowerCase().includes(lower) || 
      c.contact?.email?.toLowerCase().includes(lower)
    );
  }

  ngOnInit() {
    this.store.loadCustomers();
  }
}
