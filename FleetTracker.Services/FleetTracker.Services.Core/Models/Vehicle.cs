using System;
using System.Collections.Generic;

namespace FleetTracker.Services.Core.Models
{
    public class Vehicle : Entity
    {
        public string VIN { get; private set; }
        public string LicensePlate { get; private set; }
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public VehicleClass Class { get; private set; }
        public decimal DailyRate { get; private set; }
        public VehicleStatus Status { get; private set; }


        public ICollection<MaintenanceRecord> MaintenanceHistory { get; private set; } = new List<MaintenanceRecord>();

#pragma warning disable CS8618
        private Vehicle() : base() { } // Required for EF Core
#pragma warning restore CS8618

        public Vehicle(string vin, string licensePlate, string make, string model, int year, VehicleClass vehicleClass, decimal dailyRate)
            : base()
        {
            VIN = vin;
            LicensePlate = licensePlate;
            Make = make;
            Model = model;
            Year = year;
            Class = vehicleClass;
            DailyRate = dailyRate;
            Status = VehicleStatus.Available;
        }

        public void UpdateDetails(string vin, string licensePlate, string make, string model, int year, VehicleClass vehicleClass, decimal dailyRate)
        {
            VIN = vin;
            LicensePlate = licensePlate;
            Make = make;
            Model = model;
            Year = year;
            Class = vehicleClass;
            DailyRate = dailyRate;
        }

        public void SendToMaintenance(string description, decimal cost, MaintenanceType type)
        {
            if (Status == VehicleStatus.Rented)
            {
                throw new InvalidOperationException("Cannot send a rented vehicle to maintenance.");
            }

            var record = new MaintenanceRecord(Id, DateTime.Now, description, cost, type);
            MaintenanceHistory.Add(record);
            Status = VehicleStatus.InMaintenance;
        }

        public void ReturnFromMaintenance()
        {
            if (Status != VehicleStatus.InMaintenance)
            {
                throw new InvalidOperationException("Vehicle is not in maintenance.");
            }

            Status = VehicleStatus.Available;
        }

        public void ToggleAvailability()
        {
            if (Status == VehicleStatus.Available)
            {
                Status = VehicleStatus.Unavailable;
            }
            else if (Status == VehicleStatus.Unavailable)
            {
                Status = VehicleStatus.Available;
            }
            else
            {
                throw new InvalidOperationException($"Cannot toggle availability while vehicle is {Status}.");
            }
        }

        public RentalAgreement StartRental(Customer customer, DateTime expectedReturnDate, int startingMileage, DateTime? pickupDate = null)
        {
            if (Status != VehicleStatus.Available)
            {
                throw new InvalidOperationException("Vehicle is not available for rent.");
            }

            var actualPickup = pickupDate ?? DateTime.Now;
            var agreementNumber = $"RA-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
            var agreement = new RentalAgreement(agreementNumber, actualPickup, expectedReturnDate, startingMileage, customer.Id, Id);

            Status = VehicleStatus.Rented;
            return agreement;
        }

        public void CompleteRental(RentalAgreement agreement, int endingMileage)
        {
            if (Status != VehicleStatus.Rented)
            {
                throw new InvalidOperationException("Vehicle is not currently rented.");
            }

            agreement.Complete(endingMileage, DailyRate);
            Status = VehicleStatus.Available;
        }
    }
}