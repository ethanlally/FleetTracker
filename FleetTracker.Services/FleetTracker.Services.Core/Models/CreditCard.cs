using System;

namespace FleetTracker.Services.Core.Models
{
    public record CreditCard
    {
        public string CardNumber { get; init; }
        public string CardHolderName { get; init; }
        public string ExpirationDate { get; init; }
        public string Cvv { get; init; }

#pragma warning disable CS8618
        private CreditCard() { } // Required for EF Core
#pragma warning restore CS8618

        public CreditCard(string cardNumber, string cardHolderName, string expirationDate, string cvv)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpirationDate = expirationDate;
            Cvv = cvv;
        }
    }
}