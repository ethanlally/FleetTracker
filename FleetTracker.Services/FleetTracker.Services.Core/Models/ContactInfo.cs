using System;

namespace FleetTracker.Services.Core.Models
{
    public record ContactInfo
    {
        public string Name { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }

        private ContactInfo() { } // Required for EF Core

        public ContactInfo(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
