using System;
using System.Linq;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;

using FleetTracker.Services.Application.Interfaces;

namespace FleetTracker.Services.Application.Managers
{
    public class VehicleManager
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IConsoleService _console;

        public VehicleManager(IVehicleRepository vehicleRepository, ICustomerRepository customerRepository, IConsoleService console)
        {
            _vehicleRepository = vehicleRepository;
            _customerRepository = customerRepository;
            _console = console;
        }

        public void ManageVehicles()
        {
            bool back = false;
            while (!back)
            {
                _console.WriteLine();
                _console.WriteLine("******Vehicle Management******");
                _console.WriteLine("1. Create Vehicle");
                _console.WriteLine("2. List Available Vehicles");
                _console.WriteLine("3. List Vehicles In Maintenance");
                _console.WriteLine("4. Change Vehicle Status (Maintenance / Availability)");
                _console.WriteLine("5. List All Vehicles");
                _console.WriteLine("6. View Vehicle Rental History");
                _console.WriteLine("7. Edit Vehicle Information");
                _console.WriteLine("8. Go Back to Main Menu");

                string choice = _console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1": CreateVehicle(); break;
                        case "2": ListAvailableVehicles(); break;
                        case "3": ListVehiclesInMaintenance(); break;
                        case "4": ChangeVehicleStatus(); break;
                        case "5": ListAllVehicles(); break;
                        case "6": ViewVehicleRentalHistory(); break;
                        case "7": EditVehicle(); break;
                        case "8": back = true; break;
                        default: _console.WriteLine("Invalid Selection!"); break;
                    }
                }
                catch (Exception e)
                {
                    _console.WriteLine($"Error: {e.Message}");
                }
            }
        }

        private void CreateVehicle()
        {
            string vin = GetUniqueVin();

            string license = _console.PromptForInput("Enter License Plate: ");
            string make = _console.PromptForInput("Enter Make: ");
            string model = _console.PromptForInput("Enter Model: ");
            int year = _console.PromptForInt("Enter Year: ");
            decimal rate = _console.PromptForDecimal("Enter Daily Rate: ");

            var vehicle = new Vehicle(vin, license, make, model, year, VehicleClass.Sedan, rate);
            _vehicleRepository.AddVehicle(vehicle);

            _console.WriteLine("Vehicle created successfully.");
        }

        private string GetUniqueVin()
        {
            string vin = _console.PromptForInput("Enter VIN (7 characters): ");

            while (vin.Length != 7 || _vehicleRepository.GetVehicleByVin(vin) != null)
            {
                if (vin.Length != 7)
                {
                    vin = _console.PromptForInput("VIN must be exactly 7 characters. Try again: ");
                }
                else
                {
                    vin = _console.PromptForInput("A vehicle with this VIN already exists. Try another: ");
                }
            }

            return vin;
        }

        private void ListAvailableVehicles()
        {
            var vehicles = _vehicleRepository.GetAllVehicles().Where(v => v.Status == VehicleStatus.Available);
            if (!vehicles.Any())
            {
                _console.WriteLine("No available vehicles found.");
                return;
            }

            foreach (var v in vehicles)
            {
                _console.WriteLine("--------------------------------------------------");
                _console.WriteLine($"[{v.VIN}] {v.Year} {v.Make} {v.Model}");
                _console.WriteLine($"License: {v.LicensePlate} | Rate: ${v.DailyRate}/day");
            }
            _console.WriteLine("--------------------------------------------------");
        }

        private void ListVehiclesInMaintenance()
        {
            var vehicles = _vehicleRepository.GetAllVehicles().Where(v => v.Status == VehicleStatus.InMaintenance);
            if (!vehicles.Any())
            {
                _console.WriteLine("No vehicles currently in maintenance.");
                return;
            }

            foreach (var v in vehicles)
            {
                var record = v.MaintenanceHistory.LastOrDefault();
                string reason = record != null ? record.Description : "Unknown";
                string cost = record != null ? $"${record.Cost}" : "Unknown";
                
                _console.WriteLine("--------------------------------------------------");
                _console.WriteLine($"[{v.VIN}] {v.Year} {v.Make} {v.Model}");
                _console.WriteLine($"Reason: {reason}");
                _console.WriteLine($"Est. Cost: {cost}");
            }
            _console.WriteLine("--------------------------------------------------");
        }

        private void ListAllVehicles()
        {
            var vehicles = _vehicleRepository.GetAllVehicles();
            if (!vehicles.Any())
            {
                _console.WriteLine("No vehicles found.");
                return;
            }

            foreach (var v in vehicles)
            {
                _console.WriteLine("--------------------------------------------------");
                _console.WriteLine($"[{v.VIN}] {v.Year} {v.Make} {v.Model}");
                _console.WriteLine($"Status: {v.Status} | Class: {v.Class}");
            }
            _console.WriteLine("--------------------------------------------------");
        }

        private void ViewVehicleRentalHistory()
        {
            _console.WriteLine("All Vehicles:");
            foreach (var v in _vehicleRepository.GetAllVehicles())
            {
                _console.WriteLine($"  [{v.VIN}] {v.Year} {v.Make} {v.Model}");
            }
            _console.WriteLine();

            string vin = _console.PromptForInput("Enter VIN (7 characters): ");

            var vehicle = _vehicleRepository.GetVehicleByVin(vin);
            while (vehicle == null)
            {
                vin = _console.PromptForInput("Vehicle not found. Try another VIN or type 'CANCEL' to go back: ");
                if (vin.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
                vehicle = _vehicleRepository.GetVehicleByVin(vin);
            }

            PrintVehicleDetails(vehicle);
        }

        private void PrintVehicleDetails(Vehicle vehicle)
        {
            _console.WriteLine("------------------------------------------------");
            _console.WriteLine($"ID (Guid): {vehicle.Id}");
            _console.WriteLine($"[{vehicle.VIN}] {vehicle.Year} {vehicle.Make} {vehicle.Model}");
            _console.WriteLine($"License Plate: {vehicle.LicensePlate} | Class: {vehicle.Class}");
            _console.WriteLine($"Daily Rate: ${vehicle.DailyRate} | Status: {vehicle.Status}");
            
            if (vehicle.RentalHistory.Count == 0)
            {
                _console.WriteLine("Total Rentals: 0");
            }
            else
            {
                _console.WriteLine($"Total Rentals: {vehicle.RentalHistory.Count}");
                _console.WriteLine("Rental History:");
                foreach(var rh in vehicle.RentalHistory)
                {
                    var customer = _customerRepository.GetCustomerById(rh.CustomerId);
                    string cInfo = customer != null ? $"{customer.Contact.Name} (DL: {customer.DriversLicense})" : "Unknown Customer";
                    _console.WriteLine($"  - Rented By: {cInfo}");
                    _console.WriteLine($"    Dates: {rh.PickupDate.ToShortDateString()} - {rh.ExpectedReturnDate.ToShortDateString()} | Status: {rh.Status}");
                }
            }
            _console.WriteLine("------------------------------------------------");
        }

        private void ChangeVehicleStatus()
        {
            _console.WriteLine();
            _console.WriteLine("--- Change Vehicle Status ---");
            _console.WriteLine("1. Send Vehicle to Maintenance");
            _console.WriteLine("2. Return Vehicle from Maintenance");
            _console.WriteLine("3. Toggle General Availability (Available <-> Unavailable)");
            _console.WriteLine("4. Cancel");
            
            string choice = _console.ReadLine();
            switch(choice)
            {
                case "1": SendToMaintenance(); break;
                case "2": ReturnFromMaintenance(); break;
                case "3": ToggleVehicleAvailability(); break;
                case "4": break;
                default: _console.WriteLine("Invalid Selection!"); break;
            }
        }

        private void ToggleVehicleAvailability()
        {
            _console.WriteLine();
            _console.WriteLine("Vehicles that are Available or Unavailable:");
            // filtering the list to only include vehicles that can actually be toggled
            var eligibleVehicles = _vehicleRepository.GetAllVehicles().Where(v => v.Status == VehicleStatus.Available || v.Status == VehicleStatus.Unavailable);
            
            if (!eligibleVehicles.Any())
            {
                _console.WriteLine("No eligible vehicles found.");
                return;
            }

            foreach (var v in eligibleVehicles)
            {
                _console.WriteLine("--------------------------------------------------");
                _console.WriteLine($"[{v.VIN}] {v.Year} {v.Make} {v.Model} (Status: {v.Status})");
            }
            _console.WriteLine("--------------------------------------------------");
            _console.WriteLine();

            string vin = _console.PromptForInput("Enter VIN of vehicle to toggle availability: ");

            var vehicle = _vehicleRepository.GetVehicleByVin(vin);
            while (vehicle == null || (vehicle.Status != VehicleStatus.Available && vehicle.Status != VehicleStatus.Unavailable))
            {
                if (vehicle == null)
                    vin = _console.PromptForInput("Vehicle not found. Try another VIN or type 'CANCEL' to go back: ");
                else
                    vin = _console.PromptForInput($"Vehicle is {vehicle.Status} and cannot be toggled. Try another VIN or type 'CANCEL' to go back: ");
                    
                if (vin.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
                vehicle = _vehicleRepository.GetVehicleByVin(vin);
            }

            try
            {
                vehicle.ToggleAvailability();
                _console.WriteLine($"Vehicle status successfully toggled to: {vehicle.Status}");
            }
            catch (Exception ex)
            {
                _console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void SendToMaintenance()
        {
            _console.WriteLine();
            _console.WriteLine("Vehicles not in maintenance:");
            var availableForMaint = _vehicleRepository.GetAllVehicles().Where(v => v.Status != VehicleStatus.InMaintenance);
            if (!availableForMaint.Any())
            {
                _console.WriteLine("No vehicles available to send to maintenance.");
                return;
            }

            foreach (var v in availableForMaint)
            {
                _console.WriteLine("--------------------------------------------------");
                _console.WriteLine($"[{v.VIN}] {v.Year} {v.Make} {v.Model} (Status: {v.Status})");
            }
            _console.WriteLine("--------------------------------------------------");
            _console.WriteLine();

            string vin = _console.PromptForInput("Enter VIN of vehicle to send to maintenance: ");

            var vehicle = _vehicleRepository.GetVehicleByVin(vin);
            while (vehicle == null || vehicle.Status == VehicleStatus.InMaintenance)
            {
                if (vehicle == null)
                    vin = _console.PromptForInput("Vehicle not found. Try another VIN or type 'CANCEL' to go back: ");
                else
                    vin = _console.PromptForInput("Vehicle is already in maintenance. Try another VIN or type 'CANCEL' to go back: ");
                    
                if (vin.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
                vehicle = _vehicleRepository.GetVehicleByVin(vin);
            }

            string description = _console.PromptForInput("Enter Maintenance Description: ");
            decimal cost = _console.PromptForDecimal("Enter Estimated Cost: ");

            vehicle.SendToMaintenance(description, cost, MaintenanceType.Repair);
            
            _console.WriteLine("Vehicle sent to maintenance successfully.");
        }

        private void ReturnFromMaintenance()
        {
            _console.WriteLine();
            _console.WriteLine("Vehicles currently in maintenance:");
            var inMaintenance = _vehicleRepository.GetAllVehicles().Where(v => v.Status == VehicleStatus.InMaintenance);
            
            if (!inMaintenance.Any())
            {
                _console.WriteLine("No vehicles are currently in maintenance.");
                return;
            }

            foreach (var v in inMaintenance)
            {
                _console.WriteLine("--------------------------------------------------");
                _console.WriteLine($"[{v.VIN}] {v.Year} {v.Make} {v.Model}");
            }
            _console.WriteLine("--------------------------------------------------");
            _console.WriteLine();

            string vin = _console.PromptForInput("Enter VIN of vehicle to return from maintenance: ");

            var vehicle = _vehicleRepository.GetVehicleByVin(vin);
            while (vehicle == null || vehicle.Status != VehicleStatus.InMaintenance)
            {
                if (vehicle == null)
                    vin = _console.PromptForInput("Vehicle not found. Try another VIN or type 'CANCEL' to go back: ");
                else
                    vin = _console.PromptForInput("Vehicle is not in maintenance. Try another VIN or type 'CANCEL' to go back: ");
                    
                if (vin.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
                vehicle = _vehicleRepository.GetVehicleByVin(vin);
            }

            vehicle.ReturnFromMaintenance();
            _console.WriteLine("Vehicle returned from maintenance and is now Available.");
        }

        private void EditVehicle()
        {
            _console.WriteLine("All Vehicles:");
            foreach (var v in _vehicleRepository.GetAllVehicles())
            {
                _console.WriteLine($"  [{v.VIN}] {v.Year} {v.Make} {v.Model}");
            }
            _console.WriteLine();

            string vin = _console.PromptForInput("Enter VIN (7 characters) to edit: ");
            var vehicle = _vehicleRepository.GetVehicleByVin(vin);
            while (vehicle == null)
            {
                vin = _console.PromptForInput("Vehicle not found. Try another VIN or type 'CANCEL' to go back: ");
                if (vin.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
                vehicle = _vehicleRepository.GetVehicleByVin(vin);
            }

            _console.WriteLine("Enter new values or press Enter to keep current values.");
            
            string newVin = _console.PromptForOptionalInput($"VIN ({vehicle.VIN}): ", vehicle.VIN);
            if (newVin != vehicle.VIN)
            {
                while (newVin.Length != 7 || _vehicleRepository.GetVehicleByVin(newVin) != null)
                {
                    if (newVin.Length != 7)
                    {
                        newVin = _console.PromptForOptionalInput($"VIN must be exactly 7 characters. Try again ({vehicle.VIN}): ", vehicle.VIN);
                    }
                    else
                    {
                        newVin = _console.PromptForOptionalInput($"VIN {newVin} is already taken. Try another or press Enter to keep ({vehicle.VIN}): ", vehicle.VIN);
                    }
                }
            }

            string newLicense = _console.PromptForOptionalInput($"License Plate ({vehicle.LicensePlate}): ", vehicle.LicensePlate);
            string newMake = _console.PromptForOptionalInput($"Make ({vehicle.Make}): ", vehicle.Make);
            string newModel = _console.PromptForOptionalInput($"Model ({vehicle.Model}): ", vehicle.Model);
            int newYear = _console.PromptForOptionalInt($"Year ({vehicle.Year}): ", vehicle.Year);
            decimal newRate = _console.PromptForOptionalDecimal($"Daily Rate ({vehicle.DailyRate}): ", vehicle.DailyRate);

            vehicle.UpdateDetails(newVin, newLicense, newMake, newModel, newYear, vehicle.Class, newRate);
            _vehicleRepository.UpdateVehicle(vehicle);

            _console.WriteLine();
            _console.WriteLine("Vehicle updated successfully. New Details:");
            PrintVehicleDetails(vehicle);
        }
    }
}
