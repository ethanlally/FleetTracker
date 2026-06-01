using System;

namespace FleetTracker.Services.Core.Models
{
    public record PaymentInformation
    {
        public Address BillingAddress { get; init; }
        public CreditCard CreditCard { get; init; }

        private PaymentInformation() { } // Required for EF Core

        public PaymentInformation(Address billingAddress, CreditCard creditCard)
        {
            BillingAddress = billingAddress;
            CreditCard = creditCard;
        }
    }
}
