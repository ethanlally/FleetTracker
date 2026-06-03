using System;
using System.Collections.Generic;
using FleetTracker.Services.Core.Models;

namespace FleetTracker.Services.Core.Interfaces
{
    public interface IRentalRepository
    {
        IEnumerable<RentalAgreement> GetAllRentals();
        IEnumerable<RentalAgreement> GetRentalsByCustomerId(Guid customerId);
        IEnumerable<RentalAgreement> GetRentalsByVehicleId(Guid vehicleId);
        RentalAgreement? GetRentalById(Guid id);
        RentalAgreement? GetRentalByAgreementNumber(string agreementNumber);
        void AddRental(RentalAgreement rental);
        void UpdateRental(RentalAgreement rental);
        void CompleteRental(Guid id, int endingMileage);
    }
}