using System;

namespace FleetTracker.Services.Core.Models
{
    public record ContactInfo
    {
        public string Name { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }

        public ContactInfo(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
