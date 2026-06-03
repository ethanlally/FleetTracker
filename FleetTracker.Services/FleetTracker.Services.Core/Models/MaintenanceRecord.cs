using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetTracker.Services.Core.Models
{
    public class MaintenanceRecord
    {
        public DateTime ServiceDate { get; private set; }
        public string Description { get; private set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; private set; }
        public MaintenanceType Type { get; private set; }

        public Guid VehicleId { get; private set; }
        public MaintenanceRecord(Guid vehicleId, DateTime serviceDate, string description, decimal cost, MaintenanceType type)
        {
            VehicleId = vehicleId;
            ServiceDate = serviceDate;
            Description = description;
            Cost = cost;
            Type = type;
        }
    }
}