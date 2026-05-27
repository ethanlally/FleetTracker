using System;
using System.Collections.Generic;
using System.Linq;
using FleetTracker.Services.Core.Models;
using FleetTracker.Services.Core.Interfaces;

namespace FleetTracker.Services.Core.Repositories
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

        public Customer GetCustomerById(Guid id) => _customers.FirstOrDefault(c => c.Id == id);
        public Customer GetCustomerByLicense(string license) => _customers.FirstOrDefault(c => string.Equals(c.DriversLicense, license, StringComparison.OrdinalIgnoreCase));

        public Vehicle GetVehicleById(Guid id) => _vehicles.FirstOrDefault(v => v.Id == id);
        public Vehicle GetVehicleByVin(string vin) => _vehicles.FirstOrDefault(v => string.Equals(v.VIN, vin, StringComparison.OrdinalIgnoreCase));

        public RentalAgreement GetRentalById(Guid id) => _rentals.FirstOrDefault(r => r.Id == id);

        public void UpdateCustomer(Customer customer)
        {
            var existing = GetCustomerById(customer.Id);
            if (existing == null) throw new InvalidOperationException("Customer not found.");
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            var existing = GetVehicleById(vehicle.Id);
            if (existing == null) throw new InvalidOperationException("Vehicle not found.");
        }

        public void UpdateRental(RentalAgreement agreement)
        {
            var existing = GetRentalById(agreement.Id);
            if (existing == null) throw new InvalidOperationException("Rental not found.");
        }
    }
}
