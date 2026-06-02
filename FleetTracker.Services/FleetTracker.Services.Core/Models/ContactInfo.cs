using System;

namespace FleetTracker.Services.Core.Models
{
    public record ContactInfo
    {
        public string Name { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }

#pragma warning disable CS8618
        private ContactInfo() { } // Required for EF Core
#pragma warning restore CS8618

        public ContactInfo(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
