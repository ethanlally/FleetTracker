using System;
using Microsoft.Extensions.DependencyInjection;
using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Application.Interfaces;
using FleetTracker.Services.Application.Services;
using FleetTracker.Services.Application.Managers;
using FleetTracker.Services.ConsoleApp.Infrastructure;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = Host.CreateApplicationBuilder(args);

builder.Logging.ClearProviders();

// Hook into Aspire telemetry and defaults
builder.AddServiceDefaults();

// Register the HTTP Client for ApiFleetRepository to talk to the "api" service
builder.Services.AddHttpClient<ApiFleetRepository>(client => 
{
    client.BaseAddress = new Uri("https+http://api");
});

// Register Services and Repositories
builder.Services.AddTransient<IInputValidator, InputValidator>();
builder.Services.AddTransient<IConsoleService, ConsoleService>();

// Forward the interfaces to the ApiFleetRepository from the DI container
builder.Services.AddScoped<ICustomerRepository>(sp => sp.GetRequiredService<ApiFleetRepository>());
builder.Services.AddScoped<IVehicleRepository>(sp => sp.GetRequiredService<ApiFleetRepository>());
builder.Services.AddScoped<IRentalRepository>(sp => sp.GetRequiredService<ApiFleetRepository>());

builder.Services.AddTransient<CustomerManager>();
builder.Services.AddTransient<VehicleManager>();
builder.Services.AddTransient<RentalManager>();

var host = builder.Build();

var serviceProvider = host.Services;

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
