using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Application.Interfaces;
using FleetTracker.Services.Application.Services;
using FleetTracker.Services.Application.Managers;
using FleetTracker.Services.Data;

// Setup Dependency Injection Container
var services = new ServiceCollection();

// Register the DbContext to use SQL Server (same localdb connection string)
services.AddDbContext<FleetTrackerDbContext>(options =>
    options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FleetTrackerDb;Trusted_Connection=True;MultipleActiveResultSets=true"));

// Register Services and Repositories
services.AddTransient<IInputValidator, InputValidator>();
services.AddTransient<IConsoleService, ConsoleService>();

services.AddScoped<EfFleetRepository>();
services.AddScoped<ICustomerRepository>(sp => sp.GetRequiredService<EfFleetRepository>());
services.AddScoped<IVehicleRepository>(sp => sp.GetRequiredService<EfFleetRepository>());
services.AddScoped<IRentalRepository>(sp => sp.GetRequiredService<EfFleetRepository>());

services.AddTransient<CustomerManager>();
services.AddTransient<VehicleManager>();
services.AddTransient<RentalManager>();

var serviceProvider = services.BuildServiceProvider();

// Initialize the database
using (var scope = serviceProvider.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<FleetTrackerDbContext>();
    context.Database.Migrate();

    if (!context.Customers.Any())
    {
        var repo = scope.ServiceProvider.GetRequiredService<EfFleetRepository>();
        FakeDataSeeder.Seed(repo, repo, repo);
    }
}

// Resolve the managers
var customerManager = serviceProvider.GetRequiredService<CustomerManager>();
var vehicleManager = serviceProvider.GetRequiredService<VehicleManager>();
var rentalManager = serviceProvider.GetRequiredService<RentalManager>();
var console = serviceProvider.GetRequiredService<IConsoleService>();

bool exit = false;
while (!exit)
{
    console.WriteLine();
    console.WriteLine("******Fleet Command Main Menu******");
    console.WriteLine("1. Customer Management");
    console.WriteLine("2. Vehicle Management");
    console.WriteLine("3. Rental Operations");
    console.WriteLine("4. Exit");
    console.WriteLine("Make a selection.");

    string choice = console.ReadLine();
    switch (choice)
    {
        case "1":
            customerManager.ManageCustomers();
            break;
        case "2":
            vehicleManager.ManageVehicles();
            break;
        case "3":
            rentalManager.ManageRentals();
            break;
        case "4":
            exit = true;
            break;
        default:
            console.WriteLine("Invalid Selection! Press Enter to try again.");
            console.ReadLine();
            break;
    }
}
