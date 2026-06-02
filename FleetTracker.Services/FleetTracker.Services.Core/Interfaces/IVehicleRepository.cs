using System;
using System.Collections.Generic;
using FleetTracker.Services.Core.Models;

namespace FleetTracker.Services.Core.Interfaces
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAllVehicles();
        Vehicle? GetVehicleById(Guid id);
        Vehicle? GetVehicleByVin(string vin);
        void AddVehicle(Vehicle vehicle);
        void UpdateVehicle(Vehicle vehicle);
        void DeleteVehicle(Guid id);
        
        void SendVehicleToMaintenance(string vin, string description, decimal cost);
        void ReturnVehicleFromMaintenance(string vin);
        void ToggleVehicleAvailability(string vin);
    }
}
