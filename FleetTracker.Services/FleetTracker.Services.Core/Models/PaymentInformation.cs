using System;

namespace FleetTracker.Services.Core.Models
{
    public record PaymentInformation
    {
        public Address BillingAddress { get; init; }
        public CreditCard CreditCard { get; init; }

#pragma warning disable CS8618
        private PaymentInformation() { } // Required for EF Core
#pragma warning restore CS8618

        public PaymentInformation(Address billingAddress, CreditCard creditCard)
        {
            BillingAddress = billingAddress;
            CreditCard = creditCard;
        }
    }
}
