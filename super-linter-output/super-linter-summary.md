# Super-linter summary

| Language                   | Validation result |
| -------------------------- | ----------------- |
| BIOME_FORMAT               | Fail ❌           |
| BIOME_LINT                 | Pass ✅           |
| CHECKOV                    | Fail ❌           |
| CSHARP                     | Pass ✅           |
| EDITORCONFIG               | Fail ❌           |
| GITLEAKS                   | Pass ✅           |
| GIT_MERGE_CONFLICT_MARKERS | Pass ✅           |
| JSCPD                      | Fail ❌           |
| JSON                       | Pass ✅           |
| JSON_PRETTIER              | Pass ✅           |
| MARKDOWN                   | Pass ✅           |
| MARKDOWN_PRETTIER          | Fail ❌           |
| NATURAL_LANGUAGE           | Pass ✅           |
| PRE_COMMIT                 | Pass ✅           |
| SPELL_CODESPELL            | Fail ❌           |
| TRIVY                      | Pass ✅           |

All files and directories linted successfully

For more information, see the [GitHub Actions workflow run](https://github.com/ethanlally/FleetTracker/actions/runs/26849334608)

Powered by [Super-linter](https://github.com/super-linter/super-linter)

<details>

<summary>BIOME_FORMAT</summary>

```text
Checked 7 files in 9ms. No fixes applied.
Found 7 errors.FleetTracker.AppHost/Properties/launchSettings.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

     1  1 │   {
     2    │ - ··"$schema":·"https://json.schemastore.org/launchsettings.json",
     3    │ - ··"profiles":·{
     4    │ - ····"https":·{
     5    │ - ······"commandName":·"Project",
     6    │ - ······"dotnetRunMessages":·true,
     7    │ - ······"launchBrowser":·true,
     8    │ - ······"applicationUrl":·"https://localhost:17212;http://localhost:15272",
     9    │ - ······"environmentVariables":·{
    10    │ - ········"ASPNETCORE_ENVIRONMENT":·"Development",
    11    │ - ········"DOTNET_ENVIRONMENT":·"Development",
    12    │ - ········"ASPIRE_DASHBOARD_OTLP_ENDPOINT_URL":·"https://localhost:21070",
    13    │ - ········"ASPIRE_RESOURCE_SERVICE_ENDPOINT_URL":·"https://localhost:22202"
    14    │ - ······}
    15    │ - ····},
    16    │ - ····"http":·{
    17    │ - ······"commandName":·"Project",
    18    │ - ······"dotnetRunMessages":·true,
    19    │ - ······"launchBrowser":·true,
    20    │ - ······"applicationUrl":·"http://localhost:15272",
    21    │ - ······"environmentVariables":·{
    22    │ - ········"ASPNETCORE_ENVIRONMENT":·"Development",
    23    │ - ········"DOTNET_ENVIRONMENT":·"Development",
    24    │ - ········"ASPIRE_DASHBOARD_OTLP_ENDPOINT_URL":·"http://localhost:19016",
    25    │ - ········"ASPIRE_RESOURCE_SERVICE_ENDPOINT_URL":·"http://localhost:20142"
    26    │ - ······}
    27    │ - ····}
    28    │ - ··}
        2 │ + → "$schema":·"https://json.schemastore.org/launchsettings.json",
        3 │ + → "profiles":·{
        4 │ + → → "https":·{
        5 │ + → → → "commandName":·"Project",
        6 │ + → → → "dotnetRunMessages":·true,
        7 │ + → → → "launchBrowser":·true,
        8 │ + → → → "applicationUrl":·"https://localhost:17212;http://localhost:15272",
        9 │ + → → → "environmentVariables":·{
       10 │ + → → → → "ASPNETCORE_ENVIRONMENT":·"Development",
       11 │ + → → → → "DOTNET_ENVIRONMENT":·"Development",
       12 │ + → → → → "ASPIRE_DASHBOARD_OTLP_ENDPOINT_URL":·"https://localhost:21070",
       13 │ + → → → → "ASPIRE_RESOURCE_SERVICE_ENDPOINT_URL":·"https://localhost:22202"
       14 │ + → → → }
       15 │ + → → },
       16 │ + → → "http":·{
       17 │ + → → → "commandName":·"Project",
       18 │ + → → → "dotnetRunMessages":·true,
       19 │ + → → → "launchBrowser":·true,
       20 │ + → → → "applicationUrl":·"http://localhost:15272",
       21 │ + → → → "environmentVariables":·{
       22 │ + → → → → "ASPNETCORE_ENVIRONMENT":·"Development",
       23 │ + → → → → "DOTNET_ENVIRONMENT":·"Development",
       24 │ + → → → → "ASPIRE_DASHBOARD_OTLP_ENDPOINT_URL":·"http://localhost:19016",
       25 │ + → → → → "ASPIRE_RESOURCE_SERVICE_ENDPOINT_URL":·"http://localhost:20142"
       26 │ + → → → }
       27 │ + → → }
       28 │ + → }
    29 29 │   }
    30 30 │


FleetTracker.AppHost/appsettings.Development.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

    1 1 │   {
    2   │ - ··"Logging":·{
    3   │ - ····"LogLevel":·{
    4   │ - ······"Default":·"Information",
    5   │ - ······"Microsoft.AspNetCore":·"Warning"
    6   │ - ····}
    7   │ - ··}
      2 │ + → "Logging":·{
      3 │ + → → "LogLevel":·{
      4 │ + → → → "Default":·"Information",
      5 │ + → → → "Microsoft.AspNetCore":·"Warning"
      6 │ + → → }
      7 │ + → }
    8 8 │   }
    9 9 │


FleetTracker.AppHost/appsettings.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

     1  1 │   {
     2    │ - ··"Logging":·{
     3    │ - ····"LogLevel":·{
     4    │ - ······"Default":·"Information",
     5    │ - ······"Microsoft.Hosting.Lifetime":·"Information"
     6    │ - ····}
     7    │ - ··},
     8    │ - ··"ConnectionStrings":·{
     9    │ - ····"FleetTrackerDb":·"Server=(localdb)\\mssqllocaldb;Database=FleetTrackerDb;Trusted_Connection=True;MultipleActiveResultSets=true"
    10    │ - ··}
        2 │ + → "Logging":·{
        3 │ + → → "LogLevel":·{
        4 │ + → → → "Default":·"Information",
        5 │ + → → → "Microsoft.Hosting.Lifetime":·"Information"
        6 │ + → → }
        7 │ + → },
        8 │ + → "ConnectionStrings":·{
        9 │ + → → "FleetTrackerDb":·"Server=(localdb)\\mssqllocaldb;Database=FleetTrackerDb;Trusted_Connection=True;MultipleActiveResultSets=true"
       10 │ + → }
    11 11 │   }
    12 12 │


FleetTracker.AppHost/aspire.config.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

    1 1 │   {
    2   │ - ··"appHost":·{
    3   │ - ····"path":·"FleetTracker.AppHost.csproj"
    4   │ - ··}
      2 │ + → "appHost":·{
      3 │ + → → "path":·"FleetTracker.AppHost.csproj"
      4 │ + → }
    5 5 │   }
    6 6 │


FleetTracker.Services/FleetTracker.Services.Api/Properties/launchSettings.json format ━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

     1  1 │   �{
     2    │ - ··"$schema":·"https://json.schemastore.org/launchsettings.json",
     3    │ - ··"profiles":·{
     4    │ - ····"http":·{
     5    │ - ······"commandName":·"Project",
     6    │ - ······"dotnetRunMessages":·true,
     7    │ - ······"launchBrowser":·false,
     8    │ - ······"applicationUrl":·"http://localhost:5144",
     9    │ - ······"environmentVariables":·{
    10    │ - ········"ASPNETCORE_ENVIRONMENT":·"Development"
    11    │ - ······}
    12    │ - ····},
    13    │ - ····"https":·{
    14    │ - ······"commandName":·"Project",
    15    │ - ······"dotnetRunMessages":·true,
    16    │ - ······"launchBrowser":·false,
    17    │ - ······"applicationUrl":·"https://localhost:7108;http://localhost:5144",
    18    │ - ······"environmentVariables":·{
    19    │ - ········"ASPNETCORE_ENVIRONMENT":·"Development"
    20    │ - ······}
    21    │ - ····}
    22    │ - ··}
        2 │ + → "$schema":·"https://json.schemastore.org/launchsettings.json",
        3 │ + → "profiles":·{
        4 │ + → → "http":·{
        5 │ + → → → "commandName":·"Project",
        6 │ + → → → "dotnetRunMessages":·true,
        7 │ + → → → "launchBrowser":·false,
        8 │ + → → → "applicationUrl":·"http://localhost:5144",
        9 │ + → → → "environmentVariables":·{
       10 │ + → → → → "ASPNETCORE_ENVIRONMENT":·"Development"
       11 │ + → → → }
       12 │ + → → },
       13 │ + → → "https":·{
       14 │ + → → → "commandName":·"Project",
       15 │ + → → → "dotnetRunMessages":·true,
       16 │ + → → → "launchBrowser":·false,
       17 │ + → → → "applicationUrl":·"https://localhost:7108;http://localhost:5144",
       18 │ + → → → "environmentVariables":·{
       19 │ + → → → → "ASPNETCORE_ENVIRONMENT":·"Development"
       20 │ + → → → }
       21 │ + → → }
       22 │ + → }
    23 23 │   }
    24 24 │


FleetTracker.Services/FleetTracker.Services.Api/appsettings.Development.json format ━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

    1 1 │   {
    2   │ - ··"Logging":·{
    3   │ - ····"LogLevel":·{
    4   │ - ······"Default":·"Information",
    5   │ - ······"Microsoft.AspNetCore":·"Warning"
    6   │ - ····}
    7   │ - ··}
      2 │ + → "Logging":·{
      3 │ + → → "LogLevel":·{
      4 │ + → → → "Default":·"Information",
      5 │ + → → → "Microsoft.AspNetCore":·"Warning"
      6 │ + → → }
      7 │ + → }
    8 8 │   }
    9 9 │


FleetTracker.Services/FleetTracker.Services.Api/appsettings.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

     1  1 │   {
     2    │ - ··"Logging":·{
     3    │ - ····"LogLevel":·{
     4    │ - ······"Default":·"Information",
     5    │ - ······"Microsoft.AspNetCore":·"Warning"
     6    │ - ····}
     7    │ - ··},
     8    │ - ··"AllowedHosts":·"*",
     9    │ - ··"ConnectionStrings":·{
    10    │ - ····"FleetTrackerConnection":·"Server=(localdb)\\mssqllocaldb;Database=FleetTrackerDb;Trusted_Connection=True;MultipleActiveResultSets=true"
    11    │ - ··}
        2 │ + → "Logging":·{
        3 │ + → → "LogLevel":·{
        4 │ + → → → "Default":·"Information",
        5 │ + → → → "Microsoft.AspNetCore":·"Warning"
        6 │ + → → }
        7 │ + → },
        8 │ + → "AllowedHosts":·"*",
        9 │ + → "ConnectionStrings":·{
       10 │ + → → "FleetTrackerConnection":·"Server=(localdb)\\mssqllocaldb;Database=FleetTrackerDb;Trusted_Connection=True;MultipleActiveResultSets=true"
       11 │ + → }
    12 12 │   }
    13 13 │


format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Some errors were emitted while running checks.

```

</details>

<details>

<summary>CHECKOV</summary>

```text
github_actions scan results:

Passed checks: 43, Failed checks: 1, Skipped checks: 0

Check: CKV2_GHA_1: "Ensure top-level permissions are not set to write-all"
	FAILED for resource: on(CodeQL Advanced)
	File: /.github/workflows/codeql.yml:31-32
```

</details>

<details>

<summary>EDITORCONFIG</summary>

```text
[33;1mFleetTracker.Services/FleetTracker.Services.Data/FleetTrackerDbContext.cs:[33;0m
[31;1m	62-64: Wrong amount of left-padding spaces(want multiple of 4)[33;0m
[31;1m	79-81: Wrong amount of left-padding spaces(want multiple of 4)[33;0m
[33;1mFleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs:[33;0m
[31;1m	No final newline expected[33;0m
[31;1m	Not all lines have the correct end of line character[33;0m
[33;1mFleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs:[33;0m
[31;1m	No final newline expected[33;0m
[31;1m	Not all lines have the correct end of line character[33;0m
[33;1mFleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs:[33;0m
[31;1m	No final newline expected[33;0m
[31;1m	Not all lines have the correct end of line character[33;0m
[33;1mFleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs:[33;0m
[31;1m	No final newline expected[33;0m
[31;1m	Not all lines have the correct end of line character[33;0m
[31;1m
10 errors found[33;0m
```

</details>

<details>

<summary>JSCPD</summary>

```text
Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [19:17 - 382:2] (363 lines, 2282 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [16:11 - 379:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.cs [56:5 - 70:6] (14 lines, 101 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.cs [12:3 - 26:5]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs [1:2 - 15:39] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [1:2 - 15:42]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs [17:5 - 382:2] (365 lines, 2295 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [17:5 - 379:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [1:2 - 15:31] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [1:2 - 15:42]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [17:5 - 59:2] (42 lines, 266 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [17:5 - 56:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [59:5 - 80:2] (21 lines, 142 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [56:2 - 77:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [80:5 - 310:8] (230 lines, 1451 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [77:2 - 307:8]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [317:2 - 384:2] (67 lines, 397 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [312:8 - 379:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Core/DataModels/DataModels.cs [133:5 - 151:21] (18 lines, 193 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Core/DataModels/DataModels.cs [73:5 - 91:19]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [97:13 - 134:15] (37 lines, 369 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [53:13 - 90:16]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/VehicleManager.cs [363:37 - 372:9] (9 lines, 92 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/VehicleManager.cs [168:29 - 178:20]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [179:13 - 188:19] (9 lines, 89 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [127:13 - 137:4]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [120:27 - 130:21] (10 lines, 94 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [68:36 - 78:9]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [193:35 - 202:58] (9 lines, 96 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [68:36 - 78:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/RentalsController.cs [1:1 - 12:18] (11 lines, 96 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/VehiclesController.cs [1:1 - 12:19]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/CustomersController.cs [1:1 - 12:20] (11 lines, 96 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/VehiclesController.cs [1:1 - 12:19]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/CustomersController.cs [83:8 - 88:9] (5 lines, 133 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/CustomersController.cs [53:12 - 58:4]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/EfFleetRepository.cs [51:9 - 62:9] (11 lines, 101 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Repositories/InMemoryFleetRepository.cs [40:9 - 51:11]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/EfFleetRepository.cs [134:9 - 145:9] (11 lines, 102 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Repositories/InMemoryFleetRepository.cs [77:9 - 88:10]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/EfFleetRepository.cs [184:2 - 196:9] (12 lines, 111 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Repositories/InMemoryFleetRepository.cs [95:7 - 107:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [19:17 - 382:2] (363 lines, 2282 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [16:11 - 379:2]

 19  │ 16  │  BuildTargetModel(ModelBuilder modelBuilder)
 20  │ 17  │         {
 21  │ 18  │ #pragma warning disable 612, 618
 22  │ 19  │             modelBuilder
 23  │ 20  │                 .HasAnnotation("ProductVersion", "10.0.8")
 24  │ 21  │                 .HasAnnotation("Relational:MaxIdentifierLength", 128);
 25  │ 22  │
 26  │ 23  │             SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
 27  │ 24  │
 28  │ 25  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 29  │ 26  │                 {
 30  │ 27  │                     b.Property<Guid>("Id")
 31  │ 28  │                         .ValueGeneratedOnAdd()
 32  │ 29  │                         .HasColumnType("uniqueidentifier");
 33  │ 30  │
 34  │ 31  │                     b.Property<DateTime>("DateOfBirth")
 35  │ 32  │                         .HasColumnType("datetime2");
 36  │ 33  │
 37  │ 34  │                     b.Property<string>("DriversLicense")
 38  │ 35  │                         .IsRequired()
 39  │ 36  │                         .HasColumnType("nvarchar(max)");
 40  │ 37  │
 41  │ 38  │                     b.HasKey("Id");
 42  │ 39  │
 43  │ 40  │                     b.ToTable("Customers");
 44  │ 41  │                 });
 45  │ 42  │
 46  │ 43  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
 47  │ 44  │                 {
 48  │ 45  │                     b.Property<Guid>("Id")
 49  │ 46  │                         .ValueGeneratedOnAdd()
 50  │ 47  │                         .HasColumnType("uniqueidentifier");
 51  │ 48  │
 52  │ 49  │                     b.Property<DateTime?>("ActualReturnDate")
 53  │ 50  │                         .HasColumnType("datetime2");
 54  │ 51  │
 55  │ 52  │                     b.Property<string>("AgreementNumber")
 56  │ 53  │                         .IsRequired()
 57  │ 54  │                         .HasColumnType("nvarchar(450)");
 58  │ 55  │
 59  │ 56  │                     b.Property<Guid?>("CustomerId")
 60  │ 57  │                         .HasColumnType("uniqueidentifier");
 61  │ 58  │
 62  │ 59  │                     b.Property<int?>("EndingMileage")
 63  │ 60  │                         .HasColumnType("int");
 64  │ 61  │
 65  │ 62  │                     b.Property<DateTime>("ExpectedReturnDate")
 66  │ 63  │                         .HasColumnType("datetime2");
 67  │ 64  │
 68  │ 65  │                     b.Property<DateTime>("PickupDate")
 69  │ 66  │                         .HasColumnType("datetime2");
 70  │ 67  │
 71  │ 68  │                     b.Property<int>("StartingMileage")
 72  │ 69  │                         .HasColumnType("int");
 73  │ 70  │
 74  │ 71  │                     b.Property<int>("Status")
 75  │ 72  │                         .HasColumnType("int");
 76  │ 73  │
 77  │ 74  │                     b.Property<decimal?>("TotalCost")
 78  │ 75  │                         .HasColumnType("decimal(18,2)");
 79  │ 76  │
 80  │ 77  │                     b.Property<Guid?>("VehicleId")
 81  │ 78  │                         .HasColumnType("uniqueidentifier");
 82  │ 79  │
 83  │ 80  │                     b.HasKey("Id");
 84  │ 81  │
 85  │ 82  │                     b.HasIndex("AgreementNumber")
 86  │ 83  │                         .IsUnique();
 87  │ 84  │
 88  │ 85  │                     b.HasIndex("CustomerId");
 89  │ 86  │
 90  │ 87  │                     b.HasIndex("VehicleId");
 91  │ 88  │
 92  │ 89  │                     b.ToTable("RentalAgreements");
 93  │ 90  │                 });
 94  │ 91  │
 95  │ 92  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 96  │ 93  │                 {
 97  │ 94  │                     b.Property<Guid>("Id")
 98  │ 95  │                         .ValueGeneratedOnAdd()
 99  │ 96  │                         .HasColumnType("uniqueidentifier");
 100 │ 97  │
 101 │ 98  │                     b.Property<int>("Class")
 102 │ 99  │                         .HasColumnType("int");
 103 │ 100 │
 104 │ 101 │                     b.Property<decimal>("DailyRate")
 105 │ 102 │                         .HasColumnType("decimal(18,2)");
 106 │ 103 │
 107 │ 104 │                     b.Property<string>("LicensePlate")
 108 │ 105 │                         .IsRequired()
 109 │ 106 │                         .HasColumnType("nvarchar(max)");
 110 │ 107 │
 111 │ 108 │                     b.Property<string>("Make")
 112 │ 109 │                         .IsRequired()
 113 │ 110 │                         .HasColumnType("nvarchar(max)");
 114 │ 111 │
 115 │ 112 │                     b.Property<string>("Model")
 116 │ 113 │                         .IsRequired()
 117 │ 114 │                         .HasColumnType("nvarchar(max)");
 118 │ 115 │
 119 │ 116 │                     b.Property<int>("Status")
 120 │ 117 │                         .HasColumnType("int");
 121 │ 118 │
 122 │ 119 │                     b.Property<string>("VIN")
 123 │ 120 │                         .IsRequired()
 124 │ 121 │                         .HasColumnType("nvarchar(450)");
 125 │ 122 │
 126 │ 123 │                     b.Property<int>("Year")
 127 │ 124 │                         .HasColumnType("int");
 128 │ 125 │
 129 │ 126 │                     b.HasKey("Id");
 130 │ 127 │
 131 │ 128 │                     b.HasIndex("VIN")
 132 │ 129 │                         .IsUnique();
 133 │ 130 │
 134 │ 131 │                     b.ToTable("Vehicles");
 135 │ 132 │                 });
 136 │ 133 │
 137 │ 134 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 138 │ 135 │                 {
 139 │ 136 │                     b.OwnsOne("FleetTracker.Services.Core.Models.ContactInfo", "Contact", b1 =>
 140 │ 137 │                         {
 141 │ 138 │                             b1.Property<Guid>("CustomerId")
 142 │ 139 │                                 .HasColumnType("uniqueidentifier");
 143 │ 140 │
 144 │ 141 │                             b1.Property<string>("Email")
 145 │ 142 │                                 .IsRequired()
 146 │ 143 │                                 .HasColumnType("nvarchar(max)")
 147 │ 144 │                                 .HasColumnName("ContactEmail");
 148 │ 145 │
 149 │ 146 │                             b1.Property<string>("Name")
 150 │ 147 │                                 .IsRequired()
 151 │ 148 │                                 .HasColumnType("nvarchar(max)")
 152 │ 149 │                                 .HasColumnName("ContactName");
 153 │ 150 │
 154 │ 151 │                             b1.Property<string>("PhoneNumber")
 155 │ 152 │                                 .IsRequired()
 156 │ 153 │                                 .HasColumnType("nvarchar(max)")
 157 │ 154 │                                 .HasColumnName("ContactPhone");
 158 │ 155 │
 159 │ 156 │                             b1.HasKey("CustomerId");
 160 │ 157 │
 161 │ 158 │                             b1.ToTable("Customers");
 162 │ 159 │
 163 │ 160 │                             b1.WithOwner()
 164 │ 161 │                                 .HasForeignKey("CustomerId");
 165 │ 162 │                         });
 166 │ 163 │
 167 │ 164 │                     b.OwnsOne("FleetTracker.Services.Core.Models.Address", "HomeAddress", b1 =>
 168 │ 165 │                         {
 169 │ 166 │                             b1.Property<Guid>("CustomerId")
 170 │ 167 │                                 .HasColumnType("uniqueidentifier");
 171 │ 168 │
 172 │ 169 │                             b1.Property<string>("City")
 173 │ 170 │                                 .IsRequired()
 174 │ 171 │                                 .HasColumnType("nvarchar(max)")
 175 │ 172 │                                 .HasColumnName("HomeCity");
 176 │ 173 │
 177 │ 174 │                             b1.Property<string>("Country")
 178 │ 175 │                                 .IsRequired()
 179 │ 176 │                                 .HasColumnType("nvarchar(max)")
 180 │ 177 │                                 .HasColumnName("HomeCountry");
 181 │ 178 │
 182 │ 179 │                             b1.Property<string>("State")
 183 │ 180 │                                 .IsRequired()
 184 │ 181 │                                 .HasColumnType("nvarchar(max)")
 185 │ 182 │                                 .HasColumnName("HomeState");
 186 │ 183 │
 187 │ 184 │                             b1.Property<string>("Street")
 188 │ 185 │                                 .IsRequired()
 189 │ 186 │                                 .HasColumnType("nvarchar(max)")
 190 │ 187 │                                 .HasColumnName("HomeStreet");
 191 │ 188 │
 192 │ 189 │                             b1.Property<string>("Zip")
 193 │ 190 │                                 .IsRequired()
 194 │ 191 │                                 .HasColumnType("nvarchar(max)")
 195 │ 192 │                                 .HasColumnName("HomeZip");
 196 │ 193 │
 197 │ 194 │                             b1.HasKey("CustomerId");
 198 │ 195 │
 199 │ 196 │                             b1.ToTable("Customers");
 200 │ 197 │
 201 │ 198 │                             b1.WithOwner()
 202 │ 199 │                                 .HasForeignKey("CustomerId");
 203 │ 200 │                         });
 204 │ 201 │
 205 │ 202 │                     b.OwnsOne("FleetTracker.Services.Core.Models.PaymentInformation", "PaymentInformation", b1 =>
 206 │ 203 │                         {
 207 │ 204 │                             b1.Property<Guid>("CustomerId")
 208 │ 205 │                                 .HasColumnType("uniqueidentifier");
 209 │ 206 │
 210 │ 207 │                             b1.HasKey("CustomerId");
 211 │ 208 │
 212 │ 209 │                             b1.ToTable("Customers");
 213 │ 210 │
 214 │ 211 │                             b1.WithOwner()
 215 │ 212 │                                 .HasForeignKey("CustomerId");
 216 │ 213 │
 217 │ 214 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.CreditCard", "CreditCard", b2 =>
 218 │ 215 │                                 {
 219 │ 216 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 220 │ 217 │                                         .HasColumnType("uniqueidentifier");
 221 │ 218 │
 222 │ 219 │                                     b2.Property<string>("CardHolderName")
 223 │ 220 │                                         .IsRequired()
 224 │ 221 │                                         .HasColumnType("nvarchar(max)")
 225 │ 222 │                                         .HasColumnName("CreditCardHolder");
 226 │ 223 │
 227 │ 224 │                                     b2.Property<string>("CardNumber")
 228 │ 225 │                                         .IsRequired()
 229 │ 226 │                                         .HasColumnType("nvarchar(max)")
 230 │ 227 │                                         .HasColumnName("CreditCardNumber");
 231 │ 228 │
 232 │ 229 │                                     b2.Property<string>("Cvv")
 233 │ 230 │                                         .IsRequired()
 234 │ 231 │                                         .HasColumnType("nvarchar(max)")
 235 │ 232 │                                         .HasColumnName("CreditCardCvv");
 236 │ 233 │
 237 │ 234 │                                     b2.Property<string>("ExpirationDate")
 238 │ 235 │                                         .IsRequired()
 239 │ 236 │                                         .HasColumnType("nvarchar(max)")
 240 │ 237 │                                         .HasColumnName("CreditCardExpiration");
 241 │ 238 │
 242 │ 239 │                                     b2.HasKey("PaymentInformationCustomerId");
 243 │ 240 │
 244 │ 241 │                                     b2.ToTable("Customers");
 245 │ 242 │
 246 │ 243 │                                     b2.WithOwner()
 247 │ 244 │                                         .HasForeignKey("PaymentInformationCustomerId");
 248 │ 245 │                                 });
 249 │ 246 │
 250 │ 247 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.Address", "BillingAddress", b2 =>
 251 │ 248 │                                 {
 252 │ 249 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 253 │ 250 │                                         .HasColumnType("uniqueidentifier");
 254 │ 251 │
 255 │ 252 │                                     b2.Property<string>("City")
 256 │ 253 │                                         .IsRequired()
 257 │ 254 │                                         .HasColumnType("nvarchar(max)")
 258 │ 255 │                                         .HasColumnName("BillingCity");
 259 │ 256 │
 260 │ 257 │                                     b2.Property<string>("Country")
 261 │ 258 │                                         .IsRequired()
 262 │ 259 │                                         .HasColumnType("nvarchar(max)")
 263 │ 260 │                                         .HasColumnName("BillingCountry");
 264 │ 261 │
 265 │ 262 │                                     b2.Property<string>("State")
 266 │ 263 │                                         .IsRequired()
 267 │ 264 │                                         .HasColumnType("nvarchar(max)")
 268 │ 265 │                                         .HasColumnName("BillingState");
 269 │ 266 │
 270 │ 267 │                                     b2.Property<string>("Street")
 271 │ 268 │                                         .IsRequired()
 272 │ 269 │                                         .HasColumnType("nvarchar(max)")
 273 │ 270 │                                         .HasColumnName("BillingStreet");
 274 │ 271 │
 275 │ 272 │                                     b2.Property<string>("Zip")
 276 │ 273 │                                         .IsRequired()
 277 │ 274 │                                         .HasColumnType("nvarchar(max)")
 278 │ 275 │                                         .HasColumnName("BillingZip");
 279 │ 276 │
 280 │ 277 │                                     b2.HasKey("PaymentInformationCustomerId");
 281 │ 278 │
 282 │ 279 │                                     b2.ToTable("Customers");
 283 │ 280 │
 284 │ 281 │                                     b2.WithOwner()
 285 │ 282 │                                         .HasForeignKey("PaymentInformationCustomerId");
 286 │ 283 │                                 });
 287 │ 284 │
 288 │ 285 │                             b1.Navigation("BillingAddress")
 289 │ 286 │                                 .IsRequired();
 290 │ 287 │
 291 │ 288 │                             b1.Navigation("CreditCard")
 292 │ 289 │                                 .IsRequired();
 293 │ 290 │                         });
 294 │ 291 │
 295 │ 292 │                     b.Navigation("Contact")
 296 │ 293 │                         .IsRequired();
 297 │ 294 │
 298 │ 295 │                     b.Navigation("HomeAddress")
 299 │ 296 │                         .IsRequired();
 300 │ 297 │
 301 │ 298 │                     b.Navigation("PaymentInformation")
 302 │ 299 │                         .IsRequired();
 303 │ 300 │                 });
 304 │ 301 │
 305 │ 302 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
 306 │ 303 │                 {
 307 │ 304 │                     b.HasOne("FleetTracker.Services.Core.Models.Customer", "Customer")
 308 │ 305 │                         .WithMany("RentalHistory")
 309 │ 306 │                         .HasForeignKey("CustomerId")
 310 │ 307 │                         .OnDelete(DeleteBehavior.SetNull);
 311 │ 308 │
 312 │ 309 │                     b.HasOne("FleetTracker.Services.Core.Models.Vehicle", "Vehicle")
 313 │ 310 │                         .WithMany("RentalHistory")
 314 │ 311 │                         .HasForeignKey("VehicleId")
 315 │ 312 │                         .OnDelete(DeleteBehavior.SetNull);
 316 │ 313 │
 317 │ 314 │                     b.Navigation("Customer");
 318 │ 315 │
 319 │ 316 │                     b.Navigation("Vehicle");
 320 │ 317 │                 });
 321 │ 318 │
 322 │ 319 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 323 │ 320 │                 {
 324 │ 321 │                     b.OwnsMany("FleetTracker.Services.Core.Models.MaintenanceRecord", "MaintenanceHistory", b1 =>
 325 │ 322 │                         {
 326 │ 323 │                             b1.Property<Guid>("Id")
 327 │ 324 │                                 .ValueGeneratedOnAdd()
 328 │ 325 │                                 .HasColumnType("uniqueidentifier");
 329 │ 326 │
 330 │ 327 │                             b1.Property<decimal>("Cost")
 331 │ 328 │                                 .HasColumnType("decimal(18,2)");
 332 │ 329 │
 333 │ 330 │                             b1.Property<string>("Description")
 334 │ 331 │                                 .IsRequired()
 335 │ 332 │                                 .HasColumnType("nvarchar(max)");
 336 │ 333 │
 337 │ 334 │                             b1.Property<DateTime>("ServiceDate")
 338 │ 335 │                                 .HasColumnType("datetime2");
 339 │ 336 │
 340 │ 337 │                             b1.Property<int>("Type")
 341 │ 338 │                                 .HasColumnType("int");
 342 │ 339 │
 343 │ 340 │                             b1.Property<Guid>("VehicleId")
 344 │ 341 │                                 .HasColumnType("uniqueidentifier");
 345 │ 342 │
 346 │ 343 │                             b1.Property<Guid?>("VehicleId1")
 347 │ 344 │                                 .HasColumnType("uniqueidentifier");
 348 │ 345 │
 349 │ 346 │                             b1.HasKey("Id");
 350 │ 347 │
 351 │ 348 │                             b1.HasIndex("VehicleId");
 352 │ 349 │
 353 │ 350 │                             b1.HasIndex("VehicleId1");
 354 │ 351 │
 355 │ 352 │                             b1.ToTable("MaintenanceRecord");
 356 │ 353 │
 357 │ 354 │                             b1.WithOwner()
 358 │ 355 │                                 .HasForeignKey("VehicleId");
 359 │ 356 │
 360 │ 357 │                             b1.HasOne("FleetTracker.Services.Core.Models.Vehicle", "Vehicle")
 361 │ 358 │                                 .WithMany()
 362 │ 359 │                                 .HasForeignKey("VehicleId1");
 363 │ 360 │
 364 │ 361 │                             b1.Navigation("Vehicle");
 365 │ 362 │                         });
 366 │ 363 │
 367 │ 364 │                     b.Navigation("MaintenanceHistory");
 368 │ 365 │                 });
 369 │ 366 │
 370 │ 367 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 371 │ 368 │                 {
 372 │ 369 │                     b.Navigation("RentalHistory");
 373 │ 370 │                 });
 374 │ 371 │
 375 │ 372 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 376 │ 373 │                 {
 377 │ 374 │                     b.Navigation("Rental

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.cs [56:5 - 70:6] (14 lines, 101 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.cs [12:3 - 26:5]

 56 │ 12 │ verride void Down(MigrationBuilder migrationBuilder)

 57 │ 13 │         {

 58 │ 14 │             migrationBuilder.DropForeignKey(

 59 │ 15 │                 name: "FK_RentalAgreements_Customers_CustomerId",

 60 │ 16 │                 table: "RentalAgreements");

 61 │ 17 │

 62 │ 18 │             migrationBuilder.DropForeignKey(

 63 │ 19 │                 name: "FK_RentalAgreements_Vehicles_VehicleId",

 64 │ 20 │                 table: "RentalAgreements");

 65 │ 21 │

 66 │ 22 │             migrationBuilder.AlterColumn<Guid>(

 67 │ 23 │                 name: "VehicleId",

 68 │ 24 │                 table: "RentalAgreements",

 69 │ 25 │                 type: "uniqueidentifier",

 70 │ 26 │

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs [1:2 - 15:39] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [1:2 - 15:42]

 1  │ 1  │ // <auto-generated />
 2  │ 2  │ using System;
 3  │ 3  │ using FleetTracker.Services.Data;
 4  │ 4  │ using Microsoft.EntityFrameworkCore;
 5  │ 5  │ using Microsoft.EntityFrameworkCore.Infrastructure;
 6  │ 6  │ using Microsoft.EntityFrameworkCore.Metadata;
 7  │ 7  │ using Microsoft.EntityFrameworkCore.Migrations;
 8  │ 8  │ using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
 9  │ 9  │
 10 │ 10 │ #nullable disable
 11 │ 11 │
 12 │ 12 │ namespace FleetTracker.Services.Data.Migrations
 13 │ 13 │ {
 14 │ 14 │     [DbContext(typeof(FleetTrackerDbContext))]
 15 │ 15 │     [Migration("20260602151152_MakeR

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs [17:5 - 382:2] (365 lines, 2295 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [17:5 - 379:2]

 17  │ 17  │ lIdsNullable
 18  │ 18  │     {
 19  │ 19  │         /// <inheritdoc />
 20  │ 20  │         protected override void BuildTargetModel(ModelBuilder modelBuilder)
 21  │ 21  │         {
 22  │ 22  │ #pragma warning disable 612, 618
 23  │ 23  │             modelBuilder
 24  │ 24  │                 .HasAnnotation("ProductVersion", "10.0.8")
 25  │ 25  │                 .HasAnnotation("Relational:MaxIdentifierLength", 128);
 26  │ 26  │
 27  │ 27  │             SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
 28  │ 28  │
 29  │ 29  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 30  │ 30  │                 {
 31  │ 31  │                     b.Property<Guid>("Id")
 32  │ 32  │                         .ValueGeneratedOnAdd()
 33  │ 33  │                         .HasColumnType("uniqueidentifier");
 34  │ 34  │
 35  │ 35  │                     b.Property<DateTime>("DateOfBirth")
 36  │ 36  │                         .HasColumnType("datetime2");
 37  │ 37  │
 38  │ 38  │                     b.Property<string>("DriversLicense")
 39  │ 39  │                         .IsRequired()
 40  │ 40  │                         .HasColumnType("nvarchar(max)");
 41  │ 41  │
 42  │ 42  │                     b.HasKey("Id");
 43  │ 43  │
 44  │ 44  │                     b.ToTable("Customers");
 45  │ 45  │                 });
 46  │ 46  │
 47  │ 47  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
 48  │ 48  │                 {
 49  │ 49  │                     b.Property<Guid>("Id")
 50  │ 50  │                         .ValueGeneratedOnAdd()
 51  │ 51  │                         .HasColumnType("uniqueidentifier");
 52  │ 52  │
 53  │ 53  │                     b.Property<DateTime?>("ActualReturnDate")
 54  │ 54  │                         .HasColumnType("datetime2");
 55  │ 55  │
 56  │ 56  │                     b.Property<string>("AgreementNumber")
 57  │ 57  │                         .IsRequired()
 58  │ 58  │                         .HasColumnType("nvarchar(450)");
 59  │ 59  │
 60  │ 60  │                     b.Property<Guid?>("CustomerId")
 61  │ 61  │                         .HasColumnType("uniqueidentifier");
 62  │ 62  │
 63  │ 63  │                     b.Property<int?>("EndingMileage")
 64  │ 64  │                         .HasColumnType("int");
 65  │ 65  │
 66  │ 66  │                     b.Property<DateTime>("ExpectedReturnDate")
 67  │ 67  │                         .HasColumnType("datetime2");
 68  │ 68  │
 69  │ 69  │                     b.Property<DateTime>("PickupDate")
 70  │ 70  │                         .HasColumnType("datetime2");
 71  │ 71  │
 72  │ 72  │                     b.Property<int>("StartingMileage")
 73  │ 73  │                         .HasColumnType("int");
 74  │ 74  │
 75  │ 75  │                     b.Property<int>("Status")
 76  │ 76  │                         .HasColumnType("int");
 77  │ 77  │
 78  │ 78  │                     b.Property<decimal?>("TotalCost")
 79  │ 79  │                         .HasColumnType("decimal(18,2)");
 80  │ 80  │
 81  │ 81  │                     b.Property<Guid?>("VehicleId")
 82  │ 82  │                         .HasColumnType("uniqueidentifier");
 83  │ 83  │
 84  │ 84  │                     b.HasKey("Id");
 85  │ 85  │
 86  │ 86  │                     b.HasIndex("AgreementNumber")
 87  │ 87  │                         .IsUnique();
 88  │ 88  │
 89  │ 89  │                     b.HasIndex("CustomerId");
 90  │ 90  │
 91  │ 91  │                     b.HasIndex("VehicleId");
 92  │ 92  │
 93  │ 93  │                     b.ToTable("RentalAgreements");
 94  │ 94  │                 });
 95  │ 95  │
 96  │ 96  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 97  │ 97  │                 {
 98  │ 98  │                     b.Property<Guid>("Id")
 99  │ 99  │                         .ValueGeneratedOnAdd()
 100 │ 100 │                         .HasColumnType("uniqueidentifier");
 101 │ 101 │
 102 │ 102 │                     b.Property<int>("Class")
 103 │ 103 │                         .HasColumnType("int");
 104 │ 104 │
 105 │ 105 │                     b.Property<decimal>("DailyRate")
 106 │ 106 │                         .HasColumnType("decimal(18,2)");
 107 │ 107 │
 108 │ 108 │                     b.Property<string>("LicensePlate")
 109 │ 109 │                         .IsRequired()
 110 │ 110 │                         .HasColumnType("nvarchar(max)");
 111 │ 111 │
 112 │ 112 │                     b.Property<string>("Make")
 113 │ 113 │                         .IsRequired()
 114 │ 114 │                         .HasColumnType("nvarchar(max)");
 115 │ 115 │
 116 │ 116 │                     b.Property<string>("Model")
 117 │ 117 │                         .IsRequired()
 118 │ 118 │                         .HasColumnType("nvarchar(max)");
 119 │ 119 │
 120 │ 120 │                     b.Property<int>("Status")
 121 │ 121 │                         .HasColumnType("int");
 122 │ 122 │
 123 │ 123 │                     b.Property<string>("VIN")
 124 │ 124 │                         .IsRequired()
 125 │ 125 │                         .HasColumnType("nvarchar(450)");
 126 │ 126 │
 127 │ 127 │                     b.Property<int>("Year")
 128 │ 128 │                         .HasColumnType("int");
 129 │ 129 │
 130 │ 130 │                     b.HasKey("Id");
 131 │ 131 │
 132 │ 132 │                     b.HasIndex("VIN")
 133 │ 133 │                         .IsUnique();
 134 │ 134 │
 135 │ 135 │                     b.ToTable("Vehicles");
 136 │ 136 │                 });
 137 │ 137 │
 138 │ 138 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 139 │ 139 │                 {
 140 │ 140 │                     b.OwnsOne("FleetTracker.Services.Core.Models.ContactInfo", "Contact", b1 =>
 141 │ 141 │                         {
 142 │ 142 │                             b1.Property<Guid>("CustomerId")
 143 │ 143 │                                 .HasColumnType("uniqueidentifier");
 144 │ 144 │
 145 │ 145 │                             b1.Property<string>("Email")
 146 │ 146 │                                 .IsRequired()
 147 │ 147 │                                 .HasColumnType("nvarchar(max)")
 148 │ 148 │                                 .HasColumnName("ContactEmail");
 149 │ 149 │
 150 │ 150 │                             b1.Property<string>("Name")
 151 │ 151 │                                 .IsRequired()
 152 │ 152 │                                 .HasColumnType("nvarchar(max)")
 153 │ 153 │                                 .HasColumnName("ContactName");
 154 │ 154 │
 155 │ 155 │                             b1.Property<string>("PhoneNumber")
 156 │ 156 │                                 .IsRequired()
 157 │ 157 │                                 .HasColumnType("nvarchar(max)")
 158 │ 158 │                                 .HasColumnName("ContactPhone");
 159 │ 159 │
 160 │ 160 │                             b1.HasKey("CustomerId");
 161 │ 161 │
 162 │ 162 │                             b1.ToTable("Customers");
 163 │ 163 │
 164 │ 164 │                             b1.WithOwner()
 165 │ 165 │                                 .HasForeignKey("CustomerId");
 166 │ 166 │                         });
 167 │ 167 │
 168 │ 168 │                     b.OwnsOne("FleetTracker.Services.Core.Models.Address", "HomeAddress", b1 =>
 169 │ 169 │                         {
 170 │ 170 │                             b1.Property<Guid>("CustomerId")
 171 │ 171 │                                 .HasColumnType("uniqueidentifier");
 172 │ 172 │
 173 │ 173 │                             b1.Property<string>("City")
 174 │ 174 │                                 .IsRequired()
 175 │ 175 │                                 .HasColumnType("nvarchar(max)")
 176 │ 176 │                                 .HasColumnName("HomeCity");
 177 │ 177 │
 178 │ 178 │                             b1.Property<string>("Country")
 179 │ 179 │                                 .IsRequired()
 180 │ 180 │                                 .HasColumnType("nvarchar(max)")
 181 │ 181 │                                 .HasColumnName("HomeCountry");
 182 │ 182 │
 183 │ 183 │                             b1.Property<string>("State")
 184 │ 184 │                                 .IsRequired()
 185 │ 185 │                                 .HasColumnType("nvarchar(max)")
 186 │ 186 │                                 .HasColumnName("HomeState");
 187 │ 187 │
 188 │ 188 │                             b1.Property<string>("Street")
 189 │ 189 │                                 .IsRequired()
 190 │ 190 │                                 .HasColumnType("nvarchar(max)")
 191 │ 191 │                                 .HasColumnName("HomeStreet");
 192 │ 192 │
 193 │ 193 │                             b1.Property<string>("Zip")
 194 │ 194 │                                 .IsRequired()
 195 │ 195 │                                 .HasColumnType("nvarchar(max)")
 196 │ 196 │                                 .HasColumnName("HomeZip");
 197 │ 197 │
 198 │ 198 │                             b1.HasKey("CustomerId");
 199 │ 199 │
 200 │ 200 │                             b1.ToTable("Customers");
 201 │ 201 │
 202 │ 202 │                             b1.WithOwner()
 203 │ 203 │                                 .HasForeignKey("CustomerId");
 204 │ 204 │                         });
 205 │ 205 │
 206 │ 206 │                     b.OwnsOne("FleetTracker.Services.Core.Models.PaymentInformation", "PaymentInformation", b1 =>
 207 │ 207 │                         {
 208 │ 208 │                             b1.Property<Guid>("CustomerId")
 209 │ 209 │                                 .HasColumnType("uniqueidentifier");
 210 │ 210 │
 211 │ 211 │                             b1.HasKey("CustomerId");
 212 │ 212 │
 213 │ 213 │                             b1.ToTable("Customers");
 214 │ 214 │
 215 │ 215 │                             b1.WithOwner()
 216 │ 216 │                                 .HasForeignKey("CustomerId");
 217 │ 217 │
 218 │ 218 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.CreditCard", "CreditCard", b2 =>
 219 │ 219 │                                 {
 220 │ 220 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 221 │ 221 │                                         .HasColumnType("uniqueidentifier");
 222 │ 222 │
 223 │ 223 │                                     b2.Property<string>("CardHolderName")
 224 │ 224 │                                         .IsRequired()
 225 │ 225 │                                         .HasColumnType("nvarchar(max)")
 226 │ 226 │                                         .HasColumnName("CreditCardHolder");
 227 │ 227 │
 228 │ 228 │                                     b2.Property<string>("CardNumber")
 229 │ 229 │                                         .IsRequired()
 230 │ 230 │                                         .HasColumnType("nvarchar(max)")
 231 │ 231 │                                         .HasColumnName("CreditCardNumber");
 232 │ 232 │
 233 │ 233 │                                     b2.Property<string>("Cvv")
 234 │ 234 │                                         .IsRequired()
 235 │ 235 │                                         .HasColumnType("nvarchar(max)")
 236 │ 236 │                                         .HasColumnName("CreditCardCvv");
 237 │ 237 │
 238 │ 238 │                                     b2.Property<string>("ExpirationDate")
 239 │ 239 │                                         .IsRequired()
 240 │ 240 │                                         .HasColumnType("nvarchar(max)")
 241 │ 241 │                                         .HasColumnName("CreditCardExpiration");
 242 │ 242 │
 243 │ 243 │                                     b2.HasKey("PaymentInformationCustomerId");
 244 │ 244 │
 245 │ 245 │                                     b2.ToTable("Customers");
 246 │ 246 │
 247 │ 247 │                                     b2.WithOwner()
 248 │ 248 │                                         .HasForeignKey("PaymentInformationCustomerId");
 249 │ 249 │                                 });
 250 │ 250 │
 251 │ 251 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.Address", "BillingAddress", b2 =>
 252 │ 252 │                                 {
 253 │ 253 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 254 │ 254 │                                         .HasColumnType("uniqueidentifier");
 255 │ 255 │
 256 │ 256 │                                     b2.Property<string>("City")
 257 │ 257 │                                         .IsRequired()
 258 │ 258 │                                         .HasColumnType("nvarchar(max)")
 259 │ 259 │                                         .HasColumnName("BillingCity");
 260 │ 260 │
 261 │ 261 │                                     b2.Property<string>("Country")
 262 │ 262 │                                         .IsRequired()
 263 │ 263 │                                         .HasColumnType("nvarchar(max)")
 264 │ 264 │                                         .HasColumnName("BillingCountry");
 265 │ 265 │
 266 │ 266 │                                     b2.Property<string>("State")
 267 │ 267 │                                         .IsRequired()
 268 │ 268 │                                         .HasColumnType("nvarchar(max)")
 269 │ 269 │                                         .HasColumnName("BillingState");
 270 │ 270 │
 271 │ 271 │                                     b2.Property<string>("Street")
 272 │ 272 │                                         .IsRequired()
 273 │ 273 │                                         .HasColumnType("nvarchar(max)")
 274 │ 274 │                                         .HasColumnName("BillingStreet");
 275 │ 275 │
 276 │ 276 │                                     b2.Property<string>("Zip")
 277 │ 277 │                                         .IsRequired()
 278 │ 278 │                                         .HasColumnType("nvarchar(max)")
 279 │ 279 │                                         .HasColumnName("BillingZip");
 280 │ 280 │
 281 │ 281 │                                     b2.HasKey("PaymentInformationCustomerId");
 282 │ 282 │
 283 │ 283 │                                     b2.ToTable("Customers");
 284 │ 284 │
 285 │ 285 │                                     b2.WithOwner()
 286 │ 286 │                                         .HasForeignKey("PaymentInformationCustomerId");
 287 │ 287 │                                 });
 288 │ 288 │
 289 │ 289 │                             b1.Navigation("BillingAddress")
 290 │ 290 │                                 .IsRequired();
 291 │ 291 │
 292 │ 292 │                             b1.Navigation("CreditCard")
 293 │ 293 │                                 .IsRequired();
 294 │ 294 │                         });
 295 │ 295 │
 296 │ 296 │                     b.Navigation("Contact")
 297 │ 297 │                         .IsRequired();
 298 │ 298 │
 299 │ 299 │                     b.Navigation("HomeAddress")
 300 │ 300 │                         .IsRequired();
 301 │ 301 │
 302 │ 302 │                     b.Navigation("PaymentInformation")
 303 │ 303 │                         .IsRequired();
 304 │ 304 │                 });
 305 │ 305 │
 306 │ 306 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
 307 │ 307 │                 {
 308 │ 308 │                     b.HasOne("FleetTracker.Services.Core.Models.Customer", "Customer")
 309 │ 309 │                         .WithMany("RentalHistory")
 310 │ 310 │                         .HasForeignKey("CustomerId")
 311 │ 311 │                         .OnDelete(DeleteBehavior.SetNull);
 312 │ 312 │
 313 │ 313 │                     b.HasOne("FleetTracker.Services.Core.Models.Vehicle", "Vehicle")
 314 │ 314 │                         .WithMany("RentalHistory")
 315 │ 315 │                         .HasForeignKey("VehicleId")
 316 │ 316 │                         .OnDelete(DeleteBehavior.SetNull);
 317 │ 317 │
 318 │ 318 │                     b.Navigation("Customer");
 319 │ 319 │
 320 │ 320 │                     b.Navigation("Vehicle");
 321 │ 321 │                 });
 322 │ 322 │
 323 │ 323 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 324 │ 324 │                 {
 325 │ 325 │                     b.OwnsMany("FleetTracker.Services.Core.Models.MaintenanceRecord", "MaintenanceHistory", b1 =>
 326 │ 326 │                         {
 327 │ 327 │                             b1.Property<Guid>("Id")
 328 │ 328 │                                 .ValueGeneratedOnAdd()
 329 │ 329 │                                 .HasColumnType("uniqueidentifier");
 330 │ 330 │
 331 │ 331 │                             b1.Property<decimal>("Cost")
 332 │ 332 │                                 .HasColumnType("decimal(18,2)");
 333 │ 333 │
 334 │ 334 │                             b1.Property<string>("Description")
 335 │ 335 │                                 .IsRequired()
 336 │ 336 │                                 .HasColumnType("nvarchar(max)");
 337 │ 337 │
 338 │ 338 │                             b1.Property<DateTime>("ServiceDate")
 339 │ 339 │                                 .HasColumnType("datetime2");
 340 │ 340 │
 341 │ 341 │                             b1.Property<int>("Type")
 342 │ 342 │                                 .HasColumnType("int");
 343 │ 343 │
 344 │ 344 │                             b1.Property<Guid>("VehicleId")
 345 │ 345 │                                 .HasColumnType("uniqueidentifier");
 346 │ 346 │
 347 │ 347 │                             b1.Property<Guid?>("VehicleId1")
 348 │ 348 │                                 .HasColumnType("uniqueidentifier");
 349 │ 349 │
 350 │ 350 │                             b1.HasKey("Id");
 351 │ 351 │
 352 │ 352 │                             b1.HasIndex("VehicleId");
 353 │ 353 │
 354 │ 354 │                             b1.HasIndex("VehicleId1");
 355 │ 355 │
 356 │ 356 │                             b1.ToTable("MaintenanceRecord");
 357 │ 357 │
 358 │ 358 │                             b1.WithOwner()
 359 │ 359 │                                 .HasForeignKey("VehicleId");
 360 │ 360 │
 361 │ 361 │                             b1.HasOne("FleetTracker.Services.Core.Models.Vehicle", "Vehicle")
 362 │ 362 │                                 .WithMany()
 363 │ 363 │                                 .HasForeignKey("VehicleId1");
 364 │ 364 │
 365 │ 365 │                             b1.Navigation("Vehicle");
 366 │ 366 │                         });
 367 │ 367 │
 368 │ 368 │                     b.Navigation("MaintenanceHistory");
 369 │ 369 │                 });
 370 │ 370 │
 371 │ 371 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 372 │ 372 │                 {
 373 │ 373 │                     b.Navigation("RentalHistory");
 374 │ 374 │                 });
 375 │ 375 │
 376 │ 376 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 377 │ 377 │                 {
 378 │ 378 │                     b.Navigation("Rental

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [1:2 - 15:31] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [1:2 - 15:42]

 1  │ 1  │ // <auto-generated />
 2  │ 2  │ using System;
 3  │ 3  │ using FleetTracker.Services.Data;
 4  │ 4  │ using Microsoft.EntityFrameworkCore;
 5  │ 5  │ using Microsoft.EntityFrameworkCore.Infrastructure;
 6  │ 6  │ using Microsoft.EntityFrameworkCore.Metadata;
 7  │ 7  │ using Microsoft.EntityFrameworkCore.Migrations;
 8  │ 8  │ using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
 9  │ 9  │
 10 │ 10 │ #nullable disable
 11 │ 11 │
 12 │ 12 │ namespace FleetTracker.Services.Data.Migrations
 13 │ 13 │ {
 14 │ 14 │     [DbContext(typeof(FleetTrackerDbContext))]
 15 │ 15 │     [Migration("202606011349

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [17:5 - 59:2] (42 lines, 266 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [17:5 - 56:2]

 17 │ 17 │ nitialCreate
 18 │ 18 │     {
 19 │ 19 │         /// <inheritdoc />
 20 │ 20 │         protected override void BuildTargetModel(ModelBuilder modelBuilder)
 21 │ 21 │         {
 22 │ 22 │ #pragma warning disable 612, 618
 23 │ 23 │             modelBuilder
 24 │ 24 │                 .HasAnnotation("ProductVersion", "10.0.8")
 25 │ 25 │                 .HasAnnotation("Relational:MaxIdentifierLength", 128);
 26 │ 26 │
 27 │ 27 │             SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
 28 │ 28 │
 29 │ 29 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 30 │ 30 │                 {
 31 │ 31 │                     b.Property<Guid>("Id")
 32 │ 32 │                         .ValueGeneratedOnAdd()
 33 │ 33 │                         .HasColumnType("uniqueidentifier");
 34 │ 34 │
 35 │ 35 │                     b.Property<DateTime>("DateOfBirth")
 36 │ 36 │                         .HasColumnType("datetime2");
 37 │ 37 │
 38 │ 38 │                     b.Property<string>("DriversLicense")
 39 │ 39 │                         .IsRequired()
 40 │ 40 │                         .HasColumnType("nvarchar(max)");
 41 │ 41 │
 42 │ 42 │                     b.HasKey("Id");
 43 │ 43 │
 44 │ 44 │                     b.ToTable("Customers");
 45 │ 45 │                 });
 46 │ 46 │
 47 │ 47 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
 48 │ 48 │                 {
 49 │ 49 │                     b.Property<Guid>("Id")
 50 │ 50 │                         .ValueGeneratedOnAdd()
 51 │ 51 │                         .HasColumnType("uniqueidentifier");
 52 │ 52 │
 53 │ 53 │                     b.Property<DateTime?>("ActualReturnDate")
 54 │ 54 │                         .HasColumnType("datetime2");
 55 │ 55 │
 56 │ 56 │                     b.Property<string>("AgreementNumber")
 57 │ 57 │                         .IsRequired()
 58 │ 58 │                         .HasColumnType("nvarc

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [59:5 - 80:2] (21 lines, 142 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [56:2 - 77:2]

 59 │ 56 │ char(450)");
 60 │ 57 │
 61 │ 58 │                     b.Property<Guid>("CustomerId")
 62 │ 59 │                         .HasColumnType("uniqueidentifier");
 63 │ 60 │
 64 │ 61 │                     b.Property<int?>("EndingMileage")
 65 │ 62 │                         .HasColumnType("int");
 66 │ 63 │
 67 │ 64 │                     b.Property<DateTime>("ExpectedReturnDate")
 68 │ 65 │                         .HasColumnType("datetime2");
 69 │ 66 │
 70 │ 67 │                     b.Property<DateTime>("PickupDate")
 71 │ 68 │                         .HasColumnType("datetime2");
 72 │ 69 │
 73 │ 70 │                     b.Property<int>("StartingMileage")
 74 │ 71 │                         .HasColumnType("int");
 75 │ 72 │
 76 │ 73 │                     b.Property<int>("Status")
 77 │ 74 │                         .HasColumnType("int");
 78 │ 75 │
 79 │ 76 │                     b.Property<decimal?>("TotalCost")
 80 │ 77 │                         .HasColumnType("decim

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [80:5 - 310:8] (230 lines, 1451 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [77:2 - 307:8]

 80  │ 77  │ mal(18,2)");
 81  │ 78  │
 82  │ 79  │                     b.Property<Guid>("VehicleId")
 83  │ 80  │                         .HasColumnType("uniqueidentifier");
 84  │ 81  │
 85  │ 82  │                     b.HasKey("Id");
 86  │ 83  │
 87  │ 84  │                     b.HasIndex("AgreementNumber")
 88  │ 85  │                         .IsUnique();
 89  │ 86  │
 90  │ 87  │                     b.HasIndex("CustomerId");
 91  │ 88  │
 92  │ 89  │                     b.HasIndex("VehicleId");
 93  │ 90  │
 94  │ 91  │                     b.ToTable("RentalAgreements");
 95  │ 92  │                 });
 96  │ 93  │
 97  │ 94  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 98  │ 95  │                 {
 99  │ 96  │                     b.Property<Guid>("Id")
 100 │ 97  │                         .ValueGeneratedOnAdd()
 101 │ 98  │                         .HasColumnType("uniqueidentifier");
 102 │ 99  │
 103 │ 100 │                     b.Property<int>("Class")
 104 │ 101 │                         .HasColumnType("int");
 105 │ 102 │
 106 │ 103 │                     b.Property<decimal>("DailyRate")
 107 │ 104 │                         .HasColumnType("decimal(18,2)");
 108 │ 105 │
 109 │ 106 │                     b.Property<string>("LicensePlate")
 110 │ 107 │                         .IsRequired()
 111 │ 108 │                         .HasColumnType("nvarchar(max)");
 112 │ 109 │
 113 │ 110 │                     b.Property<string>("Make")
 114 │ 111 │                         .IsRequired()
 115 │ 112 │                         .HasColumnType("nvarchar(max)");
 116 │ 113 │
 117 │ 114 │                     b.Property<string>("Model")
 118 │ 115 │                         .IsRequired()
 119 │ 116 │                         .HasColumnType("nvarchar(max)");
 120 │ 117 │
 121 │ 118 │                     b.Property<int>("Status")
 122 │ 119 │                         .HasColumnType("int");
 123 │ 120 │
 124 │ 121 │                     b.Property<string>("VIN")
 125 │ 122 │                         .IsRequired()
 126 │ 123 │                         .HasColumnType("nvarchar(450)");
 127 │ 124 │
 128 │ 125 │                     b.Property<int>("Year")
 129 │ 126 │                         .HasColumnType("int");
 130 │ 127 │
 131 │ 128 │                     b.HasKey("Id");
 132 │ 129 │
 133 │ 130 │                     b.HasIndex("VIN")
 134 │ 131 │                         .IsUnique();
 135 │ 132 │
 136 │ 133 │                     b.ToTable("Vehicles");
 137 │ 134 │                 });
 138 │ 135 │
 139 │ 136 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 140 │ 137 │                 {
 141 │ 138 │                     b.OwnsOne("FleetTracker.Services.Core.Models.ContactInfo", "Contact", b1 =>
 142 │ 139 │                         {
 143 │ 140 │                             b1.Property<Guid>("CustomerId")
 144 │ 141 │                                 .HasColumnType("uniqueidentifier");
 145 │ 142 │
 146 │ 143 │                             b1.Property<string>("Email")
 147 │ 144 │                                 .IsRequired()
 148 │ 145 │                                 .HasColumnType("nvarchar(max)")
 149 │ 146 │                                 .HasColumnName("ContactEmail");
 150 │ 147 │
 151 │ 148 │                             b1.Property<string>("Name")
 152 │ 149 │                                 .IsRequired()
 153 │ 150 │                                 .HasColumnType("nvarchar(max)")
 154 │ 151 │                                 .HasColumnName("ContactName");
 155 │ 152 │
 156 │ 153 │                             b1.Property<string>("PhoneNumber")
 157 │ 154 │                                 .IsRequired()
 158 │ 155 │                                 .HasColumnType("nvarchar(max)")
 159 │ 156 │                                 .HasColumnName("ContactPhone");
 160 │ 157 │
 161 │ 158 │                             b1.HasKey("CustomerId");
 162 │ 159 │
 163 │ 160 │                             b1.ToTable("Customers");
 164 │ 161 │
 165 │ 162 │                             b1.WithOwner()
 166 │ 163 │                                 .HasForeignKey("CustomerId");
 167 │ 164 │                         });
 168 │ 165 │
 169 │ 166 │                     b.OwnsOne("FleetTracker.Services.Core.Models.Address", "HomeAddress", b1 =>
 170 │ 167 │                         {
 171 │ 168 │                             b1.Property<Guid>("CustomerId")
 172 │ 169 │                                 .HasColumnType("uniqueidentifier");
 173 │ 170 │
 174 │ 171 │                             b1.Property<string>("City")
 175 │ 172 │                                 .IsRequired()
 176 │ 173 │                                 .HasColumnType("nvarchar(max)")
 177 │ 174 │                                 .HasColumnName("HomeCity");
 178 │ 175 │
 179 │ 176 │                             b1.Property<string>("Country")
 180 │ 177 │                                 .IsRequired()
 181 │ 178 │                                 .HasColumnType("nvarchar(max)")
 182 │ 179 │                                 .HasColumnName("HomeCountry");
 183 │ 180 │
 184 │ 181 │                             b1.Property<string>("State")
 185 │ 182 │                                 .IsRequired()
 186 │ 183 │                                 .HasColumnType("nvarchar(max)")
 187 │ 184 │                                 .HasColumnName("HomeState");
 188 │ 185 │
 189 │ 186 │                             b1.Property<string>("Street")
 190 │ 187 │                                 .IsRequired()
 191 │ 188 │                                 .HasColumnType("nvarchar(max)")
 192 │ 189 │                                 .HasColumnName("HomeStreet");
 193 │ 190 │
 194 │ 191 │                             b1.Property<string>("Zip")
 195 │ 192 │                                 .IsRequired()
 196 │ 193 │                                 .HasColumnType("nvarchar(max)")
 197 │ 194 │                                 .HasColumnName("HomeZip");
 198 │ 195 │
 199 │ 196 │                             b1.HasKey("CustomerId");
 200 │ 197 │
 201 │ 198 │                             b1.ToTable("Customers");
 202 │ 199 │
 203 │ 200 │                             b1.WithOwner()
 204 │ 201 │                                 .HasForeignKey("CustomerId");
 205 │ 202 │                         });
 206 │ 203 │
 207 │ 204 │                     b.OwnsOne("FleetTracker.Services.Core.Models.PaymentInformation", "PaymentInformation", b1 =>
 208 │ 205 │                         {
 209 │ 206 │                             b1.Property<Guid>("CustomerId")
 210 │ 207 │                                 .HasColumnType("uniqueidentifier");
 211 │ 208 │
 212 │ 209 │                             b1.HasKey("CustomerId");
 213 │ 210 │
 214 │ 211 │                             b1.ToTable("Customers");
 215 │ 212 │
 216 │ 213 │                             b1.WithOwner()
 217 │ 214 │                                 .HasForeignKey("CustomerId");
 218 │ 215 │
 219 │ 216 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.CreditCard", "CreditCard", b2 =>
 220 │ 217 │                                 {
 221 │ 218 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 222 │ 219 │                                         .HasColumnType("uniqueidentifier");
 223 │ 220 │
 224 │ 221 │                                     b2.Property<string>("CardHolderName")
 225 │ 222 │                                         .IsRequired()
 226 │ 223 │                                         .HasColumnType("nvarchar(max)")
 227 │ 224 │                                         .HasColumnName("CreditCardHolder");
 228 │ 225 │
 229 │ 226 │                                     b2.Property<string>("CardNumber")
 230 │ 227 │                                         .IsRequired()
 231 │ 228 │                                         .HasColumnType("nvarchar(max)")
 232 │ 229 │                                         .HasColumnName("CreditCardNumber");
 233 │ 230 │
 234 │ 231 │                                     b2.Property<string>("Cvv")
 235 │ 232 │                                         .IsRequired()
 236 │ 233 │                                         .HasColumnType("nvarchar(max)")
 237 │ 234 │                                         .HasColumnName("CreditCardCvv");
 238 │ 235 │
 239 │ 236 │                                     b2.Property<string>("ExpirationDate")
 240 │ 237 │                                         .IsRequired()
 241 │ 238 │                                         .HasColumnType("nvarchar(max)")
 242 │ 239 │                                         .HasColumnName("CreditCardExpiration");
 243 │ 240 │
 244 │ 241 │                                     b2.HasKey("PaymentInformationCustomerId");
 245 │ 242 │
 246 │ 243 │                                     b2.ToTable("Customers");
 247 │ 244 │
 248 │ 245 │                                     b2.WithOwner()
 249 │ 246 │                                         .HasForeignKey("PaymentInformationCustomerId");
 250 │ 247 │                                 });
 251 │ 248 │
 252 │ 249 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.Address", "BillingAddress", b2 =>
 253 │ 250 │                                 {
 254 │ 251 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 255 │ 252 │                                         .HasColumnType("uniqueidentifier");
 256 │ 253 │
 257 │ 254 │                                     b2.Property<string>("City")
 258 │ 255 │                                         .IsRequired()
 259 │ 256 │                                         .HasColumnType("nvarchar(max)")
 260 │ 257 │                                         .HasColumnName("BillingCity");
 261 │ 258 │
 262 │ 259 │                                     b2.Property<string>("Country")
 263 │ 260 │                                         .IsRequired()
 264 │ 261 │                                         .HasColumnType("nvarchar(max)")
 265 │ 262 │                                         .HasColumnName("BillingCountry");
 266 │ 263 │
 267 │ 264 │                                     b2.Property<string>("State")
 268 │ 265 │                                         .IsRequired()
 269 │ 266 │                                         .HasColumnType("nvarchar(max)")
 270 │ 267 │                                         .HasColumnName("BillingState");
 271 │ 268 │
 272 │ 269 │                                     b2.Property<string>("Street")
 273 │ 270 │                                         .IsRequired()
 274 │ 271 │                                         .HasColumnType("nvarchar(max)")
 275 │ 272 │                                         .HasColumnName("BillingStreet");
 276 │ 273 │
 277 │ 274 │                                     b2.Property<string>("Zip")
 278 │ 275 │                                         .IsRequired()
 279 │ 276 │                                         .HasColumnType("nvarchar(max)")
 280 │ 277 │                                         .HasColumnName("BillingZip");
 281 │ 278 │
 282 │ 279 │                                     b2.HasKey("PaymentInformationCustomerId");
 283 │ 280 │
 284 │ 281 │                                     b2.ToTable("Customers");
 285 │ 282 │
 286 │ 283 │                                     b2.WithOwner()
 287 │ 284 │                                         .HasForeignKey("PaymentInformationCustomerId");
 288 │ 285 │                                 });
 289 │ 286 │
 290 │ 287 │                             b1.Navigation("BillingAddress")
 291 │ 288 │                                 .IsRequired();
 292 │ 289 │
 293 │ 290 │                             b1.Navigation("CreditCard")
 294 │ 291 │                                 .IsRequired();
 295 │ 292 │                         });
 296 │ 293 │
 297 │ 294 │                     b.Navigation("Contact")
 298 │ 295 │                         .IsRequired();
 299 │ 296 │
 300 │ 297 │                     b.Navigation("HomeAddress")
 301 │ 298 │                         .IsRequired();
 302 │ 299 │
 303 │ 300 │                     b.Navigation("PaymentInformation")
 304 │ 301 │                         .IsRequired();
 305 │ 302 │                 });
 306 │ 303 │
 307 │ 304 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
 308 │ 305 │                 {
 309 │ 306 │                     b.HasOne("FleetTracker.Services.Core.Models.Customer", "Customer")
 310 │ 307 │                         .WithMany("RentalHistory")
 311 │ 308 │                         .HasForeignKey("CustomerId")
 312 │ 309 │

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [317:2 - 384:2] (67 lines, 397 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [312:8 - 379:2]

 317 │ 312 │ ior.Cascade)
 318 │ 313 │                         .IsRequired();
 319 │ 314 │
 320 │ 315 │                     b.Navigation("Customer");
 321 │ 316 │
 322 │ 317 │                     b.Navigation("Vehicle");
 323 │ 318 │                 });
 324 │ 319 │
 325 │ 320 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 326 │ 321 │                 {
 327 │ 322 │                     b.OwnsMany("FleetTracker.Services.Core.Models.MaintenanceRecord", "MaintenanceHistory", b1 =>
 328 │ 323 │                         {
 329 │ 324 │                             b1.Property<Guid>("Id")
 330 │ 325 │                                 .ValueGeneratedOnAdd()
 331 │ 326 │                                 .HasColumnType("uniqueidentifier");
 332 │ 327 │
 333 │ 328 │                             b1.Property<decimal>("Cost")
 334 │ 329 │                                 .HasColumnType("decimal(18,2)");
 335 │ 330 │
 336 │ 331 │                             b1.Property<string>("Description")
 337 │ 332 │                                 .IsRequired()
 338 │ 333 │                                 .HasColumnType("nvarchar(max)");
 339 │ 334 │
 340 │ 335 │                             b1.Property<DateTime>("ServiceDate")
 341 │ 336 │                                 .HasColumnType("datetime2");
 342 │ 337 │
 343 │ 338 │                             b1.Property<int>("Type")
 344 │ 339 │                                 .HasColumnType("int");
 345 │ 340 │
 346 │ 341 │                             b1.Property<Guid>("VehicleId")
 347 │ 342 │                                 .HasColumnType("uniqueidentifier");
 348 │ 343 │
 349 │ 344 │                             b1.Property<Guid?>("VehicleId1")
 350 │ 345 │                                 .HasColumnType("uniqueidentifier");
 351 │ 346 │
 352 │ 347 │                             b1.HasKey("Id");
 353 │ 348 │
 354 │ 349 │                             b1.HasIndex("VehicleId");
 355 │ 350 │
 356 │ 351 │                             b1.HasIndex("VehicleId1");
 357 │ 352 │
 358 │ 353 │                             b1.ToTable("MaintenanceRecord");
 359 │ 354 │
 360 │ 355 │                             b1.WithOwner()
 361 │ 356 │                                 .HasForeignKey("VehicleId");
 362 │ 357 │
 363 │ 358 │                             b1.HasOne("FleetTracker.Services.Core.Models.Vehicle", "Vehicle")
 364 │ 359 │                                 .WithMany()
 365 │ 360 │                                 .HasForeignKey("VehicleId1");
 366 │ 361 │
 367 │ 362 │                             b1.Navigation("Vehicle");
 368 │ 363 │                         });
 369 │ 364 │
 370 │ 365 │                     b.Navigation("MaintenanceHistory");
 371 │ 366 │                 });
 372 │ 367 │
 373 │ 368 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 374 │ 369 │                 {
 375 │ 370 │                     b.Navigation("RentalHistory");
 376 │ 371 │                 });
 377 │ 372 │
 378 │ 373 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 379 │ 374 │                 {
 380 │ 375 │                     b.Navigation("Rental

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Core/DataModels/DataModels.cs [133:5 - 151:21] (18 lines, 193 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Core/DataModels/DataModels.cs [73:5 - 91:19]

 133 │ 73 │ {

 134 │ 74 │         [Required(ErrorMessage = "Input cannot be null or empty.")]

 135 │ 75 │         [RegularExpression(@"^[A-Z0-9\-]+$", ErrorMessage = "Drivers license contains invalid characters.")]

 136 │ 76 │         public string DriversLicense { get; set; } = string.Empty;

 137 │ 77 │

 138 │ 78 │         [Required]

 139 │ 79 │         public DateTime DateOfBirth { get; set; }

 140 │ 80 │

 141 │ 81 │         [Required]

 142 │ 82 │         public PaymentData PaymentInformation { get; set; } = new();

 143 │ 83 │

 144 │ 84 │         [Required]

 145 │ 85 │         public ContactData Contact { get; set; } = new();

 146 │ 86 │

 147 │ 87 │         [Required]

 148 │ 88 │         public AddressData HomeAddress { get; set; } = new();

 149 │ 89 │     }

 150 │ 90 │

 151 │ 91 │     public class CreateVehicleRequest

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [97:13 - 134:15] (37 lines, 369 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [53:13 - 90:16]

 97  │ 53 │ {

 98  │ 54 │                 DriversLicense = customer.DriversLicense,

 99  │ 55 │                 DateOfBirth = customer.DateOfBirth,

 100 │ 56 │                 Contact = new ContactData

 101 │ 57 │                 {

 102 │ 58 │                     Name = customer.Contact.Name,

 103 │ 59 │                     Email = customer.Contact.Email,

 104 │ 60 │                     PhoneNumber = customer.Contact.PhoneNumber

 105 │ 61 │                 },

 106 │ 62 │                 HomeAddress = new AddressData

 107 │ 63 │                 {

 108 │ 64 │                     Street = customer.HomeAddress.Street,

 109 │ 65 │                     City = customer.HomeAddress.City,

 110 │ 66 │                     State = customer.HomeAddress.State,

 111 │ 67 │                     Zip = customer.HomeAddress.Zip,

 112 │ 68 │                     Country = customer.HomeAddress.Country

 113 │ 69 │                 },

 114 │ 70 │                 PaymentInformation = new PaymentData

 115 │ 71 │                 {

 116 │ 72 │                     BillingAddress = new AddressData

 117 │ 73 │                     {

 118 │ 74 │                         Street = customer.PaymentInformation.BillingAddress.Street,

 119 │ 75 │                         City = customer.PaymentInformation.BillingAddress.City,

 120 │ 76 │                         State = customer.PaymentInformation.BillingAddress.State,

 121 │ 77 │                         Zip = customer.PaymentInformation.BillingAddress.Zip,

 122 │ 78 │                         Country = customer.PaymentInformation.BillingAddress.Country

 123 │ 79 │                     },

 124 │ 80 │                     CreditCard = new CreditCardData

 125 │ 81 │                     {

 126 │ 82 │                         CardNumber = customer.PaymentInformation.CreditCard.CardNumber,

 127 │ 83 │                         CardHolderName = customer.PaymentInformation.CreditCard.CardHolderName,

 128 │ 84 │                         ExpirationDate = customer.PaymentInformation.CreditCard.ExpirationDate,

 129 │ 85 │                         Cvv = customer.PaymentInformation.CreditCard.Cvv

 130 │ 86 │                     }

 131 │ 87 │                 }

 132 │ 88 │             };

 133 │ 89 │

 134 │ 90 │             var response = _httpClient.PutAsJsonAsync

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/VehicleManager.cs [363:37 - 372:9] (9 lines, 92 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/VehicleManager.cs [168:29 - 178:20]

 363 │ 168 │ );

 364 │ 169 │             var vehicle = _vehicleRepository.GetVehicleByVin(vin);

 365 │ 170 │             while (vehicle == null)

 366 │ 171 │             {

 367 │ 172 │                 vin = _console.PromptForInput("Vehicle not found. Try another VIN or type 'CANCEL' to go back: ");

 368 │ 173 │                 if (vin.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;

 369 │ 174 │                 vehicle = _vehicleRepository.GetVehicleByVin(vin);

 370 │ 175 │             }

 371 │ 176 │

 372 │ 177 │             _console

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [179:13 - 188:19] (9 lines, 89 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [127:13 - 137:4]

 179 │ 127 │ var activeRentals = _rentalRepository.GetAllRentals().Where(r => r.Status == RentalStatus.Active);

 180 │ 128 │             if (!activeRentals.Any())

 181 │ 129 │             {

 182 │ 130 │                 _console.WriteLine("No active rentals found.");

 183 │ 131 │                 return;

 184 │ 132 │             }

 185 │ 133 │

 186 │ 134 │             foreach (var r in activeRentals)

 187 │ 135 │             {

 188 │ 136 │                 PrintRentalDetails

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [120:27 - 130:21] (10 lines, 94 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [68:36 - 78:9]

 120 │ 68 │ );

 121 │ 69 │

 122 │ 70 │             var customer = _customerRepository.GetCustomerByLicense(license);

 123 │ 71 │             while (customer == null)

 124 │ 72 │             {

 125 │ 73 │                 license = _console.PromptForInput("Customer not found. Try another license or type 'CANCEL' to go back: ");

 126 │ 74 │                 if (license.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;

 127 │ 75 │                 customer = _customerRepository.GetCustomerByLicense(license);

 128 │ 76 │             }

 129 │ 77 │

 130 │ 78 │             PrintCustomerDetails

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [193:35 - 202:58] (9 lines, 96 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [68:36 - 78:2]

 193 │ 68 │ );

 194 │ 69 │             var customer = _customerRepository.GetCustomerByLicense(license);

 195 │ 70 │             while (customer == null)

 196 │ 71 │             {

 197 │ 72 │                 license = _console.PromptForInput("Customer not found. Try another license or type 'CANCEL' to go back: ");

 198 │ 73 │                 if (license.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;

 199 │ 74 │                 customer = _customerRepository.GetCustomerByLicense(license);

 200 │ 75 │             }

 201 │ 76 │

 202 │ 77 │             _console.WriteLine("Enter new values or press Enter to keep current values."

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/RentalsController.cs [1:1 - 12:18] (11 lines, 96 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/VehiclesController.cs [1:1 - 12:19]

 1  │ 1  │ using System;

 2  │ 2  │ using System.Linq;

 3  │ 3  │ using Microsoft.AspNetCore.Mvc;

 4  │ 4  │ using FleetTracker.Services.Core.Interfaces;

 5  │ 5  │ using FleetTracker.Services.Core.Models;

 6  │ 6  │ using FleetTracker.Services.Core.DataModels;

 7  │ 7  │

 8  │ 8  │ namespace FleetTracker.Services.Api.Controllers

 9  │ 9  │ {

 10 │ 10 │     [ApiController]

 11 │ 11 │     [Route("api/[controller]")]

 12 │ 12 │     public class RentalsController

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/CustomersController.cs [1:1 - 12:20] (11 lines, 96 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/VehiclesController.cs [1:1 - 12:19]

 1  │ 1  │ using System;

 2  │ 2  │ using System.Linq;

 3  │ 3  │ using Microsoft.AspNetCore.Mvc;

 4  │ 4  │ using FleetTracker.Services.Core.Interfaces;

 5  │ 5  │ using FleetTracker.Services.Core.Models;

 6  │ 6  │ using FleetTracker.Services.Core.DataModels;

 7  │ 7  │

 8  │ 8  │ namespace FleetTracker.Services.Api.Controllers

 9  │ 9  │ {

 10 │ 10 │     [ApiController]

 11 │ 11 │     [Route("api/[controller]")]

 12 │ 12 │     public class CustomersController

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/CustomersController.cs [83:8 - 88:9] (5 lines, 133 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/CustomersController.cs [53:12 - 58:4]

 83 │ 53 │ );

 84 │ 54 │

 85 │ 55 │             var billingAddress = new Address(request.PaymentInformation.BillingAddress.Street, request.PaymentInformation.BillingAddress.City, request.PaymentInformation.BillingAddress.State, request.PaymentInformation.BillingAddress.Zip, request.PaymentInformation.BillingAddress.Country);

 86 │ 56 │             var creditCard = new CreditCard(request.PaymentInformation.CreditCard.CardNumber, request.PaymentInformation.CreditCard.CardHolderName, request.PaymentInformation.CreditCard.ExpirationDate, request.PaymentInformation.CreditCard.Cvv);

 87 │ 57 │             var paymentInfo = new PaymentInformation(billingAddress, creditCard);

 88 │ 58 │             customer

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/EfFleetRepository.cs [51:9 - 62:9] (11 lines, 101 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Repositories/InMemoryFleetRepository.cs [40:9 - 51:11]

 51 │ 40 │ }

 52 │ 41 │

 53 │ 42 │         public void DeleteCustomer(Guid id)

 54 │ 43 │         {

 55 │ 44 │             var customer = GetCustomerById(id);

 56 │ 45 │             if (customer != null)

 57 │ 46 │             {

 58 │ 47 │                 if (customer.RentalHistory.Any(r => r.Status == RentalStatus.Active))

 59 │ 48 │                 {

 60 │ 49 │                     throw new InvalidOperationException("Cannot delete customer with active rentals. Complete the rental first.");

 61 │ 50 │                 }

 62 │ 51 │                 _context

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/EfFleetRepository.cs [134:9 - 145:9] (11 lines, 102 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Repositories/InMemoryFleetRepository.cs [77:9 - 88:10]

 134 │ 77 │ }

 135 │ 78 │

 136 │ 79 │         public void DeleteVehicle(Guid id)

 137 │ 80 │         {

 138 │ 81 │             var vehicle = GetVehicleById(id);

 139 │ 82 │             if (vehicle != null)

 140 │ 83 │             {

 141 │ 84 │                 if (vehicle.Status != VehicleStatus.Available && vehicle.Status != VehicleStatus.Unavailable)

 142 │ 85 │                 {

 143 │ 86 │                     throw new InvalidOperationException($"Cannot delete vehicle in status: {vehicle.Status}. Ensure the vehicle is Available or Unavailable first.");

 144 │ 87 │                 }

 145 │ 88 │                 _context

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/EfFleetRepository.cs [184:2 - 196:9] (12 lines, 111 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Repositories/InMemoryFleetRepository.cs [95:7 - 107:2]

 184 │ 95  │ ;

 185 │ 96  │         }

 186 │ 97  │

 187 │ 98  │         public void CompleteRental(Guid id, int endingMileage)

 188 │ 99  │         {

 189 │ 100 │             var rental = GetRentalById(id);

 190 │ 101 │             if (rental != null)

 191 │ 102 │             {

 192 │ 103 │                 var vehicle = GetVehicleById(rental.VehicleId.GetValueOrDefault());

 193 │ 104 │                 if (vehicle != null)

 194 │ 105 │                 {

 195 │ 106 │                     vehicle.CompleteRental(rental, endingMileage);

 196 │ 107 │                     _context

Found 21 clones.
Error: ERROR: jscpd found too many duplicates (22.74%) over threshold (0%)
    at ThresholdReporter.report (/node_modules/@jscpd/finder/dist/index.js:615:13)
    at /node_modules/@jscpd/finder/dist/index.js:109:18
    at Array.forEach (<anonymous>)
    at /node_modules/@jscpd/finder/dist/index.js:108:22
    at async /node_modules/jscpd/dist/bin/jscpd.js:9:5ERROR: jscpd found too many duplicates (22.74%) over threshold (0%)
```

</details>

<details>

<summary>MARKDOWN_PRETTIER</summary>

```text
Checking formatting...[[33mwarn[39m] README.md
[[33mwarn[39m] Code style issues found in the above file. Run Prettier with --write to fix.
```

</details>

<details>

<summary>SPELL_CODESPELL</summary>

```text
/github/workspace/.gitignore:22: elease ==> release
/github/workspace/.gitignore:23: eleases ==> releases
/github/workspace/.gitignore:183: ublish ==> publish
/github/workspace/.gitignore:185: checkin ==> checking, check in
/github/workspace/.gitignore:191: checkin ==> checking, check in
/github/workspace/.gitignore:305: Paket ==> Packet
/github/workspace/.gitignore:306: paket ==> packet
/github/workspace/.gitignore:306: paket ==> packet
/github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Services/InputValidator.cs:77: ND ==> AND, 2ND
/github/workspace/FleetTracker.Services/FleetTracker.Services.Core/DataModels/DataModels.cs:17: ND ==> AND, 2ND
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/FleetTrackerDbContext.cs:36: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs:185: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.cs:35: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs:185: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs:185: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs:182: HomeState ==> home state
```

</details>
