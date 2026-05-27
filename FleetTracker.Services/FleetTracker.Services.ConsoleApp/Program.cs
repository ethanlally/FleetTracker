using System;
using FleetTracker.Services.Core.Repositories;
using FleetTracker.Services.Application.Interfaces;
using FleetTracker.Services.Application.Services;
using FleetTracker.Services.Application.Managers;
using FleetTracker.Services.Data;

// setting up manual dependency injection for the managers, makes the code modular and easier to transition
var repository = new InMemoryFleetRepository();
var validator = new InputValidator();
var console = new ConsoleService(validator);

FakeDataSeeder.Seed(repository, repository, repository);

var customerManager = new CustomerManager(repository, repository, console);
var vehicleManager = new VehicleManager(repository, repository, console);
var rentalManager = new RentalManager(repository, repository, repository, console);

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
