import { computed, inject } from '@angular/core';
import { signalStore, withState, withMethods, withComputed, patchState } from '@ngrx/signals';
import { rxMethod } from '@ngrx/signals/rxjs-interop';
import { tapResponse } from '@ngrx/operators';
import { pipe, switchMap, forkJoin, tap } from 'rxjs';
import { ApiService, Vehicle, Rental, Customer } from '../services/api.service';

type FleetState = {
  vehicles: Vehicle[];
  allRentals: Rental[];
  activeRentals: Rental[];
  customers: Customer[];
  isLoading: boolean;
  error: string | null;
};

const initialState: FleetState = {
  vehicles: [],
  allRentals: [],
  activeRentals: [],
  customers: [],
  isLoading: false,
  error: null,
};

export const FleetStore = signalStore(
  { providedIn: 'root' },
  withState(initialState),
  withComputed(({ vehicles, activeRentals }) => ({
    availableVehicles: computed(() => 
      vehicles().filter(v => Number(v.status) === 0 || String(v.status) === 'Available')
    ),
    rentedVehiclesInfo: computed(() => 
      activeRentals().map(rental => ({
        rental,
        vehicle: vehicles().find(veh => veh.id === rental.vehicleId)
      }))
    )
  })),
  withMethods((store, apiService = inject(ApiService)) => ({
    loadDashboardData: rxMethod<void>(
      pipe(
        tap(() => patchState(store, { isLoading: true, error: null })),
        switchMap(() => forkJoin({
          vehicles: apiService.getVehicles(),
          activeRentals: apiService.getActiveRentals()
        }).pipe(
          tapResponse({
            next: (data) => patchState(store, { 
              vehicles: data.vehicles, 
              activeRentals: data.activeRentals, 
              isLoading: false 
            }),
            error: (err: Error) => patchState(store, { error: err.message, isLoading: false })
          })
        ))
      )
    ),
    loadVehicles: rxMethod<void>(
      pipe(
        tap(() => { if (!store.vehicles().length) patchState(store, { isLoading: true, error: null }) }),
        switchMap(() => apiService.getVehicles().pipe(
          tapResponse({
            next: (vehicles) => patchState(store, { vehicles, isLoading: false }),
            error: (err: Error) => patchState(store, { error: err.message, isLoading: false })
          })
        ))
      )
    ),
    loadAllRentals: rxMethod<void>(
      pipe(
        tap(() => { if (!store.allRentals().length) patchState(store, { isLoading: true, error: null }) }),
        switchMap(() => apiService.getAllRentals().pipe(
          tapResponse({
            next: (allRentals) => patchState(store, { allRentals, isLoading: false }),
            error: (err: Error) => patchState(store, { error: err.message, isLoading: false })
          })
        ))
      )
    ),
    loadCustomers: rxMethod<void>(
      pipe(
        tap(() => { if (!store.customers().length) patchState(store, { isLoading: true, error: null }) }),
        switchMap(() => apiService.getCustomers().pipe(
          tapResponse({
            next: (customers) => patchState(store, { customers, isLoading: false }),
            error: (err: Error) => patchState(store, { error: err.message, isLoading: false })
          })
        ))
      )
    ),
    deleteVehicle: rxMethod<string>(
      pipe(
        switchMap((id) => apiService.deleteVehicle(id).pipe(
          tapResponse({
            next: () => {
              patchState(store, { vehicles: store.vehicles().filter(v => v.id !== id) });
            },
            error: (err: Error) => patchState(store, { error: err.message })
          })
        ))
      )
    ),
    deleteCustomer: rxMethod<string>(
      pipe(
        switchMap((id) => apiService.deleteCustomer(id).pipe(
          tapResponse({
            next: () => {
              patchState(store, { customers: store.customers().filter(c => c.id !== id) });
            },
            error: (err: Error) => patchState(store, { error: err.message })
          })
        ))
      )
    ),
    startMaintenance: rxMethod<{ vin: string, payload: any }>(
      pipe(
        switchMap(({ vin, payload }) => apiService.startMaintenance(vin, payload).pipe(
          tapResponse({
            next: () => {
              apiService.getVehicles().subscribe(vehicles => patchState(store, { vehicles }));
            },
            error: (err: Error) => patchState(store, { error: err.message })
          })
        ))
      )
    ),
    returnMaintenance: rxMethod<string>(
      pipe(
        switchMap((vin) => apiService.returnMaintenance(vin).pipe(
          tapResponse({
            next: () => {
              apiService.getVehicles().subscribe(vehicles => patchState(store, { vehicles }));
            },
            error: (err: Error) => patchState(store, { error: err.message })
          })
        ))
      )
    )
  }))
);
