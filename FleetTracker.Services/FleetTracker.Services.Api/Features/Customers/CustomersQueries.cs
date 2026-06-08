using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Microsoft.AspNetCore.Http;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;

namespace FleetTracker.Services.Api.Features.Customers
{
    public record GetAllCustomersQuery : IRequest<IResult>;
    public record GetCustomerByIdQuery(Guid Id) : IRequest<IResult>;
    public record GetCustomerByLicenseQuery(string License) : IRequest<IResult>;

    public class GetAllCustomersHandler : IRequestHandler<GetAllCustomersQuery, IResult>
    {
        private readonly ICustomerRepository _repository;
        public GetAllCustomersHandler(ICustomerRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = _repository.GetAllCustomers();
            return new ValueTask<IResult>(Results.Ok(customers));
        }
    }

    public class GetCustomerByIdHandler : IRequestHandler<GetCustomerByIdQuery, IResult>
    {
        private readonly ICustomerRepository _repository;
        public GetCustomerByIdHandler(ICustomerRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = _repository.GetCustomerById(request.Id);
            if (customer == null) return new ValueTask<IResult>(Results.NotFound());
            return new ValueTask<IResult>(Results.Ok(customer));
        }
    }

    public class GetCustomerByLicenseHandler : IRequestHandler<GetCustomerByLicenseQuery, IResult>
    {
        private readonly ICustomerRepository _repository;
        public GetCustomerByLicenseHandler(ICustomerRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(GetCustomerByLicenseQuery request, CancellationToken cancellationToken)
        {
            var customer = _repository.GetCustomerByLicense(request.License);
            if (customer == null) return new ValueTask<IResult>(Results.NotFound());
            return new ValueTask<IResult>(Results.Ok(customer));
        }
    }
}