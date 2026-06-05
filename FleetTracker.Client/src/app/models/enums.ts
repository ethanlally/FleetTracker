export enum VehicleStatus {
  Available = 0,
  Rented = 1,
  InMaintenance = 2,
  Unavailable = 3
}

export enum RentalStatus {
  Active = 0,
  Completed = 1,
  Cancelled = 2
}

export enum MaintenanceType {
  Routine = 0,
  Repair = 1,
  Inspection = 2
}

export function getVehicleStatusName(statusEnum: VehicleStatus | number | string | undefined | null): string {
  if (statusEnum === undefined || statusEnum === null) return '';
  const statusMap: { [key: number]: string } = {
    [VehicleStatus.Available]: 'Available',
    [VehicleStatus.Rented]: 'Rented',
    [VehicleStatus.InMaintenance]: 'InMaintenance',
    [VehicleStatus.Unavailable]: 'Unavailable',
  };
  return statusMap[Number(statusEnum)] || String(statusEnum);
}

export function getRentalStatusName(statusEnum: RentalStatus | number | string | undefined | null): string {
  if (statusEnum === undefined || statusEnum === null) return '';
  const statusMap: { [key: number]: string } = {
    [RentalStatus.Active]: 'Active',
    [RentalStatus.Completed]: 'Completed',
    [RentalStatus.Cancelled]: 'Cancelled',
  };
  return statusMap[Number(statusEnum)] || String(statusEnum);
}

export function getMaintenanceTypeName(typeEnum: MaintenanceType | number | string | undefined | null): string {
  if (typeEnum === undefined || typeEnum === null) return '';
  const map: { [key: number]: string } = {
    [MaintenanceType.Routine]: 'Routine',
    [MaintenanceType.Repair]: 'Repair',
    [MaintenanceType.Inspection]: 'Inspection',
  };
  return map[Number(typeEnum)] || String(typeEnum);
}
