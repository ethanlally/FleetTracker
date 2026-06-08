using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Microsoft.AspNetCore.Http;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;

namespace FleetTracker.Services.Api.Features.Rentals
{
    public record GetActiveRentalsQuery : IRequest<IResult>;
    public record GetAllRentalsQuery : IRequest<IResult>;
    public record GetRentalByIdQuery(Guid Id) : IRequest<IResult>;
    public record GetRentalsByCustomerIdQuery(Guid CustomerId) : IRequest<IResult>;
    public record GetRentalsByVehicleIdQuery(Guid VehicleId) : IRequest<IResult>;

    public class GetActiveRentalsHandler : IRequestHandler<GetActiveRentalsQuery, IResult>
    {
        private readonly IRentalRepository _repository;
        public GetActiveRentalsHandler(IRentalRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(GetActiveRentalsQuery request, CancellationToken cancellationToken)
        {
            var rentals = _repository.GetAllRentals().Where(r => r.Status == RentalStatus.Active);
            return new ValueTask<IResult>(Results.Ok(rentals));
        }
    }

    public class GetAllRentalsHandler : IRequestHandler<GetAllRentalsQuery, IResult>
    {
        private readonly IRentalRepository _repository;
        public GetAllRentalsHandler(IRentalRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(GetAllRentalsQuery request, CancellationToken cancellationToken)
        {
            var rentals = _repository.GetAllRentals();
            return new ValueTask<IResult>(Results.Ok(rentals));
        }
    }

    public class GetRentalByIdHandler : IRequestHandler<GetRentalByIdQuery, IResult>
    {
        private readonly IRentalRepository _repository;
        public GetRentalByIdHandler(IRentalRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(GetRentalByIdQuery request, CancellationToken cancellationToken)
        {
            var rental = _repository.GetRentalById(request.Id);
            if (rental == null) return new ValueTask<IResult>(Results.NotFound());
            return new ValueTask<IResult>(Results.Ok(rental));
        }
    }

    public class GetRentalsByCustomerIdHandler : IRequestHandler<GetRentalsByCustomerIdQuery, IResult>
    {
        private readonly IRentalRepository _repository;
        public GetRentalsByCustomerIdHandler(IRentalRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(GetRentalsByCustomerIdQuery request, CancellationToken cancellationToken)
        {
            var rentals = _repository.GetRentalsByCustomerId(request.CustomerId);
            return new ValueTask<IResult>(Results.Ok(rentals));
        }
    }

    public class GetRentalsByVehicleIdHandler : IRequestHandler<GetRentalsByVehicleIdQuery, IResult>
    {
        private readonly IRentalRepository _repository;
        public GetRentalsByVehicleIdHandler(IRentalRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(GetRentalsByVehicleIdQuery request, CancellationToken cancellationToken)
        {
            var rentals = _repository.GetRentalsByVehicleId(request.VehicleId);
            return new ValueTask<IResult>(Results.Ok(rentals));
        }
    }
}