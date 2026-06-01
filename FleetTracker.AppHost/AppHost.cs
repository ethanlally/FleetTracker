var builder = DistributedApplication.CreateBuilder(args);

// Define the connection string resource (points to our localdb)
var sql = builder.AddConnectionString("FleetTrackerDb");

// Orchestrate the Web API
var api = builder.AddProject<Projects.FleetTracker_Services_Api>("api")
    .WithReference(sql);

// Orchestrate the Console Application
var consoleApp = builder.AddProject<Projects.FleetTracker_Services_ConsoleApp>("consoleapp")
    .WithReference(sql);

builder.Build().Run();
