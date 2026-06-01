using System;

namespace FleetTracker.Services.Core.Models
{
    public record CreditCard
    {
        public string CardNumber { get; init; }
        public string CardHolderName { get; init; }
        public string ExpirationDate { get; init; }
        public string Cvv { get; init; }

        private CreditCard() { } // Required for EF Core

        public CreditCard(string cardNumber, string cardHolderName, string expirationDate, string cvv)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpirationDate = expirationDate;
            Cvv = cvv;
        }
    }
}
