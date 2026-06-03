using System;
using System.Collections.Generic;
using System.Linq;
using FleetTracker.Services.Core.Models;
using FleetTracker.Services.Core.Interfaces;

namespace FleetTracker.Services.Data.Repositories
{
    public class InMemoryFleetRepository : ICustomerRepository, IVehicleRepository, IRentalRepository
    {
        private readonly List<Customer> _customers = new List<Customer>();
        private readonly List<Vehicle> _vehicles = new List<Vehicle>();
        private readonly List<RentalAgreement> _rentals = new List<RentalAgreement>();

        public void AddCustomer(Customer customer) => _customers.Add(customer);
        public void AddVehicle(Vehicle vehicle) => _vehicles.Add(vehicle);
        public void AddRental(RentalAgreement rental) => _rentals.Add(rental);

        public IEnumerable<Customer> GetAllCustomers() => _customers;
        public IEnumerable<Vehicle> GetAllVehicles() => _vehicles;
        public IEnumerable<RentalAgreement> GetAllRentals() => _rentals;

        public Customer? GetCustomerById(Guid id) => _customers.FirstOrDefault(c => c.Id == id);
        public Customer? GetCustomerByLicense(string license) => _customers.FirstOrDefault(c => string.Equals(c.DriversLicense, license, StringComparison.OrdinalIgnoreCase));

        public Vehicle? GetVehicleById(Guid id) => _vehicles.FirstOrDefault(v => v.Id == id);
        public Vehicle? GetVehicleByVin(string vin) => _vehicles.FirstOrDefault(v => string.Equals(v.VIN, vin, StringComparison.OrdinalIgnoreCase));

        public RentalAgreement? GetRentalById(Guid id) => _rentals.FirstOrDefault(r => r.Id == id);
        public RentalAgreement? GetRentalByAgreementNumber(string agreementNumber) => _rentals.FirstOrDefault(r => string.Equals(r.AgreementNumber, agreementNumber, StringComparison.OrdinalIgnoreCase));

        public void UpdateCustomer(Customer customer)
        {
            var existing = GetCustomerById(customer.Id);
            if (existing != null)
            {
                _customers.Remove(existing);
                _customers.Add(customer);
            }
        }

        public void DeleteCustomer(Guid id)
        {
            var customer = GetCustomerById(id);
            if (customer != null)
            {
                if (_rentals.Any(r => r.CustomerId == id && r.Status == RentalStatus.Active))
                {
                    throw new InvalidOperationException("Cannot delete customer with active rentals. Complete the rental first.");
                }
                _customers.Remove(customer);
            }
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            var index = _vehicles.FindIndex(v => v.VIN == vehicle.VIN);
            if (index != -1) _vehicles[index] = vehicle;
        }

        public void SendVehicleToMaintenance(string vin, string description, decimal cost, MaintenanceType type)
        {
            var vehicle = GetVehicleByVin(vin);
            vehicle?.SendToMaintenance(description, cost, type);
        }

        public void ReturnVehicleFromMaintenance(string vin)
        {
            var vehicle = GetVehicleByVin(vin);
            vehicle?.ReturnFromMaintenance();
        }

        public void ToggleVehicleAvailability(string vin)
        {
            var vehicle = GetVehicleByVin(vin);
            vehicle?.ToggleAvailability();
        }

        public void DeleteVehicle(Guid id)
        {
            var vehicle = GetVehicleById(id);
            if (vehicle != null)
            {
                if (vehicle.Status != VehicleStatus.Available && vehicle.Status != VehicleStatus.Unavailable)
                {
                    throw new InvalidOperationException($"Cannot delete vehicle in status: {vehicle.Status}. Ensure the vehicle is Available or Unavailable first.");
                }
                _vehicles.Remove(vehicle);
            }
        }

        public void UpdateRental(RentalAgreement rental)
        {
            var index = _rentals.FindIndex(r => r.Id == rental.Id);
            if (index != -1) _rentals[index] = rental;
        }

        public IEnumerable<RentalAgreement> GetRentalsByCustomerId(Guid customerId)
        {
            return _rentals.Where(r => r.CustomerId == customerId).ToList();
        }

        public IEnumerable<RentalAgreement> GetRentalsByVehicleId(Guid vehicleId)
        {
            return _rentals.Where(r => r.VehicleId == vehicleId).ToList();
        }

        public void CompleteRental(Guid id, int endingMileage)
        {
            var rental = GetRentalById(id);
            if (rental != null)
            {
                var vehicle = GetVehicleById(rental.VehicleId.GetValueOrDefault());
                if (vehicle != null)
                {
                    vehicle.CompleteRental(rental, endingMileage);
                }
            }
        }
    }
}