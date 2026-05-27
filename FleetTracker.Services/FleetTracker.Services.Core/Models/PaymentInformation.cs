using System;

namespace FleetTracker.Services.Core.Models
{
    public record PaymentInformation
    {
        public Address BillingAddress { get; init; }
        public CreditCard CreditCard { get; init; }

        public PaymentInformation(Address billingAddress, CreditCard creditCard)
        {
            BillingAddress = billingAddress;
            CreditCard = creditCard;
        }
    }
}
