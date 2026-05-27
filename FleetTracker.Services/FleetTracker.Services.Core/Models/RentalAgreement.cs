using System;

namespace FleetTracker.Services.Core.Models
{
    public class RentalAgreement : Entity
    {
        public string AgreementNumber { get; private set; }
        public DateTime PickupDate { get; private set; }
        public DateTime ExpectedReturnDate { get; private set; }
        public DateTime? ActualReturnDate { get; private set; }
        public int StartingMileage { get; private set; }
        public int? EndingMileage { get; private set; }
        public decimal? TotalCost { get; private set; }
        public RentalStatus Status { get; private set; }
        
        public Guid CustomerId { get; private set; }
        public Customer? Customer { get; private set; }
        
        public Guid VehicleId { get; private set; }
        public Vehicle? Vehicle { get; private set; }

        public RentalAgreement(string agreementNumber, DateTime pickupDate, DateTime expectedReturnDate, int startingMileage, Guid customerId, Guid vehicleId)
            : base()
        {
            if (expectedReturnDate < pickupDate)
            {
                throw new ArgumentException("Expected return date cannot be before pickup date.");
            }

            AgreementNumber = agreementNumber;
            PickupDate = pickupDate;
            ExpectedReturnDate = expectedReturnDate;
            StartingMileage = startingMileage;
            CustomerId = customerId;
            VehicleId = vehicleId;
            Status = RentalStatus.Active;
        }

        public void UpdateActiveDetails(DateTime expectedReturnDate, int startingMileage)
        {
            if (Status != RentalStatus.Active) throw new InvalidOperationException("Cannot update active details of a non-active rental.");
            ExpectedReturnDate = expectedReturnDate;
            StartingMileage = startingMileage;
        }

        public void UpdateCompletedDetails(DateTime? actualReturnDate, int endingMileage, decimal totalCost)
        {
            if (Status != RentalStatus.Completed) throw new InvalidOperationException("Cannot update completed details of a non-completed rental.");
            ActualReturnDate = actualReturnDate;
            EndingMileage = endingMileage;
            TotalCost = totalCost;
        }

        // calculates the total billable cost based on full days rented, has a minimum of 1 day
        public void Complete(int endingMileage, decimal dailyRate)
        {
            if (Status != RentalStatus.Active)
            {
                throw new InvalidOperationException("Only active agreements can be completed.");
            }

            if (endingMileage < StartingMileage)
            {
                throw new ArgumentException("Ending mileage cannot be less than starting mileage.");
            }

            EndingMileage = endingMileage;
            ActualReturnDate = DateTime.Now;
            
            var daysRented = (ActualReturnDate.Value - PickupDate).TotalDays;
            var billableDays = (int)Math.Ceiling(Math.Max(1, daysRented));
            TotalCost = billableDays * dailyRate;

            Status = RentalStatus.Completed;
        }

        public void Cancel()
        {
            if (Status != RentalStatus.Active)
            {
                throw new InvalidOperationException("Only active agreements can be cancelled.");
            }

            Status = RentalStatus.Cancelled;
        }
    }
}
