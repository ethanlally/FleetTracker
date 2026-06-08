using System;
using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Microsoft.AspNetCore.Http;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;
using FleetTracker.Services.Core.DataModels;

namespace FleetTracker.Services.Api.Features.Rentals
{
    public record StartRentalCommand(StartRentalRequest Request) : IRequest<IResult>;
    public record CompleteRentalCommand(Guid Id, CompleteRentalRequest Request) : IRequest<IResult>;
    public record UpdateRentalCommand(Guid Id, UpdateRentalRequest Request) : IRequest<IResult>;

    public class StartRentalHandler : IRequestHandler<StartRentalCommand, IResult>
    {
        private readonly IRentalRepository _rentalRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly ICustomerRepository _customerRepository;

        public StartRentalHandler(IRentalRepository rentalRepository, IVehicleRepository vehicleRepository, ICustomerRepository customerRepository)
        {
            _rentalRepository = rentalRepository;
            _vehicleRepository = vehicleRepository;
            _customerRepository = customerRepository;
        }

        public ValueTask<IResult> Handle(StartRentalCommand command, CancellationToken cancellationToken)
        {
            var request = command.Request;
            var customer = _customerRepository.GetCustomerById(request.CustomerId);
            if (customer == null) return new ValueTask<IResult>(Results.BadRequest("Customer not found."));

            var vehicle = _vehicleRepository.GetVehicleByVin(request.VehicleVin);
            if (vehicle == null) return new ValueTask<IResult>(Results.BadRequest("Vehicle not found."));

            try
            {
                var rental = vehicle.StartRental(customer, request.ExpectedReturnDate, request.StartingMileage, request.PickupDate);
                _rentalRepository.AddRental(rental);
                _vehicleRepository.UpdateVehicle(vehicle);
                _customerRepository.UpdateCustomer(customer);
                return new ValueTask<IResult>(Results.Created($"/api/rentals/{rental.Id}", rental));
            }
            catch (Exception ex)
            {
                return new ValueTask<IResult>(Results.BadRequest(ex.Message));
            }
        }
    }

    public class CompleteRentalHandler : IRequestHandler<CompleteRentalCommand, IResult>
    {
        private readonly IRentalRepository _rentalRepository;
        private readonly IVehicleRepository _vehicleRepository;

        public CompleteRentalHandler(IRentalRepository rentalRepository, IVehicleRepository vehicleRepository)
        {
            _rentalRepository = rentalRepository;
            _vehicleRepository = vehicleRepository;
        }

        public ValueTask<IResult> Handle(CompleteRentalCommand command, CancellationToken cancellationToken)
        {
            var rental = _rentalRepository.GetRentalById(command.Id);
            if (rental == null) return new ValueTask<IResult>(Results.NotFound("Rental not found."));

            var vehicle = _vehicleRepository.GetVehicleById(rental.VehicleId.GetValueOrDefault());
            if (vehicle == null) return new ValueTask<IResult>(Results.NotFound("Associated vehicle not found."));

            try
            {
                vehicle.CompleteRental(rental, command.Request.EndingMileage);
                _rentalRepository.UpdateRental(rental);
                _vehicleRepository.UpdateVehicle(vehicle);
                return new ValueTask<IResult>(Results.Ok(rental));
            }
            catch (Exception ex)
            {
                return new ValueTask<IResult>(Results.BadRequest(ex.Message));
            }
        }
    }

    public class UpdateRentalHandler : IRequestHandler<UpdateRentalCommand, IResult>
    {
        private readonly IRentalRepository _repository;
        public UpdateRentalHandler(IRentalRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(UpdateRentalCommand command, CancellationToken cancellationToken)
        {
            var rental = _repository.GetRentalById(command.Id);
            if (rental == null) return new ValueTask<IResult>(Results.NotFound("Rental not found."));

            var request = command.Request;
            if (request.Status == (int)RentalStatus.Active)
            {
                rental.UpdateActiveDetails(request.ExpectedReturnDate, request.StartingMileage);
            }
            else if (request.Status == (int)RentalStatus.Completed)
            {
                if (request.ActualReturnDate.HasValue && request.EndingMileage.HasValue && request.TotalCost.HasValue)
                {
                    rental.UpdateCompletedDetails(request.ActualReturnDate.Value, request.EndingMileage.Value, request.TotalCost.Value);
                }
            }

            _repository.UpdateRental(rental);
            return new ValueTask<IResult>(Results.Ok(rental));
        }
    }
}
