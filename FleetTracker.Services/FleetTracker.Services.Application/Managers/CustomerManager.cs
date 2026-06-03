using System;
using System.Linq;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;

using FleetTracker.Services.Application.Interfaces;

namespace FleetTracker.Services.Application.Managers
{
    public class CustomerManager
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IConsoleService _console;

        public CustomerManager(ICustomerRepository customerRepository, IVehicleRepository vehicleRepository, IConsoleService console)
        {
            _customerRepository = customerRepository;
            _vehicleRepository = vehicleRepository;
            _console = console;
        }

        public void ManageCustomers()
        {
            bool back = false;
            while (!back)
            {
                _console.WriteLine();
                _console.WriteLine("******Customer Management******");
                _console.WriteLine("1. Create Customer");
                _console.WriteLine("2. View Customer Profile");
                _console.WriteLine("3. List All Customers");
                _console.WriteLine("4. Edit Customer Information");
                _console.WriteLine("5. Delete Customer");
                _console.WriteLine("6. Go Back to Main Menu");

                string choice = _console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1": CreateCustomer(); break;
                        case "2": ViewCustomerProfile(); break;
                        case "3": ListAllCustomers(); break;
                        case "4": EditCustomer(); break;
                        case "5": DeleteCustomer(); break;
                        case "6": back = true; break;
                        default: _console.WriteLine("Invalid Selection!"); break;
                    }
                }
                catch (Exception e)
                {
                    _console.WriteLine($"Error: {e.Message}");
                }
            }
        }

        private void CreateCustomer()
        {
            string license = GetUniqueLicense();

            string name = _console.PromptForNameCityCountry("Enter Full Name: ");
            string email = _console.PromptForEmail("Enter Email: ");
            string phone = _console.PromptForPhone("Enter Phone Number: ");

            DateTime dob = _console.PromptForDate("Enter Date of Birth (yyyy-mm-dd): ");
            // enforcing minimum age requirements during input (can be changed to different age if needed)
            while (dob > DateTime.Now.AddYears(-18))
            {
                _console.WriteLine("Customer must be at least 18 years old.");
                dob = _console.PromptForDate("Enter Date of Birth (yyyy-mm-dd): ");
            }

            string street = _console.PromptForStreet("Enter Street Address: ");
            string city = _console.PromptForNameCityCountry("Enter City: ");
            string state = _console.PromptForState("Enter State: ");
            string zip = _console.PromptForZip("Enter Zip Code: ");
            string country = _console.PromptForNameCityCountry("Enter Country: ");
            var address = new Address(street, city, state, zip, country);

            var contact = new ContactInfo(name, email, phone);

            _console.WriteLine("--- Payment Information ---");
            string ccNumber = _console.PromptForCreditCard("Enter Credit Card Number: ");
            string ccName = _console.PromptForNameCityCountry("Enter Name on Card: ");
            string ccExp = _console.PromptForExpirationDate("Enter Expiration Date (mm/yy): ");
            string ccCvv = _console.PromptForCvv("Enter CVV: ");
            var creditCard = new CreditCard(ccNumber, ccName, ccExp, ccCvv);

            var paymentInfo = new PaymentInformation(address, creditCard);

            var customer = new Customer(license, dob, paymentInfo, contact, address);
            _customerRepository.AddCustomer(customer);

            _console.WriteLine("Customer created successfully.");
        }

        private string GetUniqueLicense()
        {
            string license = _console.PromptForDriversLicense("Enter Driver's License: ");

            while (_customerRepository.GetCustomerByLicense(license) != null)
            {
                license = _console.PromptForDriversLicense("A customer with this license already exists. Please try another: ");
            }

            return license;
        }

        private void ViewCustomerProfile()
        {
            _console.WriteLine("All Customers:");
            foreach (var c in _customerRepository.GetAllCustomers())
            {
                _console.WriteLine($"  [{c.DriversLicense}] {c.Contact.Name}");
            }
            _console.WriteLine();

            string license = _console.PromptForInput("Enter Driver's License: ");

            var customer = _customerRepository.GetCustomerByLicense(license);
            while (customer == null)
            {
                license = _console.PromptForInput("Customer not found. Try another license or type 'CANCEL' to go back: ");
                if (license.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
                customer = _customerRepository.GetCustomerByLicense(license);
            }

            PrintCustomerDetails(customer);
        }

        private void PrintCustomerDetails(Customer customer)
        {
            _console.WriteLine("------------------------------------------------");
            _console.WriteLine($"ID (Guid): {customer.Id}");
            _console.WriteLine($"Name: {customer.Contact.Name}");
            _console.WriteLine($"License: {customer.DriversLicense}");
            _console.WriteLine($"Date of Birth: {customer.DateOfBirth.ToShortDateString()}");
            _console.WriteLine($"Email: {customer.Contact.Email}");
            _console.WriteLine($"Phone: {customer.Contact.PhoneNumber}");
            _console.WriteLine($"Address: {customer.HomeAddress.Street}, {customer.HomeAddress.City}, {customer.HomeAddress.State} {customer.HomeAddress.Zip} {customer.HomeAddress.Country}");

            _console.WriteLine($"Payment Info - Card Name: {customer.PaymentInformation.CreditCard.CardHolderName}");
            _console.WriteLine($"Payment Info - Card Number: {customer.PaymentInformation.CreditCard.CardNumber}");
            _console.WriteLine($"Payment Info - Exp: {customer.PaymentInformation.CreditCard.ExpirationDate} | CVV: {customer.PaymentInformation.CreditCard.Cvv}");

            if (customer.RentalHistory.Count == 0)
            {
                _console.WriteLine("Total Rentals: 0");
            }
            else
            {
                _console.WriteLine($"Total Rentals: {customer.RentalHistory.Count}");
                _console.WriteLine("Rental History:");
                foreach (var rh in customer.RentalHistory)
                {
                    var vehicle = rh.VehicleId.HasValue ? _vehicleRepository.GetVehicleById(rh.VehicleId.Value) : null;
                    string vInfo = vehicle != null ? $"{vehicle.Year} {vehicle.Make} {vehicle.Model} (VIN: {vehicle.VIN})" : "Unknown Vehicle";
                    _console.WriteLine($"  - {vInfo} | Status: {rh.Status}");
                }
            }
            _console.WriteLine("------------------------------------------------");
        }

        private void ListAllCustomers()
        {
            var customers = _customerRepository.GetAllCustomers();
            if (!customers.Any())
            {
                _console.WriteLine("No customers found.");
                return;
            }

            foreach (var c in customers)
            {
                _console.WriteLine("--------------------------------------------------");
                _console.WriteLine($"[{c.DriversLicense}] {c.Contact.Name}");
                _console.WriteLine($"Email: {c.Contact.Email} | Phone: {c.Contact.PhoneNumber}");
            }
            _console.WriteLine("--------------------------------------------------");
        }

        private void EditCustomer()
        {
            _console.WriteLine("All Customers:");
            foreach (var c in _customerRepository.GetAllCustomers())
            {
                _console.WriteLine($"  [{c.DriversLicense}] {c.Contact.Name}");
            }
            _console.WriteLine();

            string license = _console.PromptForInput("Enter Driver's License to edit: ");
            var customer = _customerRepository.GetCustomerByLicense(license);
            while (customer == null)
            {
                license = _console.PromptForInput("Customer not found. Try another license or type 'CANCEL' to go back: ");
                if (license.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
                customer = _customerRepository.GetCustomerByLicense(license);
            }

            _console.WriteLine("Enter new values or press Enter to keep current values.");

            string newLicense = _console.PromptForOptionalDriversLicense($"Drivers License ({customer.DriversLicense}): ", customer.DriversLicense);
            if (newLicense != customer.DriversLicense)
            {
                // checking the repository to make sure new license isn't taken already
                while (_customerRepository.GetCustomerByLicense(newLicense) != null)
                {
                    newLicense = _console.PromptForOptionalDriversLicense($"License {newLicense} is already taken. Try another or press Enter to keep ({customer.DriversLicense}): ", customer.DriversLicense);
                }
            }

            DateTime newDob = _console.PromptForOptionalDate($"Date of Birth ({customer.DateOfBirth:yyyy-MM-dd}): ", customer.DateOfBirth);
            while (newDob > DateTime.Now.AddYears(-18))
            {
                _console.WriteLine("Customer must be at least 18 years old.");
                newDob = _console.PromptForOptionalDate($"Date of Birth ({customer.DateOfBirth:yyyy-MM-dd}): ", customer.DateOfBirth);
            }

            customer.UpdateBasicInfo(newLicense, newDob);

            string newName = _console.PromptForOptionalNameCityCountry($"Name ({customer.Contact.Name}): ", customer.Contact.Name);
            string newEmail = _console.PromptForOptionalEmail($"Email ({customer.Contact.Email}): ", customer.Contact.Email);
            string newPhone = _console.PromptForOptionalPhone($"Phone ({customer.Contact.PhoneNumber}): ", customer.Contact.PhoneNumber);
            customer.UpdateContact(new ContactInfo(newName, newEmail, newPhone));

            string newStreet = _console.PromptForOptionalStreet($"Street ({customer.HomeAddress.Street}): ", customer.HomeAddress.Street);
            string newCity = _console.PromptForOptionalNameCityCountry($"City ({customer.HomeAddress.City}): ", customer.HomeAddress.City);
            string newState = _console.PromptForOptionalState($"State ({customer.HomeAddress.State}): ", customer.HomeAddress.State);
            string newZip = _console.PromptForOptionalZip($"Zip ({customer.HomeAddress.Zip}): ", customer.HomeAddress.Zip);
            string newCountry = _console.PromptForOptionalNameCityCountry($"Country ({customer.HomeAddress.Country}): ", customer.HomeAddress.Country);
            customer.UpdateAddress(new Address(newStreet, newCity, newState, newZip, newCountry));

            string ccNumber = _console.PromptForOptionalCreditCard($"CC Number ({customer.PaymentInformation.CreditCard.CardNumber}): ", customer.PaymentInformation.CreditCard.CardNumber);
            string ccName = _console.PromptForOptionalNameCityCountry($"CC Name ({customer.PaymentInformation.CreditCard.CardHolderName}): ", customer.PaymentInformation.CreditCard.CardHolderName);
            string ccExp = _console.PromptForOptionalExpirationDate($"CC Exp (mm/yy) ({customer.PaymentInformation.CreditCard.ExpirationDate}): ", customer.PaymentInformation.CreditCard.ExpirationDate);
            string ccCvv = _console.PromptForOptionalCvv($"CC CVV ({customer.PaymentInformation.CreditCard.Cvv}): ", customer.PaymentInformation.CreditCard.Cvv);

            var newCc = new CreditCard(ccNumber, ccName, ccExp, ccCvv);
            customer.UpdatePayment(new PaymentInformation(customer.PaymentInformation.BillingAddress, newCc));

            _customerRepository.UpdateCustomer(customer);
            _console.WriteLine();
            _console.WriteLine("Customer updated successfully. New Details:");
            PrintCustomerDetails(customer);
        }

        private void DeleteCustomer()
        {
            _console.WriteLine("All Customers:");
            foreach (var c in _customerRepository.GetAllCustomers())
            {
                _console.WriteLine($"  [{c.DriversLicense}] {c.Contact.Name}");
            }
            _console.WriteLine();

            string license = _console.PromptForInput("Enter Driver's License to delete: ");
            var customer = _customerRepository.GetCustomerByLicense(license);

            if (customer == null)
            {
                _console.WriteLine("Customer not found.");
                return;
            }

            string confirm = _console.PromptForInput($"Are you sure you want to delete {customer.Contact.Name}? (Y/N): ");
            if (confirm.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    _customerRepository.DeleteCustomer(customer.Id);
                    _console.WriteLine("Customer deleted successfully.");
                }
                catch (Exception ex)
                {
                    _console.WriteLine($"Error deleting customer: {ex.Message}");
                }
            }
            else
            {
                _console.WriteLine("Deletion cancelled.");
            }
        }
    }
}