using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;
using FleetTracker.Services.Api.DataModels;

namespace FleetTracker.Services.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentalsController : ControllerBase
    {
        private readonly IRentalRepository _rentalRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly ICustomerRepository _customerRepository;

        public RentalsController(IRentalRepository rentalRepository, IVehicleRepository vehicleRepository, ICustomerRepository customerRepository)
        {
            _rentalRepository = rentalRepository;
            _vehicleRepository = vehicleRepository;
            _customerRepository = customerRepository;
        }

        [HttpGet("active")]
        public IActionResult GetActiveRentals()
        {
            var rentals = _rentalRepository.GetAllRentals().Where(r => r.Status == RentalStatus.Active);
            return Ok(rentals);
        }

        [HttpGet]
        public IActionResult GetAllRentals()
        {
            var rentals = _rentalRepository.GetAllRentals();
            return Ok(rentals);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetRentalById(Guid id)
        {
            var rental = _rentalRepository.GetRentalById(id);
            if (rental == null) return NotFound();
            return Ok(rental);
        }

        [HttpPost("start")]
        public IActionResult StartRental([FromBody] StartRentalRequest request)
        {
            var customer = _customerRepository.GetCustomerById(request.CustomerId);
            if (customer == null) return BadRequest("Customer not found.");

            var vehicle = _vehicleRepository.GetVehicleByVin(request.VehicleVin);
            if (vehicle == null) return BadRequest("Vehicle not found.");

            try
            {
                var rental = vehicle.StartRental(customer, request.ExpectedReturnDate, request.StartingMileage, request.PickupDate);
                _rentalRepository.AddRental(rental);
                _vehicleRepository.UpdateVehicle(vehicle);
                _customerRepository.UpdateCustomer(customer);
                return CreatedAtAction(nameof(GetRentalById), new { id = rental.Id }, rental);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("{id:guid}/complete")]
        public IActionResult CompleteRental(Guid id, [FromBody] CompleteRentalRequest request)
        {
            var rental = _rentalRepository.GetRentalById(id);
            if (rental == null) return NotFound("Rental not found.");

            var vehicle = _vehicleRepository.GetVehicleById(rental.VehicleId);
            if (vehicle == null) return NotFound("Associated vehicle not found.");

            try
            {
                vehicle.CompleteRental(rental, request.EndingMileage);
                _rentalRepository.UpdateRental(rental);
                _vehicleRepository.UpdateVehicle(vehicle);
                return Ok(rental);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
