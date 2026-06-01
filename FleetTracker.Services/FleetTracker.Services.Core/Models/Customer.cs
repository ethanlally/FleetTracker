using System;
using System.Collections.Generic;

namespace FleetTracker.Services.Core.Models
{
    public class Customer : Entity
    {
        // keeping these properties private to prevent overwriting important data from outside the class
        // need to use update methods (SOLID principles :o)
        public string DriversLicense { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public PaymentInformation PaymentInformation { get; private set; }
        public ContactInfo Contact { get; private set; }
        public Address HomeAddress { get; private set; }
        public ICollection<RentalAgreement> RentalHistory { get; private set; } = new List<RentalAgreement>();

        private Customer() : base() { } // Required for EF Core

        public Customer(string driversLicense, DateTime dateOfBirth, PaymentInformation paymentInformation, ContactInfo contact, Address homeAddress)
            : base()
        {
            DriversLicense = driversLicense;
            DateOfBirth = dateOfBirth;
            PaymentInformation = paymentInformation;
            Contact = contact;
            HomeAddress = homeAddress;
        }

        public void UpdateBasicInfo(string driversLicense, DateTime dateOfBirth)
        {
            DriversLicense = driversLicense;
            DateOfBirth = dateOfBirth;
        }

        public void UpdateContact(ContactInfo newContact)
        {
            Contact = newContact;
        }

        public void UpdateAddress(Address newAddress)
        {
            HomeAddress = newAddress;
        }
        
        public void UpdatePayment(PaymentInformation newPaymentInfo)
        {
            PaymentInformation = newPaymentInfo;
        }

        internal void AddRental(RentalAgreement agreement)
        {
            RentalHistory.Add(agreement);
        }
    }
}
