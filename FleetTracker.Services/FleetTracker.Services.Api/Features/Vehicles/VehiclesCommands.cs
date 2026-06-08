using System;
using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Microsoft.AspNetCore.Http;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;
using FleetTracker.Services.Core.DataModels;

namespace FleetTracker.Services.Api.Features.Vehicles
{
    public record CreateVehicleCommand(CreateVehicleRequest Request) : IRequest<IResult>;
    public record ToggleVehicleAvailabilityCommand(string Vin) : IRequest<IResult>;
    public record UpdateVehicleCommand(string Vin, UpdateVehicleRequest Request) : IRequest<IResult>;
    public record StartMaintenanceCommand(string Vin, MaintenanceRequestDto Request) : IRequest<IResult>;
    public record ReturnMaintenanceCommand(string Vin) : IRequest<IResult>;
    public record DeleteVehicleCommand(Guid Id) : IRequest<IResult>;

    public class CreateVehicleHandler : IRequestHandler<CreateVehicleCommand, IResult>
    {
        private readonly IVehicleRepository _repository;
        public CreateVehicleHandler(IVehicleRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(CreateVehicleCommand command, CancellationToken cancellationToken)
        {
            var request = command.Request;
            var vehicle = new Vehicle(
                request.VehicleVin,
                request.LicensePlate,
                request.Make,
                request.Model,
                request.Year,
                (VehicleClass)request.Class,
                request.DailyRate
            );

            _repository.AddVehicle(vehicle);
            return new ValueTask<IResult>(Results.Ok(vehicle));
        }
    }

    public class ToggleVehicleAvailabilityHandler : IRequestHandler<ToggleVehicleAvailabilityCommand, IResult>
    {
        private readonly IVehicleRepository _repository;
        public ToggleVehicleAvailabilityHandler(IVehicleRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(ToggleVehicleAvailabilityCommand command, CancellationToken cancellationToken)
        {
            var vehicle = _repository.GetVehicleByVin(command.Vin);
            if (vehicle == null) return new ValueTask<IResult>(Results.NotFound("Vehicle not found."));

            try
            {
                _repository.ToggleVehicleAvailability(command.Vin);
                var updatedVehicle = _repository.GetVehicleByVin(command.Vin);
                return new ValueTask<IResult>(Results.Ok(new { message = $"Status changed to {updatedVehicle?.Status}", vehicle = updatedVehicle }));
            }
            catch (Exception ex)
            {
                return new ValueTask<IResult>(Results.BadRequest(ex.Message));
            }
        }
    }

    public class UpdateVehicleHandler : IRequestHandler<UpdateVehicleCommand, IResult>
    {
        private readonly IVehicleRepository _repository;
        public UpdateVehicleHandler(IVehicleRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(UpdateVehicleCommand command, CancellationToken cancellationToken)
        {
            var vehicle = _repository.GetVehicleByVin(command.Vin);
            if (vehicle == null) return new ValueTask<IResult>(Results.NotFound());

            var request = command.Request;
            vehicle.UpdateDetails(command.Vin, request.LicensePlate, request.Make, request.Model, request.Year, (VehicleClass)request.Class, request.DailyRate);

            _repository.UpdateVehicle(vehicle);
            return new ValueTask<IResult>(Results.Ok(vehicle));
        }
    }

    public class StartMaintenanceHandler : IRequestHandler<StartMaintenanceCommand, IResult>
    {
        private readonly IVehicleRepository _repository;
        public StartMaintenanceHandler(IVehicleRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(StartMaintenanceCommand command, CancellationToken cancellationToken)
        {
            var vehicle = _repository.GetVehicleByVin(command.Vin);
            if (vehicle == null) return new ValueTask<IResult>(Results.NotFound("Vehicle not found."));

            try
            {
                _repository.SendVehicleToMaintenance(command.Vin, command.Request.Description, command.Request.Cost, (MaintenanceType)command.Request.Type);
                return new ValueTask<IResult>(Results.Ok(new { message = "Vehicle sent to maintenance." }));
            }
            catch (Exception ex)
            {
                return new ValueTask<IResult>(Results.BadRequest(ex.Message));
            }
        }
    }

    public class ReturnMaintenanceHandler : IRequestHandler<ReturnMaintenanceCommand, IResult>
    {
        private readonly IVehicleRepository _repository;
        public ReturnMaintenanceHandler(IVehicleRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(ReturnMaintenanceCommand command, CancellationToken cancellationToken)
        {
            var vehicle = _repository.GetVehicleByVin(command.Vin);
            if (vehicle == null) return new ValueTask<IResult>(Results.NotFound("Vehicle not found."));

            try
            {
                _repository.ReturnVehicleFromMaintenance(command.Vin);
                return new ValueTask<IResult>(Results.Ok(new { message = "Vehicle returned from maintenance." }));
            }
            catch (Exception ex)
            {
                return new ValueTask<IResult>(Results.BadRequest(ex.Message));
            }
        }
    }

    public class DeleteVehicleHandler : IRequestHandler<DeleteVehicleCommand, IResult>
    {
        private readonly IVehicleRepository _repository;
        public DeleteVehicleHandler(IVehicleRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(DeleteVehicleCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var vehicle = _repository.GetVehicleById(command.Id);
                if (vehicle == null) return new ValueTask<IResult>(Results.NotFound());

                _repository.DeleteVehicle(command.Id);
                return new ValueTask<IResult>(Results.NoContent());
            }
            catch (InvalidOperationException ex)
            {
                return new ValueTask<IResult>(Results.BadRequest(ex.Message));
            }
        }
    }
}
