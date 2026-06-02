using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Models;
using FleetTracker.Services.Core.DataModels;
using Newtonsoft.Json;

namespace FleetTracker.Services.ConsoleApp.Infrastructure
{
    public class ApiFleetRepository : ICustomerRepository, IVehicleRepository, IRentalRepository
    {
        private readonly HttpClient _httpClient;

        private static readonly JsonSerializerSettings _jsonSettings = new JsonSerializerSettings
        {
            ContractResolver = new PrivateSetterContractResolver(),
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };

        public ApiFleetRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public IEnumerable<Customer> GetAllCustomers()
        {
            var json = _httpClient.GetStringAsync("/api/customers").Result;
            return JsonConvert.DeserializeObject<List<Customer>>(json, _jsonSettings) ?? new List<Customer>();
        }

        public Customer? GetCustomerById(Guid id)
        {
            var response = _httpClient.GetAsync($"/api/customers/{id}").Result;
            if (!response.IsSuccessStatusCode) return null;
            var json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Customer>(json, _jsonSettings);
        }

        public Customer? GetCustomerByLicense(string license)
        {
            var response = _httpClient.GetAsync($"/api/customers/license/{license}").Result;
            if (!response.IsSuccessStatusCode) return null;
            var json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Customer>(json, _jsonSettings);
        }

        public void AddCustomer(Customer customer)
        {
            var request = new CreateCustomerRequest
            {
                DriversLicense = customer.DriversLicense,
                DateOfBirth = customer.DateOfBirth,
                Contact = new ContactData
                {
                    Name = customer.Contact.Name,
                    Email = customer.Contact.Email,
                    PhoneNumber = customer.Contact.PhoneNumber
                },
                HomeAddress = new AddressData
                {
                    Street = customer.HomeAddress.Street,
                    City = customer.HomeAddress.City,
                    State = customer.HomeAddress.State,
                    Zip = customer.HomeAddress.Zip,
                    Country = customer.HomeAddress.Country
                },
                PaymentInformation = new PaymentData
                {
                    BillingAddress = new AddressData
                    {
                        Street = customer.PaymentInformation.BillingAddress.Street,
                        City = customer.PaymentInformation.BillingAddress.City,
                        State = customer.PaymentInformation.BillingAddress.State,
                        Zip = customer.PaymentInformation.BillingAddress.Zip,
                        Country = customer.PaymentInformation.BillingAddress.Country
                    },
                    CreditCard = new CreditCardData
                    {
                        CardNumber = customer.PaymentInformation.CreditCard.CardNumber,
                        CardHolderName = customer.PaymentInformation.CreditCard.CardHolderName,
                        ExpirationDate = customer.PaymentInformation.CreditCard.ExpirationDate,
                        Cvv = customer.PaymentInformation.CreditCard.Cvv
                    }
                }
            };

            var response = _httpClient.PostAsJsonAsync("/api/customers", request).Result;
            EnsureSuccess(response);
        }

        public void UpdateCustomer(Customer customer)
        {
            var request = new UpdateCustomerRequest
            {
                DriversLicense = customer.DriversLicense,
                DateOfBirth = customer.DateOfBirth,
                Contact = new ContactData
                {
                    Name = customer.Contact.Name,
                    Email = customer.Contact.Email,
                    PhoneNumber = customer.Contact.PhoneNumber
                },
                HomeAddress = new AddressData
                {
                    Street = customer.HomeAddress.Street,
                    City = customer.HomeAddress.City,
                    State = customer.HomeAddress.State,
                    Zip = customer.HomeAddress.Zip,
                    Country = customer.HomeAddress.Country
                },
                PaymentInformation = new PaymentData
                {
                    BillingAddress = new AddressData
                    {
                        Street = customer.PaymentInformation.BillingAddress.Street,
                        City = customer.PaymentInformation.BillingAddress.City,
                        State = customer.PaymentInformation.BillingAddress.State,
                        Zip = customer.PaymentInformation.BillingAddress.Zip,
                        Country = customer.PaymentInformation.BillingAddress.Country
                    },
                    CreditCard = new CreditCardData
                    {
                        CardNumber = customer.PaymentInformation.CreditCard.CardNumber,
                        CardHolderName = customer.PaymentInformation.CreditCard.CardHolderName,
                        ExpirationDate = customer.PaymentInformation.CreditCard.ExpirationDate,
                        Cvv = customer.PaymentInformation.CreditCard.Cvv
                    }
                }
            };

            var response = _httpClient.PutAsJsonAsync($"/api/customers/{customer.Id}", request).Result;
            EnsureSuccess(response);
        }

        public void DeleteCustomer(Guid id)
        {
            var response = _httpClient.DeleteAsync($"/api/customers/{id}").Result;
            EnsureSuccess(response);
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            var json = _httpClient.GetStringAsync("/api/vehicles").Result;
            return JsonConvert.DeserializeObject<List<Vehicle>>(json, _jsonSettings) ?? new List<Vehicle>();
        }

        public Vehicle? GetVehicleById(Guid id)
        {
            var vehicles = GetAllVehicles();
            foreach (var v in vehicles)
            {
                if (v.Id == id) return v;
            }
            return null;
        }

        public Vehicle? GetVehicleByVin(string vin)
        {
            var response = _httpClient.GetAsync($"/api/vehicles/{vin}").Result;
            if (!response.IsSuccessStatusCode) return null;
            var json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Vehicle>(json, _jsonSettings);
        }

        public void AddVehicle(Vehicle vehicle)
        {
            var request = new CreateVehicleRequest
            {
                VehicleVin = vehicle.VIN,
                LicensePlate = vehicle.LicensePlate,
                Make = vehicle.Make,
                Model = vehicle.Model,
                Year = vehicle.Year,
                Class = (int)vehicle.Class,
                DailyRate = vehicle.DailyRate
            };

            var content = new StringContent(JsonConvert.SerializeObject(request), System.Text.Encoding.UTF8, "application/json");
            var response = _httpClient.PostAsync("/api/vehicles", content).Result;

            if (!response.IsSuccessStatusCode)
            {
                var error = response.Content.ReadAsStringAsync().Result;
                throw new Exception($"API Error: {error}");
            }
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            var request = new UpdateVehicleRequest
            {
                LicensePlate = vehicle.LicensePlate,
                Make = vehicle.Make,
                Model = vehicle.Model,
                Year = vehicle.Year,
                Class = (int)vehicle.Class,
                DailyRate = vehicle.DailyRate,
                Status = (int)vehicle.Status
            };

            var response = _httpClient.PutAsJsonAsync($"/api/vehicles/{vehicle.VIN}", request).Result;
            EnsureSuccess(response);
        }

        public void SendVehicleToMaintenance(string vin, string description, decimal cost)
        {
            var request = new { Description = description, Cost = cost, Type = 0 };
            var response = _httpClient.PostAsJsonAsync($"/api/vehicles/{vin}/maintenance/start", request).Result;
            EnsureSuccess(response);
        }

        public void ReturnVehicleFromMaintenance(string vin)
        {
            var response = _httpClient.PostAsync($"/api/vehicles/{vin}/maintenance/return", null).Result;
            EnsureSuccess(response);
        }

        public void ToggleVehicleAvailability(string vin)
        {
            var response = _httpClient.PostAsync($"/api/vehicles/{vin}/toggle", null).Result;
            EnsureSuccess(response);
        }

        public void DeleteVehicle(Guid id)
        {
            var response = _httpClient.DeleteAsync($"/api/vehicles/{id}").Result;
            EnsureSuccess(response);
        }

        public IEnumerable<RentalAgreement> GetAllRentals()
        {
            var json = _httpClient.GetStringAsync("/api/rentals").Result;
            return JsonConvert.DeserializeObject<List<RentalAgreement>>(json, _jsonSettings) ?? new List<RentalAgreement>();
        }

        public RentalAgreement? GetRentalById(Guid id)
        {
            var rentals = GetAllRentals();
            foreach (var r in rentals)
            {
                if (r.Id == id) return r;
            }
            return null;
        }

        public RentalAgreement? GetRentalByAgreementNumber(string agreementNumber)
        {
            var rentals = GetAllRentals();
            foreach (var r in rentals)
            {
                if (string.Equals(r.AgreementNumber, agreementNumber, StringComparison.OrdinalIgnoreCase)) return r;
            }
            return null;
        }

        public void AddRental(RentalAgreement rental)
        {
            var request = new StartRentalRequest
            {
                CustomerId = rental.CustomerId.GetValueOrDefault(),
                VehicleVin = GetVehicleById(rental.VehicleId.GetValueOrDefault())?.VIN ?? string.Empty,
                ExpectedReturnDate = rental.ExpectedReturnDate,
                StartingMileage = rental.StartingMileage,
                PickupDate = rental.PickupDate
            };
            var response = _httpClient.PostAsJsonAsync("/api/rentals/start", request).Result;
            EnsureSuccess(response);
        }

        public void UpdateRental(RentalAgreement rental)
        {
            var request = new
            {
                ExpectedReturnDate = rental.ExpectedReturnDate,
                StartingMileage = rental.StartingMileage,
                ActualReturnDate = rental.ActualReturnDate,
                EndingMileage = rental.EndingMileage,
                TotalCost = rental.TotalCost,
                Status = (int)rental.Status
            };

            var response = _httpClient.PutAsJsonAsync($"/api/rentals/{rental.Id}", request).Result;
            EnsureSuccess(response);
        }

        public void CompleteRental(Guid id, int endingMileage)
        {
            var request = new { EndingMileage = endingMileage };
            var response = _httpClient.PostAsJsonAsync($"/api/rentals/{id}/complete", request).Result;
            EnsureSuccess(response);
        }

        private void EnsureSuccess(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var error = response.Content.ReadAsStringAsync().Result;
                throw new Exception($"API Error: {error}");
            }
        }
    }
}