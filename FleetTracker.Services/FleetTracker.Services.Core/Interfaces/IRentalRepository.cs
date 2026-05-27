using System;
using System.Collections.Generic;
using FleetTracker.Services.Core.Models;

namespace FleetTracker.Services.Core.Interfaces
{
    public interface IRentalRepository
    {
        IEnumerable<RentalAgreement> GetAllRentals();
        RentalAgreement GetRentalById(Guid id);
        void AddRental(RentalAgreement agreement);
        void UpdateRental(RentalAgreement agreement);
    }
}
