using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Application.Interfaces;
using FleetTracker.Services.Application.Services;
using FleetTracker.Services.Application.Managers;
using FleetTracker.Services.Data;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

var builder = Host.CreateApplicationBuilder(args);

// Hook into Aspire telemetry and defaults
builder.AddServiceDefaults();

// Register the DbContext to use the dynamic Aspire connection string
builder.Services.AddDbContext<FleetTrackerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FleetTrackerDb")));

// Register Services and Repositories
builder.Services.AddTransient<IInputValidator, InputValidator>();
builder.Services.AddTransient<IConsoleService, ConsoleService>();

builder.Services.AddScoped<EfFleetRepository>();
builder.Services.AddScoped<ICustomerRepository>(sp => sp.GetRequiredService<EfFleetRepository>());
builder.Services.AddScoped<IVehicleRepository>(sp => sp.GetRequiredService<EfFleetRepository>());
builder.Services.AddScoped<IRentalRepository>(sp => sp.GetRequiredService<EfFleetRepository>());

builder.Services.AddTransient<CustomerManager>();
builder.Services.AddTransient<VehicleManager>();
builder.Services.AddTransient<RentalManager>();

var host = builder.Build();

var serviceProvider = host.Services;

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
