using System;
using System.Collections.Generic;
using System.Linq;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FleetTracker.Services.Data
{
    public class EfFleetRepository : ICustomerRepository, IVehicleRepository, IRentalRepository
    {
        private readonly FleetTrackerDbContext _context;

        public EfFleetRepository(FleetTrackerDbContext context)
        {
            _context = context;
        }

        // ICustomerRepository
        public Customer? GetCustomerById(Guid id)
        {
            return _context.Customers
                .Include(c => c.RentalHistory)
                .FirstOrDefault(c => c.Id == id);
        }

        public Customer? GetCustomerByLicense(string license)
        {
            return _context.Customers
                .Include(c => c.RentalHistory)
                .FirstOrDefault(c => c.DriversLicense == license);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers
                .Include(c => c.RentalHistory)
                .ToList();
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(Guid id)
        {
            var customer = GetCustomerById(id);
            if (customer != null)
            {
                if (customer.RentalHistory.Any(r => r.Status == RentalStatus.Active))
                {
                    throw new InvalidOperationException("Cannot delete customer with active rentals. Complete the rental first.");
                }
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        // IVehicleRepository
        public Vehicle? GetVehicleById(Guid id)
        {
            return _context.Vehicles
                .Include(v => v.RentalHistory)
                .Include(v => v.MaintenanceHistory)
                .FirstOrDefault(v => v.Id == id);
        }

        public Vehicle? GetVehicleByVin(string vin)
        {
            return _context.Vehicles
                .Include(v => v.RentalHistory)
                .Include(v => v.MaintenanceHistory)
                .FirstOrDefault(v => v.VIN == vin);
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            return _context.Vehicles
                .Include(v => v.RentalHistory)
                .Include(v => v.MaintenanceHistory)
                .ToList();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Update(vehicle);
            _context.SaveChanges();
        }

        public void SendVehicleToMaintenance(string vin, string description, decimal cost)
        {
            var vehicle = GetVehicleByVin(vin);
            if (vehicle != null)
            {
                vehicle.SendToMaintenance(description, cost, MaintenanceType.Repair);
                var newRecord = vehicle.MaintenanceHistory.Last();
                _context.Entry(newRecord).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void ReturnVehicleFromMaintenance(string vin)
        {
            var vehicle = GetVehicleByVin(vin);
            if (vehicle != null)
            {
                vehicle.ReturnFromMaintenance();
                _context.SaveChanges();
            }
        }

        public void ToggleVehicleAvailability(string vin)
        {
            var vehicle = GetVehicleByVin(vin);
            if (vehicle != null)
            {
                vehicle.ToggleAvailability();
                _context.SaveChanges();
            }
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
                _context.Vehicles.Remove(vehicle);
                _context.SaveChanges();
            }
        }

        // IRentalRepository
        public RentalAgreement? GetRentalById(Guid id)
        {
            return _context.RentalAgreements
                .Include(r => r.Customer)
                .Include(r => r.Vehicle)
                .FirstOrDefault(r => r.Id == id);
        }

        public RentalAgreement? GetRentalByAgreementNumber(string agreementNumber)
        {
            return _context.RentalAgreements
                .Include(r => r.Customer)
                .Include(r => r.Vehicle)
                .FirstOrDefault(r => r.AgreementNumber == agreementNumber);
        }

        public IEnumerable<RentalAgreement> GetAllRentals()
        {
            return _context.RentalAgreements
                .Include(r => r.Customer)
                .Include(r => r.Vehicle)
                .ToList();
        }

        public void AddRental(RentalAgreement rental)
        {
            _context.RentalAgreements.Add(rental);
            _context.SaveChanges();
        }

        public void UpdateRental(RentalAgreement rental)
        {
            _context.RentalAgreements.Update(rental);
            _context.SaveChanges();
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
                    _context.SaveChanges();
                }
            }
        }
    }
}
