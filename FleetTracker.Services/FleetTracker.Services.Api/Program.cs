using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Core.Repositories;
using FleetTracker.Services.Data;
using Scalar.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddOpenApi();

// Register the DbContext to use SQL Server
builder.Services.AddDbContext<FleetTrackerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FleetTrackerConnection")));

// Register the EfFleetRepository as Scoped
builder.Services.AddScoped<EfFleetRepository>();

// Forward the interfaces to the same scoped instance
builder.Services.AddScoped<ICustomerRepository>(sp => sp.GetRequiredService<EfFleetRepository>());
builder.Services.AddScoped<IVehicleRepository>(sp => sp.GetRequiredService<EfFleetRepository>());
builder.Services.AddScoped<IRentalRepository>(sp => sp.GetRequiredService<EfFleetRepository>());

var app = builder.Build();

// Apply migrations and seed data on startup
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<FleetTrackerDbContext>();
    context.Database.Migrate(); // Applies migrations (creates DB if it doesn't exist)

    // Seed data only if the database is empty
    if (!context.Customers.Any())
    {
        var repo = scope.ServiceProvider.GetRequiredService<EfFleetRepository>();
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
app.MapControllers();

app.Run();
