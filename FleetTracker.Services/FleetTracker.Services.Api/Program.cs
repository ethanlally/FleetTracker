using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Data;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Mediator;
using Microsoft.AspNetCore.Http;
using FleetTracker.Services.Api.Features.Customers;
using FleetTracker.Services.Api.Features.Vehicles;
using FleetTracker.Services.Api.Features.Rentals;
using System;
using FleetTracker.Services.Core.Models;
using FleetTracker.Services.Core.DataModels;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Configure JSON options for Minimal APIs to ignore cycles
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});

builder.Services.AddOpenApi();
builder.Services.AddAuthorization();
builder.Services.AddMediator(options => 
{
    options.ServiceLifetime = ServiceLifetime.Scoped;
}); // Registers Mediator handlers via Source Generator

// Register the DbContext to use the dynamic Aspire connection string
builder.Services.AddDbContext<FleetTrackerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FleetTrackerDb")));

// Register the EfFleetRepository as Scoped
builder.Services.AddScoped<EfFleetRepository>();

// Forward the interfaces to the same scoped instance
builder.Services.AddScoped<ICustomerRepository>(sp => sp.GetRequiredService<EfFleetRepository>());
builder.Services.AddScoped<IVehicleRepository>(sp => sp.GetRequiredService<EfFleetRepository>());
builder.Services.AddScoped<IRentalRepository>(sp => sp.GetRequiredService<EfFleetRepository>());

WebApplication app = builder.Build();

// Apply migrations and seed data on startup
using (IServiceScope scope = app.Services.CreateScope())
{
    FleetTrackerDbContext context = scope.ServiceProvider.GetRequiredService<FleetTrackerDbContext>();
    await context.Database.MigrateAsync(); // Applies migrations (creates DB if it doesn't exist)

    // Seed data only if the database is empty
    if (!await context.Customers.AnyAsync())
    {
        EfFleetRepository repo = scope.ServiceProvider.GetRequiredService<EfFleetRepository>();
        FakeDataSeeder.Seed(repo, repo, repo);
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Setup Minimal API groups
var api = app.MapGroup("/api");

// Customers
var customers = api.MapGroup("/customers").WithTags("Customers");
customers.MapGet("/", (IMediator mediator) => mediator.Send(new GetAllCustomersQuery()));
customers.MapGet("/{id:guid}", (Guid id, IMediator mediator) => mediator.Send(new GetCustomerByIdQuery(id)));
customers.MapGet("/license/{license}", (string license, IMediator mediator) => mediator.Send(new GetCustomerByLicenseQuery(license)));
customers.MapPost("/", (CreateCustomerRequest request, IMediator mediator) => mediator.Send(new CreateCustomerCommand(request)));
customers.MapPut("/{id:guid}", (Guid id, UpdateCustomerRequest request, IMediator mediator) => mediator.Send(new UpdateCustomerCommand(id, request)));
customers.MapDelete("/{id:guid}", (Guid id, IMediator mediator) => mediator.Send(new DeleteCustomerCommand(id)));

// Vehicles
var vehicles = api.MapGroup("/vehicles").WithTags("Vehicles");
vehicles.MapGet("/", (IMediator mediator) => mediator.Send(new GetAllVehiclesQuery()));
vehicles.MapPost("/", (CreateVehicleRequest request, IMediator mediator) => mediator.Send(new CreateVehicleCommand(request)));
vehicles.MapGet("/available", (IMediator mediator) => mediator.Send(new GetAvailableVehiclesQuery()));
vehicles.MapGet("/{vin}", (string vin, IMediator mediator) => mediator.Send(new GetVehicleByVinQuery(vin)));
vehicles.MapPost("/{vin}/toggle", (string vin, IMediator mediator) => mediator.Send(new ToggleVehicleAvailabilityCommand(vin)));
vehicles.MapPut("/{vin}", (string vin, UpdateVehicleRequest request, IMediator mediator) => mediator.Send(new UpdateVehicleCommand(vin, request)));
vehicles.MapPost("/{vin}/maintenance/start", (string vin, MaintenanceRequestDto request, IMediator mediator) => mediator.Send(new StartMaintenanceCommand(vin, request)));
vehicles.MapPost("/{vin}/maintenance/return", (string vin, IMediator mediator) => mediator.Send(new ReturnMaintenanceCommand(vin)));
vehicles.MapDelete("/{id:guid}", (Guid id, IMediator mediator) => mediator.Send(new DeleteVehicleCommand(id)));

// Rentals
var rentals = api.MapGroup("/rentals").WithTags("Rentals");
rentals.MapGet("/active", (IMediator mediator) => mediator.Send(new GetActiveRentalsQuery()));
rentals.MapGet("/", (IMediator mediator) => mediator.Send(new GetAllRentalsQuery()));
rentals.MapGet("/{id:guid}", (Guid id, IMediator mediator) => mediator.Send(new GetRentalByIdQuery(id)));
rentals.MapGet("/customer/{customerId:guid}", (Guid customerId, IMediator mediator) => mediator.Send(new GetRentalsByCustomerIdQuery(customerId)));
rentals.MapGet("/vehicle/{vehicleId:guid}", (Guid vehicleId, IMediator mediator) => mediator.Send(new GetRentalsByVehicleIdQuery(vehicleId)));
rentals.MapPost("/start", (StartRentalRequest request, IMediator mediator) => mediator.Send(new StartRentalCommand(request)));
rentals.MapPost("/{id:guid}/complete", (Guid id, CompleteRentalRequest request, IMediator mediator) => mediator.Send(new CompleteRentalCommand(id, request)));
rentals.MapPut("/{id:guid}", (Guid id, UpdateRentalRequest request, IMediator mediator) => mediator.Send(new UpdateRentalCommand(id, request)));

app.Run();