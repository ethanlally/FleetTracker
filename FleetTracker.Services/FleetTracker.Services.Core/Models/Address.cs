using System;

namespace FleetTracker.Services.Core.Models
{
    public record Address
    {
        public string Street { get; init; }
        public string City { get; init; }
        public string State { get; init; }
        public string Zip { get; init; }
        public string Country { get; init; }

        public Address(string street, string city, string state, string zip, string country)
        {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
            Country = country;
        }
    }
}
