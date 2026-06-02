using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;
using FleetTracker.Services.Core.DataModels;

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
                _vehicleRepository.ToggleVehicleAvailability(vin);
                // We need to fetch the vehicle again to return the updated status, or just return OK.
                var updatedVehicle = _vehicleRepository.GetVehicleByVin(vin);
                return Ok(new { message = $"Status changed to {updatedVehicle?.Status}", vehicle = updatedVehicle });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{vin}")]
        public IActionResult UpdateVehicle(string vin, [FromBody] UpdateVehicleRequest request)
        {
            var vehicle = _vehicleRepository.GetVehicleByVin(vin);
            if (vehicle == null) return NotFound();

            vehicle.UpdateDetails(vin, request.LicensePlate, request.Make, request.Model, request.Year, (VehicleClass)request.Class, request.DailyRate);
            
            _vehicleRepository.UpdateVehicle(vehicle);

            return Ok(vehicle);
        }

        public class MaintenanceRequestDto
        {
            public string Description { get; set; }
            public decimal Cost { get; set; }
            public int Type { get; set; }
        }

        [HttpPost("{vin}/maintenance/start")]
        public IActionResult StartMaintenance(string vin, [FromBody] MaintenanceRequestDto request)
        {
            var vehicle = _vehicleRepository.GetVehicleByVin(vin);
            if (vehicle == null) return NotFound("Vehicle not found.");

            try
            {
                _vehicleRepository.SendVehicleToMaintenance(vin, request.Description, request.Cost);
                return Ok(new { message = "Vehicle sent to maintenance." });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("{vin}/maintenance/return")]
        public IActionResult ReturnMaintenance(string vin)
        {
            var vehicle = _vehicleRepository.GetVehicleByVin(vin);
            if (vehicle == null) return NotFound("Vehicle not found.");

            try
            {
                _vehicleRepository.ReturnVehicleFromMaintenance(vin);
                return Ok(new { message = "Vehicle returned from maintenance." });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
