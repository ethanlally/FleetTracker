using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;

namespace FleetTracker.Services.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehiclesController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpGet]
        public IActionResult GetAllVehicles()
        {
            var vehicles = _vehicleRepository.GetAllVehicles();
            return Ok(vehicles);
        }

        [HttpGet("available")]
        public IActionResult GetAvailableVehicles()
        {
            var vehicles = _vehicleRepository.GetAllVehicles().Where(v => v.Status == VehicleStatus.Available);
            return Ok(vehicles);
        }

        [HttpGet("{vin}")]
        public IActionResult GetVehicleByVin(string vin)
        {
            var vehicle = _vehicleRepository.GetVehicleByVin(vin);
            if (vehicle == null) return NotFound();
            return Ok(vehicle);
        }

        [HttpPost("{vin}/toggle")]
        public IActionResult ToggleVehicleAvailability(string vin)
        {
            var vehicle = _vehicleRepository.GetVehicleByVin(vin);
            if (vehicle == null) return NotFound("Vehicle not found.");

            try
            {
                vehicle.ToggleAvailability();
                _vehicleRepository.UpdateVehicle(vehicle);
                return Ok(new { message = $"Status changed to {vehicle.Status}", vehicle });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
