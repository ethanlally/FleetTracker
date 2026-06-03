using Microsoft.EntityFrameworkCore;
using FleetTracker.Services.Core.Models;

namespace FleetTracker.Services.Data
{
    public class FleetTrackerDbContext : DbContext
    {
        public FleetTrackerDbContext(DbContextOptions<FleetTrackerDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<RentalAgreement> RentalAgreements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.HasIndex(c => c.DriversLicense).IsUnique();

                // Configure value objects as complex types / owned entities
                entity.OwnsOne(c => c.Contact, contact =>
                {
                    contact.Property(c => c.Name).HasColumnName("ContactName");
                    contact.Property(c => c.Email).HasColumnName("ContactEmail");
                    contact.Property(c => c.PhoneNumber).HasColumnName("ContactPhone");
                });

                entity.OwnsOne(c => c.HomeAddress, address =>
                {
                    address.Property(a => a.Street).HasColumnName("HomeStreet");
                    address.Property(a => a.City).HasColumnName("HomeCity");
                    address.Property(a => a.State).HasColumnName("HomeState");
                    address.Property(a => a.Zip).HasColumnName("HomeZip");
                    address.Property(a => a.Country).HasColumnName("HomeCountry");
                });

                entity.OwnsOne(c => c.PaymentInformation, payment =>
                {
                    payment.OwnsOne(p => p.BillingAddress, address =>
                    {
                        address.Property(a => a.Street).HasColumnName("BillingStreet");
                        address.Property(a => a.City).HasColumnName("BillingCity");
                        address.Property(a => a.State).HasColumnName("BillingState");
                        address.Property(a => a.Zip).HasColumnName("BillingZip");
                        address.Property(a => a.Country).HasColumnName("BillingCountry");
                    });

                    payment.OwnsOne(p => p.CreditCard, card =>
                    {
                        card.Property(c => c.CardNumber).HasColumnName("CreditCardNumber");
                        card.Property(c => c.CardHolderName).HasColumnName("CreditCardHolder");
                        card.Property(c => c.ExpirationDate).HasColumnName("CreditCardExpiration");
                        card.Property(c => c.Cvv).HasColumnName("CreditCardCvv");
                    });
                });

            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(v => v.Id);
                entity.HasIndex(v => v.VIN).IsUnique();

                entity.OwnsMany(v => v.MaintenanceHistory, m =>
                {
                    m.ToTable("MaintenanceRecords");
                    m.WithOwner().HasForeignKey("VehicleId");
                    m.Property<Guid>("Id");
                    m.HasKey("Id");
                    m.Property(r => r.Cost).HasColumnType("decimal(18,2)");
                });
            });

            modelBuilder.Entity<RentalAgreement>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.HasIndex(r => r.AgreementNumber).IsUnique();
                entity.HasIndex(r => r.CustomerId);
                entity.HasIndex(r => r.VehicleId);

                // precision for currency
                entity.Property(r => r.TotalCost).HasColumnType("decimal(18,2)");
            });

            // Precision for vehicle daily rate
            modelBuilder.Entity<Vehicle>()
                .Property(v => v.DailyRate).HasColumnType("decimal(18,2)");
        }
    }
}