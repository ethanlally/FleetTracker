using System;
using System.Linq;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;

using FleetTracker.Services.Application.Interfaces;

namespace FleetTracker.Services.Application.Managers
{
    public class RentalManager
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IRentalRepository _rentalRepository;
        private readonly IConsoleService _console;

        public RentalManager(ICustomerRepository customerRepository, IVehicleRepository vehicleRepository, IRentalRepository rentalRepository, IConsoleService console)
        {
            _customerRepository = customerRepository;
            _vehicleRepository = vehicleRepository;
            _rentalRepository = rentalRepository;
            _console = console;
        }

        public void ManageRentals()
        {
            bool back = false;
            while (!back)
            {
                _console.WriteLine();
                _console.WriteLine("******Rental Operations******");
                _console.WriteLine("1. Start New Rental");
                _console.WriteLine("2. Complete Rental");
                _console.WriteLine("3. View Active Rentals");
                _console.WriteLine("4. Edit Rental Information");
                _console.WriteLine("5. Go Back to Main Menu");

                string choice = _console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1": StartRental(); break;
                        case "2": CompleteRental(); break;
                        case "3": ViewActiveRentals(); break;
                        case "4": EditRental(); break;
                        case "5": back = true; break;
                        default: _console.WriteLine("Invalid Selection!"); break;
                    }
                }
                catch (Exception e)
                {
                    _console.WriteLine($"Error: {e.Message}");
                }
            }
        }

        private void StartRental()
        {
            _console.WriteLine("All Customers:");
            foreach (var c in _customerRepository.GetAllCustomers())
            {
                _console.WriteLine($"  [{c.DriversLicense}] {c.Contact.Name}");
            }
            _console.WriteLine();

            string license = _console.PromptForInput("Enter Customer Driver's License: ");

            var customer = _customerRepository.GetCustomerByLicense(license);
            while (customer == null)
            {
                license = _console.PromptForInput("Customer not found. Try another license or type 'CANCEL' to go back: ");
                if (license.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
                customer = _customerRepository.GetCustomerByLicense(license);
            }

            _console.WriteLine();
            _console.WriteLine("Available Vehicles:");
            var availableVehicles = _vehicleRepository.GetAllVehicles().Where(v => v.Status == VehicleStatus.Available);

            if (!availableVehicles.Any())
            {
                _console.WriteLine("No vehicles available for rent.");
                return;
            }

            foreach (var v in availableVehicles)
            {
                _console.WriteLine($"  [{v.VIN}] {v.Year} {v.Make} {v.Model} - ${v.DailyRate}/day");
            }
            _console.WriteLine();

            string vin = _console.PromptForInput("Enter VIN of vehicle to rent (7 characters): ");

            var vehicle = _vehicleRepository.GetVehicleByVin(vin);
            while (vehicle == null || vehicle.Status != VehicleStatus.Available)
            {
                if (vehicle == null)
                    vin = _console.PromptForInput("Vehicle not found. Try another VIN or type 'CANCEL' to go back: ");
                else
                    vin = _console.PromptForInput("Vehicle is not available. Try another VIN or type 'CANCEL' to go back: ");

                if (vin.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
                vehicle = _vehicleRepository.GetVehicleByVin(vin);
            }

            DateTime expectedReturn = _console.PromptForDate("Enter Expected Return Date (yyyy-mm-dd): ");
            while (expectedReturn < DateTime.Now.Date)
            {
                _console.WriteLine("Expected return date cannot be in the past.");
                expectedReturn = _console.PromptForDate("Enter Expected Return Date (yyyy-mm-dd): ");
            }

            int startingMileage = _console.PromptForInt("Enter Starting Mileage: ");

            var rental = vehicle.StartRental(customer, expectedReturn, startingMileage);
            _rentalRepository.AddRental(rental);

            _console.WriteLine($"Rental Agreement {rental.AgreementNumber} created successfully.");
        }

        private void CompleteRental()
        {
            _console.WriteLine();
            _console.WriteLine("Active Rentals:");
            var activeRentals = _rentalRepository.GetAllRentals().Where(r => r.Status == RentalStatus.Active);

            if (!activeRentals.Any())
            {
                _console.WriteLine("No active rentals found.");
                return;
            }

            foreach (var r in activeRentals)
            {
                var v = _vehicleRepository.GetVehicleById(r.VehicleId.GetValueOrDefault());
                var c = _customerRepository.GetCustomerById(r.CustomerId.GetValueOrDefault());
                string vInfo = v != null ? $"[{v.VIN}] {v.Make} {v.Model}" : "[Unknown Vehicle]";
                string cInfo = c != null ? $"[{c.DriversLicense}] {c.Contact.Name}" : "[Unknown Customer]";

                _console.WriteLine("--------------------------------------------------");
                _console.WriteLine($"Agreement: {r.AgreementNumber}");
                _console.WriteLine($"Vehicle: {vInfo}");
                _console.WriteLine($"Customer: {cInfo}");
            }
            _console.WriteLine("--------------------------------------------------");
            _console.WriteLine();

            string agreementNum = _console.PromptForInput("Enter Agreement Number to complete: ");

            var rental = _rentalRepository.GetAllRentals().FirstOrDefault(r => string.Equals(r.AgreementNumber, agreementNum, StringComparison.OrdinalIgnoreCase));

            while (rental == null || rental.Status != RentalStatus.Active)
            {
                if (rental == null)
                    agreementNum = _console.PromptForInput("Agreement not found. Try another or type 'CANCEL' to go back: ");
                else
                    agreementNum = _console.PromptForInput("Agreement is not active. Try another or type 'CANCEL' to go back: ");

                if (agreementNum.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
                rental = _rentalRepository.GetAllRentals().FirstOrDefault(r => string.Equals(r.AgreementNumber, agreementNum, StringComparison.OrdinalIgnoreCase));
            }

            var vehicle = _vehicleRepository.GetVehicleById(rental.VehicleId.GetValueOrDefault());

            int endingMileage = _console.PromptForInt("Enter Ending Mileage: ");

            _rentalRepository.CompleteRental(rental.Id, endingMileage);

            // Fetch the updated rental to get the total cost
            var updatedRental = _rentalRepository.GetRentalById(rental.Id);

            _console.WriteLine($"Rental completed successfully. Total Cost: ${updatedRental?.TotalCost}");
        }

        private void ViewActiveRentals()
        {
            var activeRentals = _rentalRepository.GetAllRentals().Where(r => r.Status == RentalStatus.Active);
            if (!activeRentals.Any())
            {
                _console.WriteLine("No active rentals found.");
                return;
            }

            foreach (var r in activeRentals)
            {
                PrintRentalDetails(r);
            }
            _console.WriteLine("--------------------------------------------------");
        }

        private void PrintRentalDetails(RentalAgreement r)
        {
            var vehicle = _vehicleRepository.GetVehicleById(r.VehicleId.GetValueOrDefault());
            var customer = _customerRepository.GetCustomerById(r.CustomerId.GetValueOrDefault());
            string vInfo = vehicle != null ? $"[{vehicle.VIN}] {vehicle.Make} {vehicle.Model}" : "Unknown Vehicle";
            string cInfo = customer != null ? $"[{customer.DriversLicense}] {customer.Contact.Name}" : "Unknown Customer";

            _console.WriteLine("--------------------------------------------------");
            _console.WriteLine($"ID (Guid): {r.Id}");
            _console.WriteLine($"Agreement: {r.AgreementNumber} | Status: {r.Status}");
            _console.WriteLine($"Pickup: {r.PickupDate.ToShortDateString()} | Expected Return: {r.ExpectedReturnDate.ToShortDateString()}");
            if (r.Status == RentalStatus.Completed)
            {
                _console.WriteLine($"Actual Return: {r.ActualReturnDate?.ToShortDateString()} | Total Cost: ${r.TotalCost}");
                _console.WriteLine($"Starting Mileage: {r.StartingMileage} | Ending Mileage: {r.EndingMileage}");
            }
            else
            {
                _console.WriteLine($"Starting Mileage: {r.StartingMileage}");
            }
            _console.WriteLine($"Vehicle ID (Guid): {r.VehicleId}");
            _console.WriteLine($"Vehicle Info: {vInfo}");
            _console.WriteLine($"Customer ID (Guid): {r.CustomerId}");
            _console.WriteLine($"Customer Info: {cInfo}");
        }

        private void EditRental()
        {
            _console.WriteLine("All Rentals:");
            foreach (var r in _rentalRepository.GetAllRentals())
            {
                var v = _vehicleRepository.GetVehicleById(r.VehicleId.GetValueOrDefault());
                var c = _customerRepository.GetCustomerById(r.CustomerId.GetValueOrDefault());
                string vInfo = v != null ? $"[{v.VIN}] {v.Make}" : "[Unknown Vehicle]";
                string cInfo = c != null ? $"[{c.DriversLicense}] {c.Contact.Name}" : "[Unknown Customer]";
                _console.WriteLine($"  [{r.AgreementNumber}] {vInfo} to {cInfo} (Status: {r.Status})");
            }
            _console.WriteLine();

            string agreementNum = _console.PromptForInput("Enter Agreement Number to edit: ");
            var rental = _rentalRepository.GetAllRentals().FirstOrDefault(r => string.Equals(r.AgreementNumber, agreementNum, StringComparison.OrdinalIgnoreCase));

            while (rental == null)
            {
                agreementNum = _console.PromptForInput("Agreement not found. Try another or type 'CANCEL' to go back: ");
                if (agreementNum.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
                rental = _rentalRepository.GetAllRentals().FirstOrDefault(r => string.Equals(r.AgreementNumber, agreementNum, StringComparison.OrdinalIgnoreCase));
            }

            _console.WriteLine("Enter new values or press Enter to keep current values.");

            if (rental.Status == RentalStatus.Active)
            {
                DateTime newExpectedReturn = _console.PromptForOptionalDate($"Expected Return Date ({rental.ExpectedReturnDate:yyyy-MM-dd}): ", rental.ExpectedReturnDate);
                while (newExpectedReturn < rental.PickupDate)
                {
                    _console.WriteLine("Expected return date cannot be before pickup date.");
                    newExpectedReturn = _console.PromptForOptionalDate($"Expected Return Date ({rental.ExpectedReturnDate:yyyy-MM-dd}): ", rental.ExpectedReturnDate);
                }

                int newStartMileage = _console.PromptForOptionalInt($"Starting Mileage ({rental.StartingMileage}): ", rental.StartingMileage);

                rental.UpdateActiveDetails(newExpectedReturn, newStartMileage);
            }
            else if (rental.Status == RentalStatus.Completed)
            {
                DateTime newActualReturn = _console.PromptForOptionalDate($"Actual Return Date ({rental.ActualReturnDate:yyyy-MM-dd}): ", rental.ActualReturnDate.GetValueOrDefault(DateTime.Now));
                while (newActualReturn < rental.PickupDate)
                {
                    _console.WriteLine("Actual return date cannot be before pickup date.");
                    newActualReturn = _console.PromptForOptionalDate($"Actual Return Date ({rental.ActualReturnDate:yyyy-MM-dd}): ", rental.ActualReturnDate.GetValueOrDefault(DateTime.Now));
                }

                int newEndMileage = _console.PromptForOptionalInt($"Ending Mileage ({rental.EndingMileage}): ", rental.EndingMileage.GetValueOrDefault());
                while (newEndMileage < rental.StartingMileage)
                {
                    _console.WriteLine("Ending mileage cannot be less than starting mileage.");
                    newEndMileage = _console.PromptForOptionalInt($"Ending Mileage ({rental.EndingMileage}): ", rental.EndingMileage.GetValueOrDefault());
                }

                decimal newTotalCost = _console.PromptForOptionalDecimal($"Total Cost ({rental.TotalCost}): ", rental.TotalCost.GetValueOrDefault());

                rental.UpdateCompletedDetails(newActualReturn, newEndMileage, newTotalCost);
            }
            else
            {
                _console.WriteLine("Cannot edit cancelled rentals.");
                return;
            }

            _rentalRepository.UpdateRental(rental);
            _console.WriteLine();
            _console.WriteLine("Rental updated successfully. New Details:");
            PrintRentalDetails(rental);
        }
    }
}