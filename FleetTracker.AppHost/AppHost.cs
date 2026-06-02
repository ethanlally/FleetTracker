var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddConnectionString("FleetTrackerDb");

var api = builder.AddProject<Projects.FleetTracker_Services_Api>("api")
    .WithReference(sql);

var consoleApp = builder.AddExecutable("consoleapp", "cmd.exe", ".", "/c", "start", "cmd", "/k", "dotnet", "run", "--project", "..\\FleetTracker.Services\\FleetTracker.Services.ConsoleApp")
    .WithReference(api);

builder.Build().Run();
