import { Component } from '@angular/core';
import { RouterOutlet, RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, RouterLink, RouterLinkActive],
  template: `
    <div style="font-family: sans-serif; padding: 20px;">
      <h1>FleetTracker Dashboard</h1>
      <nav style="margin-bottom: 20px; display: flex; gap: 15px;">
        <a
          routerLink="/dashboard"
          routerLinkActive="active"
          style="text-decoration: none; color: blue;"
          >Overview</a
        >
        <a
          routerLink="/vehicles"
          routerLinkActive="active"
          style="text-decoration: none; color: blue;"
          >Vehicles</a
        >
        <a
          routerLink="/rentals"
          routerLinkActive="active"
          style="text-decoration: none; color: blue;"
          >Rentals</a
        >
        <a
          routerLink="/customers"
          routerLinkActive="active"
          style="text-decoration: none; color: blue;"
          >Customers</a
        >
      </nav>
      <hr style="margin-bottom: 20px; border: 1px solid #ccc;" />
      <main>
        <router-outlet></router-outlet>
      </main>
    </div>
  `,
  styles: [
    `
      .active {
        font-weight: bold;
        text-decoration: underline !important;
      }
    `,
  ],
})
export class App {}
