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
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var customers = _customerRepository.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetCustomerById(Guid id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            if (customer == null) return NotFound();
            return Ok(customer);
        }

        [HttpGet("license/{license}")]
        public IActionResult GetCustomerByLicense(string license)
        {
            var customer = _customerRepository.GetCustomerByLicense(license);
            if (customer == null) return NotFound();
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult CreateCustomer([FromBody] CreateCustomerRequest request)
        {
            if (_customerRepository.GetCustomerByLicense(request.DriversLicense) != null)
            {
                return BadRequest("A customer with this license already exists.");
            }

            var address = new Address(request.HomeAddress.Street, request.HomeAddress.City, request.HomeAddress.State, request.HomeAddress.Zip, request.HomeAddress.Country);
            var cleanPhone = new string(request.Contact.PhoneNumber.Where(char.IsDigit).ToArray());
            var contact = new ContactInfo(request.Contact.Name, request.Contact.Email, cleanPhone);
            var billingAddress = new Address(request.PaymentInformation.BillingAddress.Street, request.PaymentInformation.BillingAddress.City, request.PaymentInformation.BillingAddress.State, request.PaymentInformation.BillingAddress.Zip, request.PaymentInformation.BillingAddress.Country);
            var creditCard = new CreditCard(request.PaymentInformation.CreditCard.CardNumber, request.PaymentInformation.CreditCard.CardHolderName, request.PaymentInformation.CreditCard.ExpirationDate, request.PaymentInformation.CreditCard.Cvv);
            var paymentInfo = new PaymentInformation(billingAddress, creditCard);

            var customer = new Customer(request.DriversLicense, request.DateOfBirth, paymentInfo, contact, address);
            _customerRepository.AddCustomer(customer);

            return CreatedAtAction(nameof(GetCustomerById), new { id = customer.Id }, customer);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateCustomer(Guid id, [FromBody] UpdateCustomerRequest request)
        {
            var customer = _customerRepository.GetCustomerById(id);
            if (customer == null) return NotFound();

            // Check if the license is being changed to one that already exists on another customer
            var existingWithLicense = _customerRepository.GetCustomerByLicense(request.DriversLicense);
            if (existingWithLicense != null && existingWithLicense.Id != id)
            {
                return BadRequest("A different customer with this license already exists.");
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

            _customerRepository.UpdateCustomer(customer);

            return Ok(customer);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteCustomer(Guid id)
        {
            try
            {
                var customer = _customerRepository.GetCustomerById(id);
                if (customer == null) return NotFound();

                _customerRepository.DeleteCustomer(id);
                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}