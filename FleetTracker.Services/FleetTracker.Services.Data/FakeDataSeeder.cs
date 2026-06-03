using System;
using FleetTracker.Services.Core.Models;
using FleetTracker.Services.Core.Interfaces;

namespace FleetTracker.Services.Data
{
    public static class FakeDataSeeder
    {
        public static void Seed(ICustomerRepository customerRepo, IVehicleRepository vehicleRepo, IRentalRepository rentalRepo)
        {
            // generated fake data to populate the system so I don't have to enter it all manually - can always add more later

            var address = new Address("123 Main St", "Anytown", "NY", "10001", "USA");
            var contact = new ContactInfo("John Doe", "john@example.com", "123-555-0100");
            var creditCard = new CreditCard("4111222233334444", "JOHN DOE", "12/30", "123");
            var paymentInfo = new PaymentInformation(address, creditCard);

            var c1 = new Customer("DL-111", new DateTime(1985, 5, 20), paymentInfo with { BillingAddress = address with { }, CreditCard = creditCard with { } }, contact with { }, address with { });
            var c2 = new Customer("DL-222", new DateTime(1990, 8, 15), paymentInfo with { BillingAddress = address with { }, CreditCard = creditCard with { } }, new ContactInfo("Jane Smith", "jane@example.com", "123-555-0200"), address with { });
            var c3 = new Customer("DL-333", new DateTime(1975, 2, 10), paymentInfo with { BillingAddress = address with { }, CreditCard = creditCard with { } }, new ContactInfo("Bob Jones", "bob@example.com", "123-555-0300"), address with { });
            var c4 = new Customer("DL-444", new DateTime(1992, 11, 5), paymentInfo with { BillingAddress = address with { }, CreditCard = creditCard with { } }, new ContactInfo("Alice Cooper", "alice@example.com", "123-555-0400"), address with { });
            var c5 = new Customer("DL-555", new DateTime(1988, 3, 22), paymentInfo with { BillingAddress = address with { }, CreditCard = creditCard with { } }, new ContactInfo("Charlie Brown", "charlie@example.com", "123-555-0500"), address with { });

            customerRepo.AddCustomer(c1);
            customerRepo.AddCustomer(c2);
            customerRepo.AddCustomer(c3);
            customerRepo.AddCustomer(c4);
            customerRepo.AddCustomer(c5);

            var v1 = new Vehicle("11111110000000000", "XYZ-101", "Honda", "Civic", 2023, VehicleClass.Compact, 35m);
            var v2 = new Vehicle("22222220000000000", "XYZ-102", "Toyota", "Camry", 2023, VehicleClass.Sedan, 45m);
            var v3 = new Vehicle("33333330000000000", "XYZ-103", "Ford", "Explorer", 2022, VehicleClass.SUV, 65m);
            var v4 = new Vehicle("44444440000000000", "XYZ-104", "Chevy", "Silverado", 2024, VehicleClass.Truck, 75m);
            var v5 = new Vehicle("55555550000000000", "XYZ-105", "BMW", "7 Series", 2023, VehicleClass.Luxury, 120m);
            var v6 = new Vehicle("66666660000000000", "XYZ-106", "Nissan", "Sentra", 2021, VehicleClass.Compact, 35m);
            var v7 = new Vehicle("77777770000000000", "XYZ-107", "Honda", "Accord", 2020, VehicleClass.Sedan, 40m);
            var v8 = new Vehicle("88888880000000000", "XYZ-108", "Jeep", "Wrangler", 2021, VehicleClass.SUV, 60m);
            var v9 = new Vehicle("99999990000000000", "XYZ-109", "Tesla", "Model 3", 2023, VehicleClass.Sedan, 55m);
            var v10 = new Vehicle("10101010000000000", "XYZ-110", "Ford", "Mustang", 2022, VehicleClass.Luxury, 90m);
            var v11 = new Vehicle("12121210000000000", "XYZ-111", "Subaru", "Outback", 2024, VehicleClass.SUV, 60m);
            var v12 = new Vehicle("13131310000000000", "XYZ-112", "Toyota", "Corolla", 2021, VehicleClass.Compact, 30m);

            vehicleRepo.AddVehicle(v1);
            vehicleRepo.AddVehicle(v2);
            vehicleRepo.AddVehicle(v3);
            vehicleRepo.AddVehicle(v4);
            vehicleRepo.AddVehicle(v5);
            vehicleRepo.AddVehicle(v6);
            vehicleRepo.AddVehicle(v7);
            vehicleRepo.AddVehicle(v8);
            vehicleRepo.AddVehicle(v9);
            vehicleRepo.AddVehicle(v10);
            vehicleRepo.AddVehicle(v11);
            vehicleRepo.AddVehicle(v12);

            var hist1 = v1.StartRental(c1, DateTime.Now.AddDays(-10), 10000, DateTime.Now.AddDays(-12));
            rentalRepo.AddRental(hist1);
            v1.CompleteRental(hist1, 10500);

            var hist2 = v2.StartRental(c2, DateTime.Now.AddDays(-5), 20000, DateTime.Now.AddDays(-8));
            rentalRepo.AddRental(hist2);
            v2.CompleteRental(hist2, 20300);

            var hist3 = v3.StartRental(c3, DateTime.Now.AddDays(-15), 5000, DateTime.Now.AddDays(-20));
            rentalRepo.AddRental(hist3);
            v3.CompleteRental(hist3, 5100);

            var hist4 = v1.StartRental(c4, DateTime.Now.AddDays(-2), 10600, DateTime.Now.AddDays(-5));
            rentalRepo.AddRental(hist4);
            v1.CompleteRental(hist4, 10800);

            var hist5 = v9.StartRental(c5, DateTime.Now.AddDays(-30), 1000, DateTime.Now.AddDays(-35));
            rentalRepo.AddRental(hist5);
            v9.CompleteRental(hist5, 1500);

            var hist6 = v9.StartRental(c1, DateTime.Now.AddDays(-10), 1600, DateTime.Now.AddDays(-14));
            rentalRepo.AddRental(hist6);
            v9.CompleteRental(hist6, 2000);

            var hist7 = v11.StartRental(c2, DateTime.Now.AddDays(-20), 5000, DateTime.Now.AddDays(-25));
            rentalRepo.AddRental(hist7);
            v11.CompleteRental(hist7, 5400);

            var active1 = v4.StartRental(c1, DateTime.Now.AddDays(3), 15000);
            rentalRepo.AddRental(active1);

            var active2 = v5.StartRental(c2, DateTime.Now.AddDays(1), 8000);
            rentalRepo.AddRental(active2);

            var active3 = v10.StartRental(c4, DateTime.Now.AddDays(5), 12000);
            rentalRepo.AddRental(active3);

            v6.SendToMaintenance("Routine Oil Change", 75.00m, MaintenanceType.Routine);
            vehicleRepo.UpdateVehicle(v6);

            v7.SendToMaintenance("Brake Pad Replacement", 250.00m, MaintenanceType.Repair);
            vehicleRepo.UpdateVehicle(v7);

            v8.SendToMaintenance("Annual Inspection", 50.00m, MaintenanceType.Inspection);
            vehicleRepo.UpdateVehicle(v8);

            v12.SendToMaintenance("Tire Rotation", 40.00m, MaintenanceType.Routine);
            vehicleRepo.UpdateVehicle(v12);

            v11.ToggleAvailability();
            vehicleRepo.UpdateVehicle(v11);
        }
    }
}