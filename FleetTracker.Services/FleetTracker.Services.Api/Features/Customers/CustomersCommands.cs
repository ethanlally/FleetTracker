using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Microsoft.AspNetCore.Http;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;
using FleetTracker.Services.Core.DataModels;

namespace FleetTracker.Services.Api.Features.Customers
{
    public record CreateCustomerCommand(CreateCustomerRequest Request) : IRequest<IResult>;
    public record UpdateCustomerCommand(Guid Id, UpdateCustomerRequest Request) : IRequest<IResult>;
    public record DeleteCustomerCommand(Guid Id) : IRequest<IResult>;

    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, IResult>
    {
        private readonly ICustomerRepository _repository;
        public CreateCustomerHandler(ICustomerRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(CreateCustomerCommand command, CancellationToken cancellationToken)
        {
            var request = command.Request;
            if (_repository.GetCustomerByLicense(request.DriversLicense) != null)
            {
                return new ValueTask<IResult>(Results.BadRequest("A customer with this license already exists."));
            }

            var address = new Address(request.HomeAddress.Street, request.HomeAddress.City, request.HomeAddress.State, request.HomeAddress.Zip, request.HomeAddress.Country);
            var cleanPhone = new string(request.Contact.PhoneNumber.Where(char.IsDigit).ToArray());
            var contact = new ContactInfo(request.Contact.Name, request.Contact.Email, cleanPhone);
            var billingAddress = new Address(request.PaymentInformation.BillingAddress.Street, request.PaymentInformation.BillingAddress.City, request.PaymentInformation.BillingAddress.State, request.PaymentInformation.BillingAddress.Zip, request.PaymentInformation.BillingAddress.Country);
            var creditCard = new CreditCard(request.PaymentInformation.CreditCard.CardNumber, request.PaymentInformation.CreditCard.CardHolderName, request.PaymentInformation.CreditCard.ExpirationDate, request.PaymentInformation.CreditCard.Cvv);
            var paymentInfo = new PaymentInformation(billingAddress, creditCard);

            var customer = new Customer(request.DriversLicense, request.DateOfBirth, paymentInfo, contact, address);
            _repository.AddCustomer(customer);

            // Because Minimal APIs don't easily have CreatedAtAction without route names, we return Created
            return new ValueTask<IResult>(Results.Created($"/api/customers/{customer.Id}", customer));
        }
    }

    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, IResult>
    {
        private readonly ICustomerRepository _repository;
        public UpdateCustomerHandler(ICustomerRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(UpdateCustomerCommand command, CancellationToken cancellationToken)
        {
            var id = command.Id;
            var request = command.Request;

            var customer = _repository.GetCustomerById(id);
            if (customer == null) return new ValueTask<IResult>(Results.NotFound());

            var existingWithLicense = _repository.GetCustomerByLicense(request.DriversLicense);
            if (existingWithLicense != null && existingWithLicense.Id != id)
            {
                return new ValueTask<IResult>(Results.BadRequest("A different customer with this license already exists."));
            }

            customer.UpdateBasicInfo(request.DriversLicense, request.DateOfBirth);

            var cleanPhone = new string(request.Contact.PhoneNumber.Where(char.IsDigit).ToArray());
            var contact = new ContactInfo(request.Contact.Name, request.Contact.Email, cleanPhone);
            customer.UpdateContact(contact);

            var address = new Address(request.HomeAddress.Street, request.HomeAddress.City, request.HomeAddress.State, request.HomeAddress.Zip, request.HomeAddress.Country);
            customer.UpdateAddress(address);

            var billingAddress = new Address(request.PaymentInformation.BillingAddress.Street, request.PaymentInformation.BillingAddress.City, request.PaymentInformation.BillingAddress.State, request.PaymentInformation.BillingAddress.Zip, request.PaymentInformation.BillingAddress.Country);
            var creditCard = new CreditCard(request.PaymentInformation.CreditCard.CardNumber, request.PaymentInformation.CreditCard.CardHolderName, request.PaymentInformation.CreditCard.ExpirationDate, request.PaymentInformation.CreditCard.Cvv);
            var paymentInfo = new PaymentInformation(billingAddress, creditCard);
            customer.UpdatePayment(paymentInfo);

            _repository.UpdateCustomer(customer);

            return new ValueTask<IResult>(Results.Ok(customer));
        }
    }

    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, IResult>
    {
        private readonly ICustomerRepository _repository;
        public DeleteCustomerHandler(ICustomerRepository repository) => _repository = repository;

        public ValueTask<IResult> Handle(DeleteCustomerCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var customer = _repository.GetCustomerById(command.Id);
                if (customer == null) return new ValueTask<IResult>(Results.NotFound());

                _repository.DeleteCustomer(command.Id);
                return new ValueTask<IResult>(Results.NoContent());
            }
            catch (InvalidOperationException ex)
            {
                return new ValueTask<IResult>(Results.BadRequest(ex.Message));
            }
        }
    }
}