using System;
using System.ComponentModel.DataAnnotations;

namespace FleetTracker.Services.Core.DataModels
{
    public class AddressData
    {
        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_.,()@+/]+$", ErrorMessage = "Input has invalid characters.")]
        public string Street { get; set; } = string.Empty;

        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_.,()@+/]+$", ErrorMessage = "Input has invalid characters.")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^(?i)(AK|AL|AR|AZ|CA|CO|CT|DE|FL|GA|HI|IA|ID|IL|IN|KS|KY|LA|MA|MD|ME|MI|MN|MO|MS|MT|NC|ND|NE|NH|NJ|NM|NV|NY|OH|OK|OR|PA|RI|SC|SD|TN|TX|UT|VA|VT|WA|WI|WV|WY)$", ErrorMessage = "State abbreviation not recognized.")]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Zip code is not in a valid format.")]
        public string Zip { get; set; } = string.Empty;

        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_.,()@+/]+$", ErrorMessage = "Input has invalid characters.")]
        public string Country { get; set; } = string.Empty;
    }

    public class ContactData
    {
        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_.,()@+/]+$", ErrorMessage = "Input has invalid characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [EmailAddress(ErrorMessage = "Email is not in a valid format.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [Phone(ErrorMessage = "Phone number is not in a valid format.")]
        [RegularExpression(@"^\D*(\d\D*){10}$", ErrorMessage = "Phone number must have exactly 10 digits.")]
        public string PhoneNumber { get; set; } = string.Empty;
    }

    public class CreditCardData
    {
        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_.,()@+/]+$", ErrorMessage = "Input has invalid characters.")]
        public string CardNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_.,()@+/]+$", ErrorMessage = "Input has invalid characters.")]
        public string CardHolderName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_.,()@+/]+$", ErrorMessage = "Input has invalid characters.")]
        public string ExpirationDate { get; set; } = string.Empty;

        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_.,()@+/]+$", ErrorMessage = "Input has invalid characters.")]
        public string Cvv { get; set; } = string.Empty;
    }

    public class PaymentData
    {
        [Required]
        public AddressData BillingAddress { get; set; } = new();
        [Required]
        public CreditCardData CreditCard { get; set; } = new();
    }

    public class CreateCustomerRequest
    {
        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_.,()@+/]+$", ErrorMessage = "Input has invalid characters.")]
        public string DriversLicense { get; set; } = string.Empty;

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public PaymentData PaymentInformation { get; set; } = new();

        [Required]
        public ContactData Contact { get; set; } = new();

        [Required]
        public AddressData HomeAddress { get; set; } = new();
    }

    public class StartRentalRequest
    {
        [Required]
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_.,()@+/]+$", ErrorMessage = "Input has invalid characters.")]
        public string VehicleVin { get; set; } = string.Empty;

        [Required]
        public DateTime ExpectedReturnDate { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Must be a valid positive integer.")]
        public int StartingMileage { get; set; }

        public DateTime? PickupDate { get; set; }
    }

    public class CompleteRentalRequest
    {
        [Range(0, int.MaxValue, ErrorMessage = "Must be a valid positive integer.")]
        public int EndingMileage { get; set; }
    }

    public class UpdateCustomerRequest
    {
        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_.,()@+/]+$", ErrorMessage = "Input has invalid characters.")]
        public string DriversLicense { get; set; } = string.Empty;

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public PaymentData PaymentInformation { get; set; } = new();

        [Required]
        public ContactData Contact { get; set; } = new();

        [Required]
        public AddressData HomeAddress { get; set; } = new();
    }

    public class UpdateVehicleRequest
    {
        [Required(ErrorMessage = "Input cannot be null or empty.")]
        [RegularExpression(@"^[a-zA-Z0-9\s\-_.,()@+/]+$", ErrorMessage = "Input has invalid characters.")]
        public string LicensePlate { get; set; } = string.Empty;

        [Required(ErrorMessage = "Input cannot be null or empty.")]
        public string Make { get; set; } = string.Empty;

        [Required(ErrorMessage = "Input cannot be null or empty.")]
        public string Model { get; set; } = string.Empty;

        [Range(1900, 2100)]
        public int Year { get; set; }

        [Required]
        public int Class { get; set; } // We can map the enum to an int to avoid dependency if needed, but let's use int

        [Range(0, double.MaxValue)]
        public decimal DailyRate { get; set; }

        [Required]
        public int Status { get; set; }
    }
}
