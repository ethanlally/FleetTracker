using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Microsoft.AspNetCore.Http;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;

namespace FleetTracker.Services.Api.Features.Vehicles
{
    public record GetAllVehiclesQuery : IRequest<IResult>;
    public record GetAvailableVehiclesQuery : IRequest<IResult>;
    public record GetVehicleByVinQuery(string Vin) : IRequest<IResult>;

    public class GetAllVehiclesHandler : IRequestHandler<GetAllVehiclesQuery, IResult>
    {
        private readonly IVehicleRepository _repository;
        public GetAllVehiclesHandler(IVehicleRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(GetAllVehiclesQuery request, CancellationToken cancellationToken)
        {
            var vehicles = _repository.GetAllVehicles();
            return new ValueTask<IResult>(Results.Ok(vehicles));
        }
    }

    public class GetAvailableVehiclesHandler : IRequestHandler<GetAvailableVehiclesQuery, IResult>
    {
        private readonly IVehicleRepository _repository;
        public GetAvailableVehiclesHandler(IVehicleRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(GetAvailableVehiclesQuery request, CancellationToken cancellationToken)
        {
            var vehicles = _repository.GetAllVehicles().Where(v => v.Status == VehicleStatus.Available);
            return new ValueTask<IResult>(Results.Ok(vehicles));
        }
    }

    public class GetVehicleByVinHandler : IRequestHandler<GetVehicleByVinQuery, IResult>
    {
        private readonly IVehicleRepository _repository;
        public GetVehicleByVinHandler(IVehicleRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(GetVehicleByVinQuery request, CancellationToken cancellationToken)
        {
            var vehicle = _repository.GetVehicleByVin(request.Vin);
            if (vehicle == null) return new ValueTask<IResult>(Results.NotFound());
            return new ValueTask<IResult>(Results.Ok(vehicle));
        }
    }
}
