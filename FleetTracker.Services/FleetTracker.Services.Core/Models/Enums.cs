using System;

namespace FleetTracker.Services.Core.Models
{
    public enum VehicleClass
    {
        Compact,
        Sedan,
        SUV,
        Truck,
        Luxury
    }

    public enum VehicleStatus
    {
        Available,
        Rented,
        InMaintenance,
        Unavailable,
        Retired
    }

    public enum RentalStatus
    {
        Active,
        Completed,
        Cancelled
    }

    public enum MaintenanceType
    {
        Routine,
        Repair,
        Inspection
    }
}