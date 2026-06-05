import { Component, OnInit, ElementRef, inject, effect, viewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { FleetStore } from '../store/fleet.store';
import { getVehicleStatusName } from '../models/enums';
import Chart from 'chart.js/auto';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterLink],
  templateUrl: './dashboard.component.html',
})
export class DashboardComponent implements OnInit {
  store = inject(FleetStore);
  chartRef = viewChild<ElementRef<HTMLCanvasElement>>('fleetChart');
  chartInstance: Chart | null = null;

  searchAvailable = '';
  searchRented = '';

  get filteredAvailableVehicles() {
    let v = this.store.availableVehicles();
    if (this.searchAvailable) {
      const q = this.searchAvailable.toLowerCase();
      v = v.filter(x => `${x.make} ${x.model} ${x.licensePlate}`.toLowerCase().includes(q));
    }
    return v;
  }

  get filteredRentedVehiclesInfo() {
    let info = this.store.rentedVehiclesInfo();
    if (this.searchRented) {
      const q = this.searchRented.toLowerCase();
      info = info.filter(x => {
        const vStr = x.vehicle ? `${x.vehicle.make} ${x.vehicle.model} ${x.vehicle.licensePlate}`.toLowerCase() : '';
        return vStr.includes(q);
      });
    }
    return info;
  }

  constructor() {
    effect(() => {
      const canvasRef = this.chartRef();
      const vehicles = this.store.vehicles();

      if (canvasRef && vehicles.length > 0) {
        if (!this.chartInstance) {
          this.chartInstance = new Chart(canvasRef.nativeElement, {
            type: 'doughnut',
            data: {
              labels: ['Available', 'Rented', 'Maintenance', 'Unavailable'],
              datasets: [{
                data: [0, 0, 0, 0],
                backgroundColor: ['#4caf50', '#2196f3', '#ff9800', '#f44336']
              }]
            },
            options: {
              responsive: true,
              maintainAspectRatio: false,
              plugins: {
                legend: { position: 'right' },
                tooltip: {
                  callbacks: {
                    label: (context: any) => {
                      const label = context.label || '';
                      const value = context.raw || 0;
                      const total = context.dataset.data.reduce((a: number, b: number) => a + b, 0);
                      const percentage = total > 0 ? Math.round((value / total) * 100) : 0;
                      return `${label}: ${value} (${percentage}%)`;
                    }
                  }
                }
              }
            }
          });
        }

        const available = vehicles.filter(v => Number(v.status) === 0 || String(v.status) === 'Available').length;
        const rented = vehicles.filter(v => Number(v.status) === 1 || String(v.status) === 'Rented').length;
        const maintenance = vehicles.filter(v => Number(v.status) === 2 || String(v.status) === 'InMaintenance').length;
        const unavailable = vehicles.filter(v => Number(v.status) === 3 || String(v.status) === 'Unavailable').length;
        
        this.chartInstance.data.datasets[0].data = [available, rented, maintenance, unavailable];
        this.chartInstance.update();
      }
    });
  }

  ngOnInit() {
    this.store.loadDashboardData();
  }

  getStatusName(statusEnum: any): string {
    return getVehicleStatusName(statusEnum);
  }
}
