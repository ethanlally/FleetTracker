using FleetTracker.Services.Core.Interfaces;
using FleetTracker.Services.Data;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });
builder.Services.AddOpenApi();

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
    context.Database.Migrate(); // Applies migrations (creates DB if it doesn't exist)

    // Seed data only if the database is empty
    if (!context.Customers.Any())
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
app.MapControllers();

app.Run();