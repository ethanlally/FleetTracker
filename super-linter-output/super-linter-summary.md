# Super-linter summary

| Language                   | Validation result |
| -------------------------- | ----------------- |
| BIOME_FORMAT               | Fail ❌           |
| BIOME_LINT                 | Fail ❌           |
| CHECKOV                    | Fail ❌           |
| CSHARP                     | Pass ✅           |
| EDITORCONFIG               | Pass ✅           |
| GITLEAKS                   | Pass ✅           |
| GIT_MERGE_CONFLICT_MARKERS | Pass ✅           |
| JSCPD                      | Fail ❌           |
| PRE_COMMIT                 | Pass ✅           |
| SPELL_CODESPELL            | Pass ✅           |
| TRIVY                      | Fail ❌           |

All files and directories linted successfully

For more information, see the [GitHub Actions workflow run](https://github.com/ethanlally/FleetTracker/actions/runs/28025403440)

Powered by [Super-linter](https://github.com/super-linter/super-linter)

<details>

<summary>BIOME_FORMAT</summary>

```text
The number of diagnostics exceeds the limit allowed. Use --max-diagnostics to increase it.
Diagnostics not shown: 16.
Checked 36 files in 61ms. No fixes applied.
Found 36 errors.FleetTracker.AppHost/Properties/launchSettings.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

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


FleetTracker.Client/.vscode/extensions.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

    1 1 │   {
    2   │ - ··//·For·more·information,·visit:·https://go.microsoft.com/fwlink/?linkid=827846
    3   │ - ··"recommendations":·["angular.ng-template"]
      2 │ + → //·For·more·information,·visit:·https://go.microsoft.com/fwlink/?linkid=827846
      3 │ + → "recommendations":·["angular.ng-template"]
    4 4 │   }
    5 5 │


FleetTracker.Client/.vscode/launch.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

     1  1 │   {
     2    │ - ··//·For·more·information,·visit:·https://go.microsoft.com/fwlink/?linkid=830387
     3    │ - ··"version":·"0.2.0",
     4    │ - ··"configurations":·[
     5    │ - ····{
     6    │ - ······"name":·"ng·serve",
     7    │ - ······"type":·"chrome",
     8    │ - ······"request":·"launch",
     9    │ - ······"preLaunchTask":·"npm:·start",
    10    │ - ······"url":·"http://localhost:4200/"
    11    │ - ····}
    12    │ - ··]
        2 │ + → //·For·more·information,·visit:·https://go.microsoft.com/fwlink/?linkid=830387
        3 │ + → "version":·"0.2.0",
        4 │ + → "configurations":·[
        5 │ + → → {
        6 │ + → → → "name":·"ng·serve",
        7 │ + → → → "type":·"chrome",
        8 │ + → → → "request":·"launch",
        9 │ + → → → "preLaunchTask":·"npm:·start",
       10 │ + → → → "url":·"http://localhost:4200/"
       11 │ + → → }
       12 │ + → ]
    13 13 │   }
    14 14 │


FleetTracker.Client/.vscode/mcp.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

     1  1 │   {
     2    │ - ··//·For·more·information,·visit:·https://angular.dev/ai/mcp
     3    │ - ··"servers":·{
     4    │ - ····"angular-cli":·{
     5    │ - ······"command":·"npx",
     6    │ - ······"args":·["-y",·"@angular/cli",·"mcp"]
     7    │ - ····}
     8    │ - ··}
        2 │ + → //·For·more·information,·visit:·https://angular.dev/ai/mcp
        3 │ + → "servers":·{
        4 │ + → → "angular-cli":·{
        5 │ + → → → "command":·"npx",
        6 │ + → → → "args":·["-y",·"@angular/cli",·"mcp"]
        7 │ + → → }
        8 │ + → }
     9  9 │   }
    10 10 │


FleetTracker.Client/.vscode/tasks.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

     1  1 │   {
     2    │ - ··//·For·more·information,·visit:·https://go.microsoft.com/fwlink/?LinkId=733558
     3    │ - ··"version":·"2.0.0",
     4    │ - ··"tasks":·[
     5    │ - ····{
     6    │ - ······"type":·"npm",
     7    │ - ······"script":·"start",
     8    │ - ······"isBackground":·true,
     9    │ - ······"problemMatcher":·{
    10    │ - ········"owner":·"typescript",
    11    │ - ········"pattern":·"$tsc",
    12    │ - ········"background":·{
    13    │ - ··········"activeOnStart":·true,
    14    │ - ··········"beginsPattern":·{
    15    │ - ············"regexp":·"Changes·detected"
    16    │ - ··········},
    17    │ - ··········"endsPattern":·{
    18    │ - ············"regexp":·"bundle·generation·(complete|failed)"
    19    │ - ··········}
    20    │ - ········}
    21    │ - ······}
    22    │ - ····}
    23    │ - ··]
        2 │ + → //·For·more·information,·visit:·https://go.microsoft.com/fwlink/?LinkId=733558
        3 │ + → "version":·"2.0.0",
        4 │ + → "tasks":·[
        5 │ + → → {
        6 │ + → → → "type":·"npm",
        7 │ + → → → "script":·"start",
        8 │ + → → → "isBackground":·true,
        9 │ + → → → "problemMatcher":·{
       10 │ + → → → → "owner":·"typescript",
       11 │ + → → → → "pattern":·"$tsc",
       12 │ + → → → → "background":·{
       13 │ + → → → → → "activeOnStart":·true,
       14 │ + → → → → → "beginsPattern":·{
       15 │ + → → → → → → "regexp":·"Changes·detected"
       16 │ + → → → → → },
       17 │ + → → → → → "endsPattern":·{
       18 │ + → → → → → → "regexp":·"bundle·generation·(complete|failed)"
       19 │ + → → → → → }
       20 │ + → → → → }
       21 │ + → → → }
       22 │ + → → }
       23 │ + → ]
    24 24 │   }
    25 25 │


FleetTracker.Client/angular.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

      1   1 │   {
      2     │ - ··"$schema":·"./node_modules/@angular/cli/lib/config/schema.json",
      3     │ - ··"version":·1,
      4     │ - ··"cli":·{
      5     │ - ····"packageManager":·"npm"
      6     │ - ··},
      7     │ - ··"newProjectRoot":·"projects",
      8     │ - ··"projects":·{
      9     │ - ····"FleetTracker.Client":·{
     10     │ - ······"projectType":·"application",
     11     │ - ······"schematics":·{
     12     │ - ········"@schematics/angular:component":·{
     13     │ - ··········"inlineTemplate":·true,
     14     │ - ··········"inlineStyle":·true,
     15     │ - ··········"skipTests":·true
     16     │ - ········},
     17     │ - ········"@schematics/angular:class":·{
     18     │ - ··········"skipTests":·true
     19     │ - ········},
     20     │ - ········"@schematics/angular:directive":·{
     21     │ - ··········"skipTests":·true
     22     │ - ········},
     23     │ - ········"@schematics/angular:guard":·{
     24     │ - ··········"skipTests":·true
     25     │ - ········},
     26     │ - ········"@schematics/angular:interceptor":·{
     27     │ - ··········"skipTests":·true
     28     │ - ········},
     29     │ - ········"@schematics/angular:pipe":·{
     30     │ - ··········"skipTests":·true
     31     │ - ········},
     32     │ - ········"@schematics/angular:resolver":·{
     33     │ - ··········"skipTests":·true
     34     │ - ········},
     35     │ - ········"@schematics/angular:service":·{
     36     │ - ··········"skipTests":·true
     37     │ - ········}
     38     │ - ······},
     39     │ - ······"root":·"",
     40     │ - ······"sourceRoot":·"src",
     41     │ - ······"prefix":·"app",
     42     │ - ······"architect":·{
     43     │ - ········"build":·{
     44     │ - ··········"builder":·"@angular/build:application",
     45     │ - ··········"options":·{
     46     │ - ············"browser":·"src/main.ts",
     47     │ - ············"index":·"src/index.html",
     48     │ - ············"polyfills":·[
     49     │ - ··············"zone.js"
     50     │ - ············],
     51     │ - ············"tsConfig":·"tsconfig.app.json",
     52     │ - ············"assets":·[
     53     │ - ··············{
     54     │ - ················"glob":·"**/*",
     55     │ - ················"input":·"public"
     56     │ - ··············}
     57     │ - ············],
     58     │ - ············"styles":·[
     59     │ - ··············"@angular/material/prebuilt-themes/indigo-pink.css",
     60     │ - ··············"src/styles.css"
     61     │ - ············]
     62     │ - ··········},
     63     │ - ··········"configurations":·{
     64     │ - ············"production":·{
     65     │ - ··············"budgets":·[
     66     │ - ················{
     67     │ - ··················"type":·"initial",
     68     │ - ··················"maximumWarning":·"500kB",
     69     │ - ··················"maximumError":·"1MB"
     70     │ - ················},
     71     │ - ················{
     72     │ - ··················"type":·"anyComponentStyle",
     73     │ - ··················"maximumWarning":·"4kB",
     74     │ - ··················"maximumError":·"8kB"
     75     │ - ················}
     76     │ - ··············],
     77     │ - ··············"outputHashing":·"all"
     78     │ - ············},
     79     │ - ············"development":·{
     80     │ - ··············"optimization":·false,
     81     │ - ··············"extractLicenses":·false,
     82     │ - ··············"sourceMap":·true
     83     │ - ············}
     84     │ - ··········},
     85     │ - ··········"defaultConfiguration":·"production"
     86     │ - ········},
     87     │ - ········"serve":·{
     88     │ - ··········"builder":·"@angular/build:dev-server",
     89     │ - ··········"configurations":·{
     90     │ - ············"production":·{
     91     │ - ··············"buildTarget":·"FleetTracker.Client:build:production"
     92     │ - ············},
     93     │ - ············"development":·{
     94     │ - ··············"buildTarget":·"FleetTracker.Client:build:development"
     95     │ - ············}
     96     │ - ··········},
     97     │ - ··········"options":·{
     98     │ - ············"proxyConfig":·"proxy.conf.js"
     99     │ - ··········},
    100     │ - ··········"defaultConfiguration":·"development"
    101     │ - ········}
    102     │ - ······}
    103     │ - ····}
    104     │ - ··}
          2 │ + → "$schema":·"./node_modules/@angular/cli/lib/config/schema.json",
          3 │ + → "version":·1,
          4 │ + → "cli":·{
          5 │ + → → "packageManager":·"npm"
          6 │ + → },
          7 │ + → "newProjectRoot":·"projects",
          8 │ + → "projects":·{
          9 │ + → → "FleetTracker.Client":·{
         10 │ + → → → "projectType":·"application",
         11 │ + → → → "schematics":·{
         12 │ + → → → → "@schematics/angular:component":·{
         13 │ + → → → → → "inlineTemplate":·true,
         14 │ + → → → → → "inlineStyle":·true,
         15 │ + → → → → → "skipTests":·true
         16 │ + → → → → },
         17 │ + → → → → "@schematics/angular:class":·{
         18 │ + → → → → → "skipTests":·true
         19 │ + → → → → },
         20 │ + → → → → "@schematics/angular:directive":·{
         21 │ + → → → → → "skipTests":·true
         22 │ + → → → → },
         23 │ + → → → → "@schematics/angular:guard":·{
         24 │ + → → → → → "skipTests":·true
         25 │ + → → → → },
         26 │ + → → → → "@schematics/angular:interceptor":·{
         27 │ + → → → → → "skipTests":·true
         28 │ + → → → → },
         29 │ + → → → → "@schematics/angular:pipe":·{
         30 │ + → → → → → "skipTests":·true
         31 │ + → → → → },
         32 │ + → → → → "@schematics/angular:resolver":·{
         33 │ + → → → → → "skipTests":·true
         34 │ + → → → → },
         35 │ + → → → → "@schematics/angular:service":·{
         36 │ + → → → → → "skipTests":·true
         37 │ + → → → → }
         38 │ + → → → },
         39 │ + → → → "root":·"",
         40 │ + → → → "sourceRoot":·"src",
         41 │ + → → → "prefix":·"app",
         42 │ + → → → "architect":·{
         43 │ + → → → → "build":·{
         44 │ + → → → → → "builder":·"@angular/build:application",
         45 │ + → → → → → "options":·{
         46 │ + → → → → → → "browser":·"src/main.ts",
         47 │ + → → → → → → "index":·"src/index.html",
  57 more lines truncated


FleetTracker.Client/package.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

     1  1 │   {
     2    │ - ··"name":·"fleet-tracker.client",
     3    │ - ··"version":·"0.0.0",
     4    │ - ··"scripts":·{
     5    │ - ····"ng":·"ng",
     6    │ - ····"start":·"ng·serve·--host·127.0.0.1·--open",
     7    │ - ····"build":·"ng·build",
     8    │ - ····"watch":·"ng·build·--watch·--configuration·development"
     9    │ - ··},
    10    │ - ··"private":·true,
    11    │ - ··"packageManager":·"npm@11.12.1",
    12    │ - ··"dependencies":·{
    13    │ - ····"@angular/animations":·"^21.2.16",
    14    │ - ····"@angular/cdk":·"^21.2.14",
    15    │ - ····"@angular/common":·"^21.2.0",
    16    │ - ····"@angular/compiler":·"^21.2.0",
    17    │ - ····"@angular/core":·"^21.2.0",
    18    │ - ····"@angular/forms":·"^21.2.0",
    19    │ - ····"@angular/material":·"^21.2.14",
    20    │ - ····"@angular/platform-browser":·"^21.2.0",
    21    │ - ····"@angular/platform-browser-dynamic":·"^21.2.16",
    22    │ - ····"@angular/router":·"^21.2.0",
    23    │ - ····"@ngrx/operators":·"^21.1.0",
    24    │ - ····"@ngrx/signals":·"^21.1.0",
    25    │ - ····"chart.js":·"^4.5.1",
    26    │ - ····"rxjs":·"~7.8.0",
    27    │ - ····"tslib":·"^2.3.0",
    28    │ - ····"zone.js":·"^0.16.2"
    29    │ - ··},
    30    │ - ··"devDependencies":·{
    31    │ - ····"@angular/build":·"^21.2.14",
    32    │ - ····"@angular/cli":·"^21.2.14",
    33    │ - ····"@angular/compiler-cli":·"^21.2.0",
    34    │ - ····"@types/node":·"^25.9.1",
    35    │ - ····"eslint":·"^10.4.1",
    36    │ - ····"prettier":·"^3.8.1",
    37    │ - ····"typescript":·"~5.9.2"
    38    │ - ··}
        2 │ + → "name":·"fleet-tracker.client",
        3 │ + → "version":·"0.0.0",
        4 │ + → "scripts":·{
        5 │ + → → "ng":·"ng",
        6 │ + → → "start":·"ng·serve·--host·127.0.0.1·--open",
        7 │ + → → "build":·"ng·build",
        8 │ + → → "watch":·"ng·build·--watch·--configuration·development"
        9 │ + → },
       10 │ + → "private":·true,
       11 │ + → "packageManager":·"npm@11.12.1",
       12 │ + → "dependencies":·{
       13 │ + → → "@angular/animations":·"^21.2.16",
       14 │ + → → "@angular/cdk":·"^21.2.14",
       15 │ + → → "@angular/common":·"^21.2.0",
       16 │ + → → "@angular/compiler":·"^21.2.0",
       17 │ + → → "@angular/core":·"^21.2.0",
       18 │ + → → "@angular/forms":·"^21.2.0",
       19 │ + → → "@angular/material":·"^21.2.14",
       20 │ + → → "@angular/platform-browser":·"^21.2.0",
       21 │ + → → "@angular/platform-browser-dynamic":·"^21.2.16",
       22 │ + → → "@angular/router":·"^21.2.0",
       23 │ + → → "@ngrx/operators":·"^21.1.0",
       24 │ + → → "@ngrx/signals":·"^21.1.0",
       25 │ + → → "chart.js":·"^4.5.1",
       26 │ + → → "rxjs":·"~7.8.0",
       27 │ + → → "tslib":·"^2.3.0",
       28 │ + → → "zone.js":·"^0.16.2"
       29 │ + → },
       30 │ + → "devDependencies":·{
       31 │ + → → "@angular/build":·"^21.2.14",
       32 │ + → → "@angular/cli":·"^21.2.14",
       33 │ + → → "@angular/compiler-cli":·"^21.2.0",
       34 │ + → → "@types/node":·"^25.9.1",
       35 │ + → → "eslint":·"^10.4.1",
       36 │ + → → "prettier":·"^3.8.1",
       37 │ + → → "typescript":·"~5.9.2"
       38 │ + → }
    39 39 │   }
    40 40 │


FleetTracker.Client/proxy.conf.js format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

    1  1 │   module.exports = {
    2    │ - ··"/api":·{
    3    │ - ····target:·process.env.services__api__https__0·||·process.env.services__api__http__0·||·"https://localhost:7108",
    4    │ - ····secure:·false,
    5    │ - ····changeOrigin:·true
    6    │ - ··}
       2 │ + → "/api":·{
       3 │ + → → target:
       4 │ + → → → process.env.services__api__https__0·||
       5 │ + → → → process.env.services__api__http__0·||
       6 │ + → → → "https://localhost:7108",
       7 │ + → → secure:·false,
       8 │ + → → changeOrigin:·true,
       9 │ + → },
    7 10 │   };
    8 11 │


FleetTracker.Client/src/app/app.component.css format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

    1 1 │   .active {
    2   │ - ··font-weight:·bold;
    3   │ - ··text-decoration:·underline·!important;
      2 │ + → font-weight:·bold;
      3 │ + → text-decoration:·underline·!important;
    4 4 │   }
    5 5 │


FleetTracker.Client/src/app/app.config.ts format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

     1    │ - import·{·ApplicationConfig,·provideZoneChangeDetection·}·from·'@angular/core';
     2    │ - import·{·provideRouter·}·from·'@angular/router';
     3    │ - import·{·provideHttpClient·}·from·'@angular/common/http';
     4    │ - import·{·provideAnimations·}·from·'@angular/platform-browser/animations';
     5    │ - import·{·routes·}·from·'./app.routes';
        1 │ + import·{·ApplicationConfig,·provideZoneChangeDetection·}·from·"@angular/core";
        2 │ + import·{·provideRouter·}·from·"@angular/router";
        3 │ + import·{·provideHttpClient·}·from·"@angular/common/http";
        4 │ + import·{·provideAnimations·}·from·"@angular/platform-browser/animations";
        5 │ + import·{·routes·}·from·"./app.routes";
     6  6 │
     7  7 │   export const appConfig: ApplicationConfig = {
     8    │ - ··providers:·[
     9    │ - ····provideZoneChangeDetection({·eventCoalescing:·true·}),
    10    │ - ····provideRouter(routes),
    11    │ - ····provideHttpClient(),
    12    │ - ····provideAnimations(),
    13    │ - ··],
        8 │ + → providers:·[
        9 │ + → → provideZoneChangeDetection({·eventCoalescing:·true·}),
       10 │ + → → provideRouter(routes),
       11 │ + → → provideHttpClient(),
       12 │ + → → provideAnimations(),
       13 │ + → ],
    14 14 │   };
    15 15 │


FleetTracker.Client/src/app/app.ts format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

     1    │ - import·{·Component·}·from·'@angular/core';
     2    │ - import·{·RouterOutlet,·RouterLink,·RouterLinkActive·}·from·'@angular/router';
        1 │ + import·{·Component·}·from·"@angular/core";
        2 │ + import·{·RouterOutlet,·RouterLink,·RouterLinkActive·}·from·"@angular/router";
     3  3 │
     4  4 │   @Component({
     5    │ - ··selector:·'app-root',
     6    │ - ··standalone:·true,
     7    │ - ··imports:·[RouterOutlet,·RouterLink,·RouterLinkActive],
     8    │ - ··templateUrl:·'./app.component.html',
     9    │ - ··styleUrls:·['./app.component.css'],
        5 │ + → selector:·"app-root",
        6 │ + → standalone:·true,
        7 │ + → imports:·[RouterOutlet,·RouterLink,·RouterLinkActive],
        8 │ + → templateUrl:·"./app.component.html",
        9 │ + → styleUrls:·["./app.component.css"],
    10 10 │   })
    11 11 │   export class App {}


FleetTracker.Client/tsconfig.app.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

     2  2 │   /* To learn more about Angular compiler options: https://angular.dev/reference/configs/angular-compiler-options. */
     3  3 │   {
     4    │ - ··"extends":·"./tsconfig.json",
     5    │ - ··"compilerOptions":·{
     6    │ - ····"outDir":·"./out-tsc/app",
     7    │ - ····"types":·[]
     8    │ - ··},
     9    │ - ··"include":·[
    10    │ - ····"src/**/*.ts"
    11    │ - ··],
    12    │ - ··"exclude":·[
    13    │ - ····"src/**/*.spec.ts"
    14    │ - ··]
        4 │ + → "extends":·"./tsconfig.json",
        5 │ + → "compilerOptions":·{
        6 │ + → → "outDir":·"./out-tsc/app",
        7 │ + → → "types":·[]
        8 │ + → },
        9 │ + → "include":·["src/**/*.ts"],
       10 │ + → "exclude":·["src/**/*.spec.ts"]
    15 11 │   }
    16 12 │


FleetTracker.Client/tsconfig.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

     2  2 │   /* To learn more about Angular compiler options: https://angular.dev/reference/configs/angular-compiler-options. */
     3  3 │   {
     4    │ - ··"compileOnSave":·false,
     5    │ - ··"compilerOptions":·{
     6    │ - ····"strict":·true,
     7    │ - ····"noImplicitOverride":·true,
     8    │ - ····"noPropertyAccessFromIndexSignature":·true,
     9    │ - ····"noImplicitReturns":·true,
    10    │ - ····"noFallthroughCasesInSwitch":·true,
    11    │ - ····"skipLibCheck":·true,
    12    │ - ····"isolatedModules":·true,
    13    │ - ····"experimentalDecorators":·true,
    14    │ - ····"importHelpers":·true,
    15    │ - ····"target":·"ES2022",
    16    │ - ····"module":·"preserve"
    17    │ - ··},
    18    │ - ··"angularCompilerOptions":·{
    19    │ - ····"enableI18nLegacyMessageIdFormat":·false,
    20    │ - ····"strictInjectionParameters":·true,
    21    │ - ····"strictInputAccessModifiers":·true,
    22    │ - ····"strictTemplates":·true
    23    │ - ··},
    24    │ - ··"files":·[],
    25    │ - ··"references":·[
    26    │ - ····{
    27    │ - ······"path":·"./tsconfig.app.json"
    28    │ - ····}
    29    │ - ··]
        4 │ + → "compileOnSave":·false,
        5 │ + → "compilerOptions":·{
        6 │ + → → "strict":·true,
        7 │ + → → "noImplicitOverride":·true,
        8 │ + → → "noPropertyAccessFromIndexSignature":·true,
        9 │ + → → "noImplicitReturns":·true,
       10 │ + → → "noFallthroughCasesInSwitch":·true,
       11 │ + → → "skipLibCheck":·true,
       12 │ + → → "isolatedModules":·true,
       13 │ + → → "experimentalDecorators":·true,
       14 │ + → → "importHelpers":·true,
       15 │ + → → "target":·"ES2022",
       16 │ + → → "module":·"preserve"
       17 │ + → },
       18 │ + → "angularCompilerOptions":·{
       19 │ + → → "enableI18nLegacyMessageIdFormat":·false,
       20 │ + → → "strictInjectionParameters":·true,
       21 │ + → → "strictInputAccessModifiers":·true,
       22 │ + → → "strictTemplates":·true
       23 │ + → },
       24 │ + → "files":·[],
       25 │ + → "references":·[
       26 │ + → → {
       27 │ + → → → "path":·"./tsconfig.app.json"
       28 │ + → → }
       29 │ + → ]
    30 30 │   }
    31 31 │


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
    10    │ - ····"FleetTrackerDb":·"Server=(localdb)\\mssqllocaldb;Database=FleetTrackerDb;Trusted_Connection=True;MultipleActiveResultSets=true"
    11    │ - ··}
        2 │ + → "Logging":·{
        3 │ + → → "LogLevel":·{
        4 │ + → → → "Default":·"Information",
        5 │ + → → → "Microsoft.AspNetCore":·"Warning"
        6 │ + → → }
        7 │ + → },
        8 │ + → "AllowedHosts":·"*",
        9 │ + → "ConnectionStrings":·{
       10 │ + → → "FleetTrackerDb":·"Server=(localdb)\\mssqllocaldb;Database=FleetTrackerDb;Trusted_Connection=True;MultipleActiveResultSets=true"
       11 │ + → }
    12 12 │   }
    13 13 │


github_conf/branch_protection_rules.json format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Formatter would have printed the following content:

    1 1 │   {
    2   │ - ····"message":·"Not·Found",
    3   │ - ····"documentation_url":·"https://docs.github.com/rest",
    4   │ - ····"status":·"404"
    5   │ - }
      2 │ + → "message":·"Not·Found",
      3 │ + → "documentation_url":·"https://docs.github.com/rest",
      4 │ + → "status":·"404"
      5 │ + }
      6 │ +


format ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Some errors were emitted while running checks.

```

</details>

<details>

<summary>BIOME_LINT</summary>

```text
The number of diagnostics exceeds the limit allowed. Use --max-diagnostics to increase it.
Diagnostics not shown: 67.
Checked 42 files in 123ms. No fixes applied.
Found 44 errors.
Found 42 warnings.
Found 1 info.FleetTracker.Client/src/index.html:15:34 lint/style/useTemplate  FIXABLE  ━━━━━━━━━━━━━━━━━━━━━━━━━━

  i Template literals are preferred over string concatenation.

    13 │   <script>
    14 │     window.onerror = function(msg, url, lineNo, columnNo, error) {
  > 15 │       document.body.innerHTML += '<div style="color:red; margin: 20px; font-family: monospace;"><b>Error:</b> ' + msg + '<br>Line: ' + lineNo + '<br>Stack: ' + (error && error.stack) + '</div>';
       │                                  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    16 │       return false;
    17 │     };

  i Unsafe fix: Use a template literal.

    1 1 │
    2 2 │       window.onerror = function(msg, url, lineNo, columnNo, error) {
    3   │ - ······document.body.innerHTML·+=·'<div·style="color:red;·margin:·20px;·font-family:·monospace;"><b>Error:</b>·'·+·msg·+·'<br>Line:·'·+·lineNo·+·'<br>Stack:·'·+·(error·&&·error.stack)·+·'</div>';
      3 │ + ······document.body.innerHTML·+=·`<div·style="color:red;·margin:·20px;·font-family:·monospace;"><b>Error:</b>·${msg}<br>Line:·${lineNo}<br>Stack:·${error·&&·error.stack}</div>`;
    4 4 │         return false;
    5 5 │       };


FleetTracker.Client/src/app/app.component.css:3:30 lint/complexity/noImportantStyles  FIXABLE  ━━━━━━━━━━

  ! Avoid the use of the !important style.

    1 │ .active {
    2 │   font-weight: bold;
  > 3 │   text-decoration: underline !important;
      │                              ^^^^^^^^^^
    4 │ }
    5 │

  i This style reverses the cascade logic, and precedence is reversed. This could lead to having styles with higher specificity being overridden by styles with lower specificity.

  i Unsafe fix: Remove the style.

    3 │ ··text-decoration:·underline·!important;
      │                             -----------

FleetTracker.Client/src/app/app.config.ts:1:8 lint/style/useImportType  FIXABLE  ━━━━━━━━━━━━━━━━━━━

  ! Some named imports are only used as types.

  > 1 │ import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
      │        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    2 │ import { provideRouter } from '@angular/router';
    3 │ import { provideHttpClient } from '@angular/common/http';

  i This import is only used as a type.

  > 1 │ import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
      │          ^^^^^^^^^^^^^^^^^
    2 │ import { provideRouter } from '@angular/router';
    3 │ import { provideHttpClient } from '@angular/common/http';

  i Importing the types with import type ensures that they are removed by the compilers and avoids loading unnecessary modules.

  i Safe fix: Add inline type keywords.

    1 │ import·{·type·ApplicationConfig,·provideZoneChangeDetection·}·from·'@angular/core';
      │          +++++

FleetTracker.Client/src/app/app.routes.ts:1:8 lint/style/useImportType  FIXABLE  ━━━━━━━━━━━━━━━━━━━

  ! All these imports are only used as types.

  > 1 │ import { Routes } from '@angular/router';
      │        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    2 │ import { DashboardComponent } from './dashboard/dashboard.component';
    3 │ import { VehiclesComponent } from './vehicles/vehicles.component';

  i Importing the types with import type ensures that they are removed by the compilers and avoids loading unnecessary modules.

  i Safe fix: Use import type.

    1 │ import·type·{·Routes·}·from·'@angular/router';
      │        +++++

FleetTracker.Client/src/app/customers/customers.component.ts:1:8 lint/style/useImportType  FIXABLE  ━━━━━━━━━━

  ! Some named imports are only used as types.

  > 1 │ import { Component, OnInit, inject } from '@angular/core';
      │        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    2 │ import { CommonModule } from '@angular/common';
    3 │ import { RouterLink } from '@angular/router';

  i This import is only used as a type.

  > 1 │ import { Component, OnInit, inject } from '@angular/core';
      │                     ^^^^^^
    2 │ import { CommonModule } from '@angular/common';
    3 │ import { RouterLink } from '@angular/router';

  i Importing the types with import type ensures that they are removed by the compilers and avoids loading unnecessary modules.

  i Safe fix: Add inline type keywords.

    1 │ import·{·Component,·type·OnInit,·inject·}·from·'@angular/core';
      │                     +++++

FleetTracker.Client/src/index.html:14:22 lint/complexity/useArrowFunction  FIXABLE  ━━━━━━━━━━━━━━━━

  ! This function expression can be turned into an arrow function.

    12 │   <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    13 │   <script>
  > 14 │     window.onerror = function(msg, url, lineNo, columnNo, error) {
       │                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
  > 15 │       document.body.innerHTML += '<div style="color:red; margin: 20px; font-family: monospace;"><b>Error:</b> ' + msg + '<br>Line: ' + lineNo + '<br>Stack: ' + (error && error.stack) + '</div>';
  > 16 │       return false;
  > 17 │     };
       │     ^
    18 │   </script>
    19 │ </head>

  i Function expressions that don't use this can be turned into arrow functions.

  i Safe fix: Use an arrow function instead.

    1 1 │
    2   │ - ····window.onerror·=·function(msg,·url,·lineNo,·columnNo,·error)·{
      2 │ + ····window.onerror·=·(msg,·url,·lineNo,·columnNo,·error)·=>·{
    3 3 │         document.body.innerHTML += '<div style="color:red; margin: 20px; font-family: monospace;"><b>Error:</b> ' + msg + '<br>Line: ' + lineNo + '<br>Stack: ' + (error && error.stack) + '</div>';
    4 4 │         return false;


FleetTracker.Client/src/index.html:14:36 lint/correctness/noUnusedFunctionParameters  FIXABLE  ━━━━━━━━━━

  ! This parameter url is unused.

    12 │   <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    13 │   <script>
  > 14 │     window.onerror = function(msg, url, lineNo, columnNo, error) {
       │                                    ^^^
    15 │       document.body.innerHTML += '<div style="color:red; margin: 20px; font-family: monospace;"><b>Error:</b> ' + msg + '<br>Line: ' + lineNo + '<br>Stack: ' + (error && error.stack) + '</div>';
    16 │       return false;

  i Unused parameters might be the result of an incomplete refactoring.

  i Unsafe fix: If this is intentional, prepend url with an underscore.

    1 1 │
    2   │ - ····window.onerror·=·function(msg,·url,·lineNo,·columnNo,·error)·{
      2 │ + ····window.onerror·=·function(msg,·_url,·lineNo,·columnNo,·error)·{
    3 3 │         document.body.innerHTML += '<div style="color:red; margin: 20px; font-family: monospace;"><b>Error:</b> ' + msg + '<br>Line: ' + lineNo + '<br>Stack: ' + (error && error.stack) + '</div>';
    4 4 │         return false;


FleetTracker.Client/src/index.html:14:49 lint/correctness/noUnusedFunctionParameters  FIXABLE  ━━━━━━━━━━

  ! This parameter columnNo is unused.

    12 │   <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    13 │   <script>
  > 14 │     window.onerror = function(msg, url, lineNo, columnNo, error) {
       │                                                 ^^^^^^^^
    15 │       document.body.innerHTML += '<div style="color:red; margin: 20px; font-family: monospace;"><b>Error:</b> ' + msg + '<br>Line: ' + lineNo + '<br>Stack: ' + (error && error.stack) + '</div>';
    16 │       return false;

  i Unused parameters might be the result of an incomplete refactoring.

  i Unsafe fix: If this is intentional, prepend columnNo with an underscore.

    1 1 │
    2   │ - ····window.onerror·=·function(msg,·url,·lineNo,·columnNo,·error)·{
      2 │ + ····window.onerror·=·function(msg,·url,·lineNo,·_columnNo,·error)·{
    3 3 │         document.body.innerHTML += '<div style="color:red; margin: 20px; font-family: monospace;"><b>Error:</b> ' + msg + '<br>Line: ' + lineNo + '<br>Stack: ' + (error && error.stack) + '</div>';
    4 4 │         return false;


FleetTracker.Client/src/index.html:15:162 lint/complexity/useOptionalChain  FIXABLE  ━━━━━━━━━━━━━━━

  ! Change to an optional chain.

    13 │   <script>
    14 │     window.onerror = function(msg, url, lineNo, columnNo, error) {
  > 15 │       document.body.innerHTML += '<div style="color:red; margin: 20px; font-family: monospace;"><b>Error:</b> ' + msg + '<br>Line: ' + lineNo + '<br>Stack: ' + (error && error.stack) + '</div>';
       │                                                                                                                                                                  ^^^^^^^^^^^^^^^^^^^^
    16 │       return false;
    17 │     };

  i Unsafe fix: Change to an optional chain.

    1 1 │
    2 2 │       window.onerror = function(msg, url, lineNo, columnNo, error) {
    3   │ - ······document.body.innerHTML·+=·'<div·style="color:red;·margin:·20px;·font-family:·monospace;"><b>Error:</b>·'·+·msg·+·'<br>Line:·'·+·lineNo·+·'<br>Stack:·'·+·(error·&&·error.stack)·+·'</div>';
      3 │ + ······document.body.innerHTML·+=·'<div·style="color:red;·margin:·20px;·font-family:·monospace;"><b>Error:</b>·'·+·msg·+·'<br>Line:·'·+·lineNo·+·'<br>Stack:·'·+·(error?.stack)·+·'</div>';
    4 4 │         return false;
    5 5 │       };


FleetTracker.Client/src/app/app.component.html:4:5 lint/a11y/useValidAnchor ━━━━━━━━━━━━━━━━━━━━━━━━

  × Provide a href attribute for the a element.

     2 │   <h1>FleetTracker Dashboard</h1>
     3 │   <nav style="margin-bottom: 20px; display: flex; gap: 15px;">
   > 4 │     <a
       │     ^^
   > 5 │       routerLink="/dashboard"
   > 6 │       routerLinkActive="active"
   > 7 │       style="text-decoration: none; color: blue;"
   > 8 │       >Overview</a
       │       ^
     9 │     >
    10 │     <a

  i An anchor element should always have a href

  i Check this thorough explanation to better understand the context.


FleetTracker.Client/src/app/app.component.html:10:5 lint/a11y/useValidAnchor ━━━━━━━━━━━━━━━━━━━━━━━

  × Provide a href attribute for the a element.

     8 │       >Overview</a
     9 │     >
  > 10 │     <a
       │     ^^
  > 11 │       routerLink="/vehicles"
  > 12 │       routerLinkActive="active"
  > 13 │       style="text-decoration: none; color: blue;"
  > 14 │       >Vehicles</a
       │       ^
    15 │     >
    16 │     <a

  i An anchor element should always have a href

  i Check this thorough explanation to better understand the context.


FleetTracker.Client/src/app/app.component.html:16:5 lint/a11y/useValidAnchor ━━━━━━━━━━━━━━━━━━━━━━━

  × Provide a href attribute for the a element.

    14 │       >Vehicles</a
    15 │     >
  > 16 │     <a
       │     ^^
  > 17 │       routerLink="/rentals"
  > 18 │       routerLinkActive="active"
  > 19 │       style="text-decoration: none; color: blue;"
  > 20 │       >Rentals</a
       │       ^
    21 │     >
    22 │     <a

  i An anchor element should always have a href

  i Check this thorough explanation to better understand the context.


FleetTracker.Client/src/app/app.component.html:22:5 lint/a11y/useValidAnchor ━━━━━━━━━━━━━━━━━━━━━━━

  × Provide a href attribute for the a element.

    20 │       >Rentals</a
    21 │     >
  > 22 │     <a
       │     ^^
  > 23 │       routerLink="/customers"
  > 24 │       routerLinkActive="active"
  > 25 │       style="text-decoration: none; color: blue;"
  > 26 │       >Customers</a
       │       ^
    27 │     >
    28 │   </nav>

  i An anchor element should always have a href

  i Check this thorough explanation to better understand the context.


FleetTracker.Client/src/app/customers/customers.component.html:6:54 parse ━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Text expressions aren't supported.

    4 │   <div>Loading customers...</div>
    5 │ } @else if (store.error()) {
  > 6 │   <div style="color: red; font-weight: bold;">Error: {{ store.error() }}</div>
      │                                                      ^^^^^^^^^^^^^^^^^^^
    7 │ } @else {
    8 │   <div style="display: flex; justify-content: space-between; align-items: center; margin-bottom: 20px;">

  i Remove it or enable the parsing using the html.parser.interpolation option.


FleetTracker.Client/src/app/customers/customers.component.html:25:15 parse ━━━━━━━━━━━━━━━━━━━━━━━━━

  × Text expressions aren't supported.

    23 │       @for (customer of filteredCustomers; track customer.id) {
    24 │         <tr [routerLink]="['/customers', customer.id]" style="cursor: pointer; background-color: #fafafa;">
  > 25 │           <td>{{ customer.contact?.name }}</td>
       │               ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    26 │           <td>{{ customer.contact?.email }}</td>
    27 │           <td>{{ customer.contact?.phoneNumber | phone }}</td>

  i Remove it or enable the parsing using the html.parser.interpolation option.


FleetTracker.Client/src/app/customers/customers.component.html:26:15 parse ━━━━━━━━━━━━━━━━━━━━━━━━━

  × Text expressions aren't supported.

    24 │         <tr [routerLink]="['/customers', customer.id]" style="cursor: pointer; background-color: #fafafa;">
    25 │           <td>{{ customer.contact?.name }}</td>
  > 26 │           <td>{{ customer.contact?.email }}</td>
       │               ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    27 │           <td>{{ customer.contact?.phoneNumber | phone }}</td>
    28 │           <td>{{ customer.driversLicense }}</td>

  i Remove it or enable the parsing using the html.parser.interpolation option.


FleetTracker.Client/src/app/customers/customers.component.html:27:15 parse ━━━━━━━━━━━━━━━━━━━━━━━━━

  × Text expressions aren't supported.

    25 │           <td>{{ customer.contact?.name }}</td>
    26 │           <td>{{ customer.contact?.email }}</td>
  > 27 │           <td>{{ customer.contact?.phoneNumber | phone }}</td>
       │               ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    28 │           <td>{{ customer.driversLicense }}</td>
    29 │           <td>{{ customer.dateOfBirth | date: 'shortDate' }}</td>

  i Remove it or enable the parsing using the html.parser.interpolation option.


FleetTracker.Client/src/app/customers/customers.component.html:28:15 parse ━━━━━━━━━━━━━━━━━━━━━━━━━

  × Text expressions aren't supported.

    26 │           <td>{{ customer.contact?.email }}</td>
    27 │           <td>{{ customer.contact?.phoneNumber | phone }}</td>
  > 28 │           <td>{{ customer.driversLicense }}</td>
       │               ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    29 │           <td>{{ customer.dateOfBirth | date: 'shortDate' }}</td>
    30 │         </tr>

  i Remove it or enable the parsing using the html.parser.interpolation option.


FleetTracker.Client/src/app/customers/customers.component.html:29:15 parse ━━━━━━━━━━━━━━━━━━━━━━━━━

  × Text expressions aren't supported.

    27 │           <td>{{ customer.contact?.phoneNumber | phone }}</td>
    28 │           <td>{{ customer.driversLicense }}</td>
  > 29 │           <td>{{ customer.dateOfBirth | date: 'shortDate' }}</td>
       │               ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    30 │         </tr>
    31 │       } @empty {

  i Remove it or enable the parsing using the html.parser.interpolation option.


FleetTracker.Client/src/app/customers/customers.component.html:10:5 lint/a11y/useButtonType ━━━━━━━━━━

  × Provide an explicit type attribute for the button element.

     8 │   <div style="display: flex; justify-content: space-between; align-items: center; margin-bottom: 20px;">
     9 │     <input type="text" [(ngModel)]="filterText" placeholder="Filter by name or email..." style="padding: 8px; width: 300px;" />
  > 10 │     <button routerLink="/customers/new" style="padding: 8px 16px; cursor: pointer;">+ New Customer</button>
       │     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    11 │   </div>
    12 │   <table border="1" cellpadding="5" cellspacing="0" style="width: 100%; text-align: left;">

  i The default type of a button is submit, which causes the submission of a form when placed inside a `form` element.

  i Allowed button types are: submit, button or reset


lint ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Some warnings were emitted while running checks.

```

</details>

<details>

<summary>CHECKOV</summary>

```text
terraform_plan scan results:

Passed checks: 0, Failed checks: 0, Skipped checks: 0, Parsing errors: 1

github_actions scan results:

Passed checks: 43, Failed checks: 1, Skipped checks: 0

Check: CKV2_GHA_1: "Ensure top-level permissions are not set to write-all"
	FAILED for resource: on(CodeQL Advanced)
	File: /.github/workflows/codeql.yml:31-32
```

</details>

<details>

<summary>JSCPD</summary>

```text
[1mClone found (json)[22m
 - /github/workspace/FleetTracker.Client/package-lock.json [9:25 - 37:6]
   /github/workspace/FleetTracker.Client/package.json [11:34 - 39:2]
[90m   9 │ [39m      "version": "0.0.0",
[90m  10 │ [39m      "dependencies": {
[90m  11 │ [39m        "@angular/animations": "^21.2.16",
[90m  12 │ [39m        "@angular/cdk": "^21.2.14",
[90m  13 │ [39m        "@angular/common": "^21.2.0",
[90m  14 │ [39m        "@angular/compiler": "^21.2.0",
[90m  15 │ [39m        "@angular/core": "^21.2.0",
[90m  16 │ [39m        "@angular/forms": "^21.2.0",
[90m  17 │ [39m        "@angular/material": "^21.2.14",
[90m  18 │ [39m        "@angular/platform-browser": "^21.2.0",
[90m  19 │ [39m        "@angular/platform-browser-dynamic": "^21.2.16",
[90m  20 │ [39m        "@angular/router": "^21.2.0",
[90m  21 │ [39m        "@ngrx/operators": "^21.1.0",
[90m  22 │ [39m        "@ngrx/signals": "^21.1.0",
[90m  23 │ [39m        "chart.js": "^4.5.1",
[90m  24 │ [39m        "rxjs": "~7.8.0",
[90m  25 │ [39m        "tslib": "^2.3.0",
[90m  26 │ [39m        "zone.js": "^0.16.2"
[90m  27 │ [39m      },
[90m  28 │ [39m      "devDependencies": {
[90m     … 9 more lines[39m
[90m  11 │ [39m  "packageManager": "npm@11.12.1",
[90m  12 │ [39m  "dependencies": {
[90m  13 │ [39m    "@angular/animations": "^21.2.16",
[90m  14 │ [39m    "@angular/cdk": "^21.2.14",
[90m  15 │ [39m    "@angular/common": "^21.2.0",
[90m  16 │ [39m    "@angular/compiler": "^21.2.0",
[90m  17 │ [39m    "@angular/core": "^21.2.0",
[90m  18 │ [39m    "@angular/forms": "^21.2.0",
[90m  19 │ [39m    "@angular/material": "^21.2.14",
[90m  20 │ [39m    "@angular/platform-browser": "^21.2.0",
[90m  21 │ [39m    "@angular/platform-browser-dynamic": "^21.2.16",
[90m  22 │ [39m    "@angular/router": "^21.2.0",
[90m  23 │ [39m    "@ngrx/operators": "^21.1.0",
[90m  24 │ [39m    "@ngrx/signals": "^21.1.0",
[90m  25 │ [39m    "chart.js": "^4.5.1",
[90m  26 │ [39m    "rxjs": "~7.8.0",
[90m  27 │ [39m    "tslib": "^2.3.0",
[90m  28 │ [39m    "zone.js": "^0.16.2"
[90m  29 │ [39m  },
[90m  30 │ [39m  "devDependencies": {
[90m     … 9 more lines[39m

[1mClone found (json)[22m
 - /github/workspace/FleetTracker.Client/package-lock.json [1662:117 - 1683:7]
   /github/workspace/FleetTracker.Client/package-lock.json [1959:117 - 1980:7]
[90m1662 │ [39m      "integrity": "sha512-VXukHf0RR1doGe6Sm4F0Em7SWYLTHSsbGfJdS9Ja2bX5/D5uwVOEjr07cncLROdBvmnvCATYEWlHqYmXv2IlQA==",
[90m1663 │ [39m      "dev": true,
[90m1664 │ [39m      "license": "MIT",
[90m1665 │ [39m      "dependencies": {
[90m1666 │ [39m        "@inquirer/ansi": "^1.0.2",
[90m1667 │ [39m        "@inquirer/core": "^10.3.2",
[90m1668 │ [39m        "@inquirer/figures": "^1.0.15",
[90m1669 │ [39m        "@inquirer/type": "^3.0.10",
[90m1670 │ [39m        "yoctocolors-cjs": "^2.1.3"
[90m1671 │ [39m      },
[90m1672 │ [39m      "engines": {
[90m1673 │ [39m        "node": ">=18"
[90m1674 │ [39m      },
[90m1675 │ [39m      "peerDependencies": {
[90m1676 │ [39m        "@types/node": ">=18"
[90m1677 │ [39m      },
[90m1678 │ [39m      "peerDependenciesMeta": {
[90m1679 │ [39m        "@types/node": {
[90m1680 │ [39m          "optional": true
[90m1681 │ [39m        }
[90m     … 2 more lines[39m
[90m1959 │ [39m      "integrity": "sha512-l4xMuJo55MAe+N7Qr4rX90vypFwCajSakx59qe/tMaC1aEHWLyw68wF4o0A4SLAY4E0nd+Vt+EyskeDIqu1M6w==",
[90m1960 │ [39m      "dev": true,
[90m1961 │ [39m      "license": "MIT",
[90m1962 │ [39m      "dependencies": {
[90m1963 │ [39m        "@inquirer/ansi": "^1.0.2",
[90m1964 │ [39m        "@inquirer/core": "^10.3.2",
[90m1965 │ [39m        "@inquirer/figures": "^1.0.15",
[90m1966 │ [39m        "@inquirer/type": "^3.0.10",
[90m1967 │ [39m        "yoctocolors-cjs": "^2.1.3"
[90m1968 │ [39m      },
[90m1969 │ [39m      "engines": {
[90m1970 │ [39m        "node": ">=18"
[90m1971 │ [39m      },
[90m1972 │ [39m      "peerDependencies": {
[90m1973 │ [39m        "@types/node": ">=18"
[90m1974 │ [39m      },
[90m1975 │ [39m      "peerDependenciesMeta": {
[90m1976 │ [39m        "@types/node": {
[90m1977 │ [39m          "optional": true
[90m1978 │ [39m        }
[90m     … 2 more lines[39m

[1mClone found (json)[22m
 - /github/workspace/FleetTracker.Client/package-lock.json [1687:117 - 1705:7]
   /github/workspace/FleetTracker.Client/package-lock.json [1815:117 - 1833:7]
[90m1687 │ [39m      "integrity": "sha512-KR8edRkIsUayMXV+o3Gv+q4jlhENF9nMYUZs9PA2HzrXeHI8M5uDag70U7RJn9yyiMZSbtF5/UexBtAVtZGSbQ==",
[90m1688 │ [39m      "dev": true,
[90m1689 │ [39m      "license": "MIT",
[90m1690 │ [39m      "dependencies": {
[90m1691 │ [39m        "@inquirer/core": "^10.3.2",
[90m1692 │ [39m        "@inquirer/type": "^3.0.10"
[90m1693 │ [39m      },
[90m1694 │ [39m      "engines": {
[90m1695 │ [39m        "node": ">=18"
[90m1696 │ [39m      },
[90m1697 │ [39m      "peerDependencies": {
[90m1698 │ [39m        "@types/node": ">=18"
[90m1699 │ [39m      },
[90m1700 │ [39m      "peerDependenciesMeta": {
[90m1701 │ [39m        "@types/node": {
[90m1702 │ [39m          "optional": true
[90m1703 │ [39m        }
[90m1704 │ [39m      }
[90m1705 │ [39m    },
[90m1815 │ [39m      "integrity": "sha512-kN0pAM4yPrLjJ1XJBjDxyfDduXOuQHrBB8aLDMueuwUGn+vNpF7Gq7TvyVxx8u4SHlFFj4trmj+a2cbpG4Jn1g==",
[90m1816 │ [39m      "dev": true,
[90m1817 │ [39m      "license": "MIT",
[90m1818 │ [39m      "dependencies": {
[90m1819 │ [39m        "@inquirer/core": "^10.3.2",
[90m1820 │ [39m        "@inquirer/type": "^3.0.10"
[90m1821 │ [39m      },
[90m1822 │ [39m      "engines": {
[90m1823 │ [39m        "node": ">=18"
[90m1824 │ [39m      },
[90m1825 │ [39m      "peerDependencies": {
[90m1826 │ [39m        "@types/node": ">=18"
[90m1827 │ [39m      },
[90m1828 │ [39m      "peerDependenciesMeta": {
[90m1829 │ [39m        "@types/node": {
[90m1830 │ [39m          "optional": true
[90m1831 │ [39m        }
[90m1832 │ [39m      }
[90m1833 │ [39m    },

[1mClone found (json)[22m
 - /github/workspace/FleetTracker.Client/package-lock.json [1687:117 - 1705:7]
   /github/workspace/FleetTracker.Client/package-lock.json [1837:117 - 1855:7]
[90m1687 │ [39m      "integrity": "sha512-KR8edRkIsUayMXV+o3Gv+q4jlhENF9nMYUZs9PA2HzrXeHI8M5uDag70U7RJn9yyiMZSbtF5/UexBtAVtZGSbQ==",
[90m1688 │ [39m      "dev": true,
[90m1689 │ [39m      "license": "MIT",
[90m1690 │ [39m      "dependencies": {
[90m1691 │ [39m        "@inquirer/core": "^10.3.2",
[90m1692 │ [39m        "@inquirer/type": "^3.0.10"
[90m1693 │ [39m      },
[90m1694 │ [39m      "engines": {
[90m1695 │ [39m        "node": ">=18"
[90m1696 │ [39m      },
[90m1697 │ [39m      "peerDependencies": {
[90m1698 │ [39m        "@types/node": ">=18"
[90m1699 │ [39m      },
[90m1700 │ [39m      "peerDependenciesMeta": {
[90m1701 │ [39m        "@types/node": {
[90m1702 │ [39m          "optional": true
[90m1703 │ [39m        }
[90m1704 │ [39m      }
[90m1705 │ [39m    },
[90m1837 │ [39m      "integrity": "sha512-5Smv0OK7K0KUzUfYUXDXQc9jrf8OHo4ktlEayFlelCjwMXz0299Y8OrI+lj7i4gCBY15UObk76q0QtxjzFcFcg==",
[90m1838 │ [39m      "dev": true,
[90m1839 │ [39m      "license": "MIT",
[90m1840 │ [39m      "dependencies": {
[90m1841 │ [39m        "@inquirer/core": "^10.3.2",
[90m1842 │ [39m        "@inquirer/type": "^3.0.10"
[90m1843 │ [39m      },
[90m1844 │ [39m      "engines": {
[90m1845 │ [39m        "node": ">=18"
[90m1846 │ [39m      },
[90m1847 │ [39m      "peerDependencies": {
[90m1848 │ [39m        "@types/node": ">=18"
[90m1849 │ [39m      },
[90m1850 │ [39m      "peerDependenciesMeta": {
[90m1851 │ [39m        "@types/node": {
[90m1852 │ [39m          "optional": true
[90m1853 │ [39m        }
[90m1854 │ [39m      }
[90m1855 │ [39m    },

[1mClone found (json)[22m
 - /github/workspace/FleetTracker.Client/package-lock.json [1760:117 - 1779:7]
   /github/workspace/FleetTracker.Client/package-lock.json [1912:117 - 1931:7]
[90m1760 │ [39m      "integrity": "sha512-nRzdOyFYnpeYTTR2qFwEVmIWypzdAx/sIkCMeTNTcflFOovfqUk+HcFhQQVBftAh9gmGrpFj6QcGEqrDMDOiew==",
[90m1761 │ [39m      "dev": true,
[90m1762 │ [39m      "license": "MIT",
[90m1763 │ [39m      "dependencies": {
[90m1764 │ [39m        "@inquirer/core": "^10.3.2",
[90m1765 │ [39m        "@inquirer/type": "^3.0.10",
[90m1766 │ [39m        "yoctocolors-cjs": "^2.1.3"
[90m1767 │ [39m      },
[90m1768 │ [39m      "engines": {
[90m1769 │ [39m        "node": ">=18"
[90m1770 │ [39m      },
[90m1771 │ [39m      "peerDependencies": {
[90m1772 │ [39m        "@types/node": ">=18"
[90m1773 │ [39m      },
[90m1774 │ [39m      "peerDependenciesMeta": {
[90m1775 │ [39m        "@types/node": {
[90m1776 │ [39m          "optional": true
[90m1777 │ [39m        }
[90m1778 │ [39m      }
[90m1779 │ [39m    },
[90m1912 │ [39m      "integrity": "sha512-+LLQB8XGr3I5LZN/GuAHo+GpDJegQwuPARLChlMICNdwW7OwV2izlCSCxN6cqpL0sMXmbKbFcItJgdQq5EBXTw==",
[90m1913 │ [39m      "dev": true,
[90m1914 │ [39m      "license": "MIT",
[90m1915 │ [39m      "dependencies": {
[90m1916 │ [39m        "@inquirer/core": "^10.3.2",
[90m1917 │ [39m        "@inquirer/type": "^3.0.10",
[90m1918 │ [39m        "yoctocolors-cjs": "^2.1.3"
[90m1919 │ [39m      },
[90m1920 │ [39m      "engines": {
[90m1921 │ [39m        "node": ">=18"
[90m1922 │ [39m      },
[90m1923 │ [39m      "peerDependencies": {
[90m1924 │ [39m        "@types/node": ">=18"
[90m1925 │ [39m      },
[90m1926 │ [39m      "peerDependenciesMeta": {
[90m1927 │ [39m        "@types/node": {
[90m1928 │ [39m          "optional": true
[90m1929 │ [39m        }
[90m1930 │ [39m      }
[90m1931 │ [39m    },

[1mClone found (json)[22m
 - /github/workspace/FleetTracker.Client/package-lock.json [4506:51 - 4523:7]
   /github/workspace/FleetTracker.Client/package-lock.json [6073:52 - 6090:7]
[90m4506 │ [39m    "node_modules/cliui/node_modules/string-width": {
[90m4507 │ [39m      "version": "7.2.0",
[90m4508 │ [39m      "resolved": "https://registry.npmjs.org/string-width/-/string-width-7.2.0.tgz",
[90m4509 │ [39m      "integrity": "sha512-tsaTIkKW9b4N+AEj+SVA+WhJzV7/zMhcSu78mLKWSk7cXMOSHsBKFWUs0fWwq8QyK3MgJBQRX6Gbi4kYbdvGkQ==",
[90m4510 │ [39m      "dev": true,
[90m4511 │ [39m      "license": "MIT",
[90m4512 │ [39m      "dependencies": {
[90m4513 │ [39m        "emoji-regex": "^10.3.0",
[90m4514 │ [39m        "get-east-asian-width": "^1.0.0",
[90m4515 │ [39m        "strip-ansi": "^7.1.0"
[90m4516 │ [39m      },
[90m4517 │ [39m      "engines": {
[90m4518 │ [39m        "node": ">=18"
[90m4519 │ [39m      },
[90m4520 │ [39m      "funding": {
[90m4521 │ [39m        "url": "https://github.com/sponsors/sindresorhus"
[90m4522 │ [39m      }
[90m4523 │ [39m    },
[90m6073 │ [39m    "node_modules/listr2/node_modules/string-width": {
[90m6074 │ [39m      "version": "7.2.0",
[90m6075 │ [39m      "resolved": "https://registry.npmjs.org/string-width/-/string-width-7.2.0.tgz",
[90m6076 │ [39m      "integrity": "sha512-tsaTIkKW9b4N+AEj+SVA+WhJzV7/zMhcSu78mLKWSk7cXMOSHsBKFWUs0fWwq8QyK3MgJBQRX6Gbi4kYbdvGkQ==",
[90m6077 │ [39m      "dev": true,
[90m6078 │ [39m      "license": "MIT",
[90m6079 │ [39m      "dependencies": {
[90m6080 │ [39m        "emoji-regex": "^10.3.0",
[90m6081 │ [39m        "get-east-asian-width": "^1.0.0",
[90m6082 │ [39m        "strip-ansi": "^7.1.0"
[90m6083 │ [39m      },
[90m6084 │ [39m      "engines": {
[90m6085 │ [39m        "node": ">=18"
[90m6086 │ [39m      },
[90m6087 │ [39m      "funding": {
[90m6088 │ [39m        "url": "https://github.com/sponsors/sindresorhus"
[90m6089 │ [39m      }
[90m6090 │ [39m    },

[1mClone found (json)[22m
 - /github/workspace/FleetTracker.Client/package-lock.json [4506:51 - 4523:7]
   /github/workspace/FleetTracker.Client/package-lock.json [6208:56 - 6225:7]
[90m4506 │ [39m    "node_modules/cliui/node_modules/string-width": {
[90m4507 │ [39m      "version": "7.2.0",
[90m4508 │ [39m      "resolved": "https://registry.npmjs.org/string-width/-/string-width-7.2.0.tgz",
[90m4509 │ [39m      "integrity": "sha512-tsaTIkKW9b4N+AEj+SVA+WhJzV7/zMhcSu78mLKWSk7cXMOSHsBKFWUs0fWwq8QyK3MgJBQRX6Gbi4kYbdvGkQ==",
[90m4510 │ [39m      "dev": true,
[90m4511 │ [39m      "license": "MIT",
[90m4512 │ [39m      "dependencies": {
[90m4513 │ [39m        "emoji-regex": "^10.3.0",
[90m4514 │ [39m        "get-east-asian-width": "^1.0.0",
[90m4515 │ [39m        "strip-ansi": "^7.1.0"
[90m4516 │ [39m      },
[90m4517 │ [39m      "engines": {
[90m4518 │ [39m        "node": ">=18"
[90m4519 │ [39m      },
[90m4520 │ [39m      "funding": {
[90m4521 │ [39m        "url": "https://github.com/sponsors/sindresorhus"
[90m4522 │ [39m      }
[90m4523 │ [39m    },
[90m6208 │ [39m    "node_modules/log-update/node_modules/string-width": {
[90m6209 │ [39m      "version": "7.2.0",
[90m6210 │ [39m      "resolved": "https://registry.npmjs.org/string-width/-/string-width-7.2.0.tgz",
[90m6211 │ [39m      "integrity": "sha512-tsaTIkKW9b4N+AEj+SVA+WhJzV7/zMhcSu78mLKWSk7cXMOSHsBKFWUs0fWwq8QyK3MgJBQRX6Gbi4kYbdvGkQ==",
[90m6212 │ [39m      "dev": true,
[90m6213 │ [39m      "license": "MIT",
[90m6214 │ [39m      "dependencies": {
[90m6215 │ [39m        "emoji-regex": "^10.3.0",
[90m6216 │ [39m        "get-east-asian-width": "^1.0.0",
[90m6217 │ [39m        "strip-ansi": "^7.1.0"
[90m6218 │ [39m      },
[90m6219 │ [39m      "engines": {
[90m6220 │ [39m        "node": ">=18"
[90m6221 │ [39m      },
[90m6222 │ [39m      "funding": {
[90m6223 │ [39m        "url": "https://github.com/sponsors/sindresorhus"
[90m6224 │ [39m      }
[90m6225 │ [39m    },

[1mClone found (json)[22m
 - /github/workspace/FleetTracker.Client/package-lock.json [4506:51 - 4523:7]
   /github/workspace/FleetTracker.Client/package-lock.json [8476:51 - 8493:7]
[90m4506 │ [39m    "node_modules/cliui/node_modules/string-width": {
[90m4507 │ [39m      "version": "7.2.0",
[90m4508 │ [39m      "resolved": "https://registry.npmjs.org/string-width/-/string-width-7.2.0.tgz",
[90m4509 │ [39m      "integrity": "sha512-tsaTIkKW9b4N+AEj+SVA+WhJzV7/zMhcSu78mLKWSk7cXMOSHsBKFWUs0fWwq8QyK3MgJBQRX6Gbi4kYbdvGkQ==",
[90m4510 │ [39m      "dev": true,
[90m4511 │ [39m      "license": "MIT",
[90m4512 │ [39m      "dependencies": {
[90m4513 │ [39m        "emoji-regex": "^10.3.0",
[90m4514 │ [39m        "get-east-asian-width": "^1.0.0",
[90m4515 │ [39m        "strip-ansi": "^7.1.0"
[90m4516 │ [39m      },
[90m4517 │ [39m      "engines": {
[90m4518 │ [39m        "node": ">=18"
[90m4519 │ [39m      },
[90m4520 │ [39m      "funding": {
[90m4521 │ [39m        "url": "https://github.com/sponsors/sindresorhus"
[90m4522 │ [39m      }
[90m4523 │ [39m    },
[90m8476 │ [39m    "node_modules/yargs/node_modules/string-width": {
[90m8477 │ [39m      "version": "7.2.0",
[90m8478 │ [39m      "resolved": "https://registry.npmjs.org/string-width/-/string-width-7.2.0.tgz",
[90m8479 │ [39m      "integrity": "sha512-tsaTIkKW9b4N+AEj+SVA+WhJzV7/zMhcSu78mLKWSk7cXMOSHsBKFWUs0fWwq8QyK3MgJBQRX6Gbi4kYbdvGkQ==",
[90m8480 │ [39m      "dev": true,
[90m8481 │ [39m      "license": "MIT",
[90m8482 │ [39m      "dependencies": {
[90m8483 │ [39m        "emoji-regex": "^10.3.0",
[90m8484 │ [39m        "get-east-asian-width": "^1.0.0",
[90m8485 │ [39m        "strip-ansi": "^7.1.0"
[90m8486 │ [39m      },
[90m8487 │ [39m      "engines": {
[90m8488 │ [39m        "node": ">=18"
[90m8489 │ [39m      },
[90m8490 │ [39m      "funding": {
[90m8491 │ [39m        "url": "https://github.com/sponsors/sindresorhus"
[90m8492 │ [39m      }
[90m8493 │ [39m    },

[1mClone found (json)[22m
 - /github/workspace/FleetTracker.Client/package-lock.json [4524:48 - 4541:7]
   /github/workspace/FleetTracker.Client/package-lock.json [6091:49 - 6108:7]
[90m4524 │ [39m    "node_modules/cliui/node_modules/wrap-ansi": {
[90m4525 │ [39m      "version": "9.0.2",
[90m4526 │ [39m      "resolved": "https://registry.npmjs.org/wrap-ansi/-/wrap-ansi-9.0.2.tgz",
[90m4527 │ [39m      "integrity": "sha512-42AtmgqjV+X1VpdOfyTGOYRi0/zsoLqtXQckTmqTeybT+BDIbM/Guxo7x3pE2vtpr1ok6xRqM9OpBe+Jyoqyww==",
[90m4528 │ [39m      "dev": true,
[90m4529 │ [39m      "license": "MIT",
[90m4530 │ [39m      "dependencies": {
[90m4531 │ [39m        "ansi-styles": "^6.2.1",
[90m4532 │ [39m        "string-width": "^7.0.0",
[90m4533 │ [39m        "strip-ansi": "^7.1.0"
[90m4534 │ [39m      },
[90m4535 │ [39m      "engines": {
[90m4536 │ [39m        "node": ">=18"
[90m4537 │ [39m      },
[90m4538 │ [39m      "funding": {
[90m4539 │ [39m        "url": "https://github.com/chalk/wrap-ansi?sponsor=1"
[90m4540 │ [39m      }
[90m4541 │ [39m    },
[90m6091 │ [39m    "node_modules/listr2/node_modules/wrap-ansi": {
[90m6092 │ [39m      "version": "9.0.2",
[90m6093 │ [39m      "resolved": "https://registry.npmjs.org/wrap-ansi/-/wrap-ansi-9.0.2.tgz",
[90m6094 │ [39m      "integrity": "sha512-42AtmgqjV+X1VpdOfyTGOYRi0/zsoLqtXQckTmqTeybT+BDIbM/Guxo7x3pE2vtpr1ok6xRqM9OpBe+Jyoqyww==",
[90m6095 │ [39m      "dev": true,
[90m6096 │ [39m      "license": "MIT",
[90m6097 │ [39m      "dependencies": {
[90m6098 │ [39m        "ansi-styles": "^6.2.1",
[90m6099 │ [39m        "string-width": "^7.0.0",
[90m6100 │ [39m        "strip-ansi": "^7.1.0"
[90m6101 │ [39m      },
[90m6102 │ [39m      "engines": {
[90m6103 │ [39m        "node": ">=18"
[90m6104 │ [39m      },
[90m6105 │ [39m      "funding": {
[90m6106 │ [39m        "url": "https://github.com/chalk/wrap-ansi?sponsor=1"
[90m6107 │ [39m      }
[90m6108 │ [39m    },

[1mClone found (json)[22m
 - /github/workspace/FleetTracker.Client/package-lock.json [4524:48 - 4541:7]
   /github/workspace/FleetTracker.Client/package-lock.json [6226:53 - 6243:7]
[90m4524 │ [39m    "node_modules/cliui/node_modules/wrap-ansi": {
[90m4525 │ [39m      "version": "9.0.2",
[90m4526 │ [39m      "resolved": "https://registry.npmjs.org/wrap-ansi/-/wrap-ansi-9.0.2.tgz",
[90m4527 │ [39m      "integrity": "sha512-42AtmgqjV+X1VpdOfyTGOYRi0/zsoLqtXQckTmqTeybT+BDIbM/Guxo7x3pE2vtpr1ok6xRqM9OpBe+Jyoqyww==",
[90m4528 │ [39m      "dev": true,
[90m4529 │ [39m      "license": "MIT",
[90m4530 │ [39m      "dependencies": {
[90m4531 │ [39m        "ansi-styles": "^6.2.1",
[90m4532 │ [39m        "string-width": "^7.0.0",
[90m4533 │ [39m        "strip-ansi": "^7.1.0"
[90m4534 │ [39m      },
[90m4535 │ [39m      "engines": {
[90m4536 │ [39m        "node": ">=18"
[90m4537 │ [39m      },
[90m4538 │ [39m      "funding": {
[90m4539 │ [39m        "url": "https://github.com/chalk/wrap-ansi?sponsor=1"
[90m4540 │ [39m      }
[90m4541 │ [39m    },
[90m6226 │ [39m    "node_modules/log-update/node_modules/wrap-ansi": {
[90m6227 │ [39m      "version": "9.0.2",
[90m6228 │ [39m      "resolved": "https://registry.npmjs.org/wrap-ansi/-/wrap-ansi-9.0.2.tgz",
[90m6229 │ [39m      "integrity": "sha512-42AtmgqjV+X1VpdOfyTGOYRi0/zsoLqtXQckTmqTeybT+BDIbM/Guxo7x3pE2vtpr1ok6xRqM9OpBe+Jyoqyww==",
[90m6230 │ [39m      "dev": true,
[90m6231 │ [39m      "license": "MIT",
[90m6232 │ [39m      "dependencies": {
[90m6233 │ [39m        "ansi-styles": "^6.2.1",
[90m6234 │ [39m        "string-width": "^7.0.0",
[90m6235 │ [39m        "strip-ansi": "^7.1.0"
[90m6236 │ [39m      },
[90m6237 │ [39m      "engines": {
[90m6238 │ [39m        "node": ">=18"
[90m6239 │ [39m      },
[90m6240 │ [39m      "funding": {
[90m6241 │ [39m        "url": "https://github.com/chalk/wrap-ansi?sponsor=1"
[90m6242 │ [39m      }
[90m6243 │ [39m    },

[1mClone found (typescript)[22m
 - /github/workspace/FleetTracker.Client/src/app/customers/customer-manage.component.ts [115:38 - 121:38]
   /github/workspace/FleetTracker.Client/src/app/rentals/rental-manage.component.ts [53:36 - 59:38]
[90m 115 │ [39mexport class CustomerManageComponent implements OnInit {
[90m 116 │ [39m  private fb = inject(FormBuilder);
[90m 117 │ [39m  private route = inject(ActivatedRoute);
[90m 118 │ [39m  private router = inject(Router);
[90m 119 │ [39m  private apiService = inject(ApiService);
[90m 120 │ [39m  private toast = inject(ToastService);
[90m 121 │ [39m  private store = inject(FleetStore);
[90m  53 │ [39mexport class RentalManageComponent implements OnInit {
[90m  54 │ [39m  private fb = inject(FormBuilder);
[90m  55 │ [39m  private route = inject(ActivatedRoute);
[90m  56 │ [39m  private router = inject(Router);
[90m  57 │ [39m  private apiService = inject(ApiService);
[90m  58 │ [39m  private toast = inject(ToastService);
[90m  59 │ [39m  private store = inject(FleetStore);

[1mClone found (typescript)[22m
 - /github/workspace/FleetTracker.Client/src/app/customers/customer-manage.component.ts [115:38 - 121:38]
   /github/workspace/FleetTracker.Client/src/app/vehicles/vehicle-manage.component.ts [157:37 - 163:38]
[90m 115 │ [39mexport class CustomerManageComponent implements OnInit {
[90m 116 │ [39m  private fb = inject(FormBuilder);
[90m 117 │ [39m  private route = inject(ActivatedRoute);
[90m 118 │ [39m  private router = inject(Router);
[90m 119 │ [39m  private apiService = inject(ApiService);
[90m 120 │ [39m  private toast = inject(ToastService);
[90m 121 │ [39m  private store = inject(FleetStore);
[90m 157 │ [39mexport class VehicleManageComponent implements OnInit {
[90m 158 │ [39m  private fb = inject(FormBuilder);
[90m 159 │ [39m  private route = inject(ActivatedRoute);
[90m 160 │ [39m  private router = inject(Router);
[90m 161 │ [39m  private apiService = inject(ApiService);
[90m 162 │ [39m  private toast = inject(ToastService);
[90m 163 │ [39m  private store = inject(FleetStore);

[1mClone found (typescript)[22m
 - /github/workspace/FleetTracker.Client/src/app/customers/customer-manage.component.ts [169:63 - 176:4]
   /github/workspace/FleetTracker.Client/src/app/rentals/rental-manage.component.ts [81:65 - 88:4]
[90m 169 │ [39m    if (!this.store.vehicles().length) this.store.loadVehicles();
[90m 170 │ [39m  }
[90m 171 │ [39m
[90m 172 │ [39m  getVehicleName(id: string | undefined): string {
[90m 173 │ [39m    if (!id) return 'Unknown Vehicle';
[90m 174 │ [39m    const v = this.store.vehicles().find(x => x.id === id);
[90m 175 │ [39m    return v ? `${v.make} ${v.model}` : id;
[90m 176 │ [39m  }
[90m  81 │ [39m    if (!this.store.customers().length) this.store.loadCustomers();
[90m  82 │ [39m  }
[90m  83 │ [39m
[90m  84 │ [39m  getVehicleName(id: string | undefined): string {
[90m  85 │ [39m    if (!id) return 'Unknown Vehicle';
[90m  86 │ [39m    const v = this.store.vehicles().find(x => x.id === id);
[90m  87 │ [39m    return v ? `${v.make} ${v.model}` : id;
[90m  88 │ [39m  }

[1mClone found (markup)[22m
 - /github/workspace/FleetTracker.Client/src/app/customers/customers.component.html [4:25 - 9:6]
   /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.html [4:23 - 9:6]
[90m   4 │ [39m  <div>Loading customers...</div>
[90m   5 │ [39m} @else if (store.error()) {
[90m   6 │ [39m  <div style="color: red; font-weight: bold;">Error: {{ store.error() }}</div>
[90m   7 │ [39m} @else {
[90m   8 │ [39m  <div style="display: flex; justify-content: space-between; align-items: center; margin-bottom: 20px;">
[90m   9 │ [39m    <input type="text" [(ngModel)]="filterText" placeholder="Filter by name or email..." style="padding: 8px; width: 300px;" />
[90m   4 │ [39m  <div>Loading rentals...</div>
[90m   5 │ [39m} @else if (store.error()) {
[90m   6 │ [39m  <div style="color: red; font-weight: bold;">Error: {{ store.error() }}</div>
[90m   7 │ [39m} @else {
[90m   8 │ [39m  <div style="display: flex; justify-content: space-between; align-items: center; margin-bottom: 20px;">
[90m   9 │ [39m    <div style="display: flex; gap: 10px; align-items: center;">

[1mClone found (markup)[22m
 - /github/workspace/FleetTracker.Client/src/app/customers/customers.component.html [4:25 - 10:46]
   /github/workspace/FleetTracker.Client/src/app/vehicles/vehicles.component.html [4:24 - 11:29]
[90m   4 │ [39m  <div>Loading customers...</div>
[90m   5 │ [39m} @else if (store.error()) {
[90m   6 │ [39m  <div style="color: red; font-weight: bold;">Error: {{ store.error() }}</div>
[90m   7 │ [39m} @else {
[90m   8 │ [39m  <div style="display: flex; justify-content: space-between; align-items: center; margin-bottom: 20px;">
[90m   9 │ [39m    <input type="text" [(ngModel)]="filterText" placeholder="Filter by name or email..." style="padding: 8px; width: 300px;" />
[90m  10 │ [39m    <button routerLink="/customers/new" style="padding: 8px 16px; cursor: pointer;">+ New Customer</button>
[90m   4 │ [39m  <div>Loading vehicles...</div>
[90m   5 │ [39m} @else if (store.error()) {
[90m   6 │ [39m  <div style="color: red; font-weight: bold;">Error: {{ store.error() }}</div>
[90m   7 │ [39m} @else {
[90m   8 │ [39m  <div style="display: flex; justify-content: space-between; align-items: center; margin-bottom: 20px;">
[90m   9 │ [39m    <div style="display: flex; gap: 10px; align-items: center;">
[90m  10 │ [39m      <select [(ngModel)]="statusFilter" style="padding: 8px;">
[90m  11 │ [39m        <option value="">All Statuses</option>

[1mClone found (typescript)[22m
 - /github/workspace/FleetTracker.Client/src/app/rentals/rental-manage.component.ts [80:5 - 87:36]
   /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.ts [48:5 - 55:36]
[90m  80 │ [39m    if (!this.store.vehicles().length) this.store.loadVehicles();
[90m  81 │ [39m    if (!this.store.customers().length) this.store.loadCustomers();
[90m  82 │ [39m  }
[90m  83 │ [39m
[90m  84 │ [39m  getVehicleName(id: string | undefined): string {
[90m  85 │ [39m    if (!id) return 'Unknown Vehicle';
[90m  86 │ [39m    const v = this.store.vehicles().find(x => x.id === id);
[90m  87 │ [39m    return v ? `${v.make} ${v.model}` : id;
[90m  48 │ [39m    if (!this.store.vehicles().length) this.store.loadVehicles();
[90m  49 │ [39m    if (!this.store.customers().length) this.store.loadCustomers();
[90m  50 │ [39m  }
[90m  51 │ [39m
[90m  52 │ [39m  getVehicleName(id: string | undefined): string {
[90m  53 │ [39m    if (!id) return 'Unknown Vehicle';
[90m  54 │ [39m    const v = this.store.vehicles().find(x => x.id === id);
[90m  55 │ [39m    return v ? `${v.make} ${v.model} (${v.licensePlate})` : id;

[1mClone found (typescript)[22m
 - /github/workspace/FleetTracker.Client/src/app/rentals/rental-manage.component.ts [87:39 - 94:4]
   /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.ts [55:59 - 62:4]
[90m  87 │ [39m    return v ? `${v.make} ${v.model}` : id;
[90m  88 │ [39m  }
[90m  89 │ [39m
[90m  90 │ [39m  getCustomerName(id: string | undefined): string {
[90m  91 │ [39m    if (!id) return 'Unknown Customer';
[90m  92 │ [39m    const c = this.store.customers().find(x => x.id === id);
[90m  93 │ [39m    return c && c.contact ? c.contact.name || id : id;
[90m  94 │ [39m  }
[90m  55 │ [39m    return v ? `${v.make} ${v.model} (${v.licensePlate})` : id;
[90m  56 │ [39m  }
[90m  57 │ [39m
[90m  58 │ [39m  getCustomerName(id: string | undefined): string {
[90m  59 │ [39m    if (!id) return 'Unknown Customer';
[90m  60 │ [39m    const c = this.store.customers().find(x => x.id === id);
[90m  61 │ [39m    return c && c.contact ? c.contact.name || id : id;
[90m  62 │ [39m  }

[1mClone found (typescript)[22m
 - /github/workspace/FleetTracker.Client/src/app/rentals/rental-manage.component.ts [87:43 - 94:4]
   /github/workspace/FleetTracker.Client/src/app/vehicles/vehicle-manage.component.ts [207:67 - 214:4]
[90m  87 │ [39m    return v ? `${v.make} ${v.model}` : id;
[90m  88 │ [39m  }
[90m  89 │ [39m
[90m  90 │ [39m  getCustomerName(id: string | undefined): string {
[90m  91 │ [39m    if (!id) return 'Unknown Customer';
[90m  92 │ [39m    const c = this.store.customers().find(x => x.id === id);
[90m  93 │ [39m    return c && c.contact ? c.contact.name || id : id;
[90m  94 │ [39m  }
[90m 207 │ [39m    if (!this.store.customers().length) this.store.loadCustomers();
[90m 208 │ [39m  }
[90m 209 │ [39m
[90m 210 │ [39m  getCustomerName(id: string | undefined): string {
[90m 211 │ [39m    if (!id) return 'Unknown Customer';
[90m 212 │ [39m    const c = this.store.customers().find(x => x.id === id);
[90m 213 │ [39m    return c && c.contact ? c.contact.name || id : id;
[90m 214 │ [39m  }

[1mClone found (typescript)[22m
 - /github/workspace/FleetTracker.Client/src/app/store/fleet.store.ts [118:81 - 127:6]
   /github/workspace/FleetTracker.Client/src/app/store/fleet.store.ts [130:60 - 139:6]
[90m 118 │ [39m        switchMap(({ vin, payload }) => apiService.startMaintenance(vin, payload).pipe(
[90m 119 │ [39m          tapResponse({
[90m 120 │ [39m            next: () => {
[90m 121 │ [39m              apiService.getVehicles().subscribe(vehicles => patchState(store, { vehicles }));
[90m 122 │ [39m            },
[90m 123 │ [39m            error: (err: Error) => patchState(store, { error: err.message })
[90m 124 │ [39m          })
[90m 125 │ [39m        ))
[90m 126 │ [39m      )
[90m 127 │ [39m    ),
[90m 130 │ [39m        switchMap((vin) => apiService.returnMaintenance(vin).pipe(
[90m 131 │ [39m          tapResponse({
[90m 132 │ [39m            next: () => {
[90m 133 │ [39m              apiService.getVehicles().subscribe(vehicles => patchState(store, { vehicles }));
[90m 134 │ [39m            },
[90m 135 │ [39m            error: (err: Error) => patchState(store, { error: err.message })
[90m 136 │ [39m          })
[90m 137 │ [39m        ))
[90m 138 │ [39m      )
[90m 139 │ [39m    )

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Features/Customers/CustomersCommands.cs [2:18 - 11:46]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Features/Rentals/RentalsCommands.cs [1:13 - 10:46]
[90m   2 │ [39musing System.Linq;
[90m   3 │ [39musing System.Threading;
[90m   4 │ [39musing System.Threading.Tasks;
[90m   5 │ [39musing Mediator;
[90m   6 │ [39musing Microsoft.AspNetCore.Http;
[90m   7 │ [39musing FleetTracker.Services.Core.Interfaces;
[90m   8 │ [39musing FleetTracker.Services.Core.Models;
[90m   9 │ [39musing FleetTracker.Services.Core.DataModels;
[90m  10 │ [39m
[90m  11 │ [39mnamespace FleetTracker.Services.Api.Features.Customers
[90m   1 │ [39musing System;
[90m   2 │ [39musing System.Threading;
[90m   3 │ [39musing System.Threading.Tasks;
[90m   4 │ [39musing Mediator;
[90m   5 │ [39musing Microsoft.AspNetCore.Http;
[90m   6 │ [39musing FleetTracker.Services.Core.Interfaces;
[90m   7 │ [39musing FleetTracker.Services.Core.Models;
[90m   8 │ [39musing FleetTracker.Services.Core.DataModels;
[90m   9 │ [39m
[90m  10 │ [39mnamespace FleetTracker.Services.Api.Features.Rentals

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Features/Customers/CustomersCommands.cs [32:98 - 37:16]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Features/Customers/CustomersCommands.cs [71:43 - 76:21]
[90m  32 │ [39m            var contact = new ContactInfo(request.Contact.Name, request.Contact.Email, cleanPhone);
[90m  33 │ [39m            var billingAddress = new Address(request.PaymentInformation.BillingAddress.Street, request.PaymentInformation.BillingAddress.City, request.PaymentInformation.BillingAddress.State, request.PaymentInformation.BillingAddress.Zip, request.PaymentInformation.BillingAddress.Country);
[90m  34 │ [39m            var creditCard = new CreditCard(request.PaymentInformation.CreditCard.CardNumber, request.PaymentInformation.CreditCard.CardHolderName, request.PaymentInformation.CreditCard.ExpirationDate, request.PaymentInformation.CreditCard.Cvv);
[90m  35 │ [39m            var paymentInfo = new PaymentInformation(billingAddress, creditCard);
[90m  36 │ [39m
[90m  37 │ [39m            var customer = new Customer(request.DriversLicense, request.DateOfBirth, paymentInfo, contact, address);
[90m  71 │ [39m            customer.UpdateAddress(address);
[90m  72 │ [39m
[90m  73 │ [39m            var billingAddress = new Address(request.PaymentInformation.BillingAddress.Street, request.PaymentInformation.BillingAddress.City, request.PaymentInformation.BillingAddress.State, request.PaymentInformation.BillingAddress.Zip, request.PaymentInformation.BillingAddress.Country);
[90m  74 │ [39m            var creditCard = new CreditCard(request.PaymentInformation.CreditCard.CardNumber, request.PaymentInformation.CreditCard.CardHolderName, request.PaymentInformation.CreditCard.ExpirationDate, request.PaymentInformation.CreditCard.Cvv);
[90m  75 │ [39m            var paymentInfo = new PaymentInformation(billingAddress, creditCard);
[90m  76 │ [39m            customer.UpdatePayment(paymentInfo);

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Features/Customers/CustomersQueries.cs [2:33 - 10:46]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Features/Rentals/RentalsQueries.cs [3:18 - 11:46]
[90m   2 │ [39musing System.Collections.Generic;
[90m   3 │ [39musing System.Threading;
[90m   4 │ [39musing System.Threading.Tasks;
[90m   5 │ [39musing Mediator;
[90m   6 │ [39musing Microsoft.AspNetCore.Http;
[90m   7 │ [39musing FleetTracker.Services.Core.Interfaces;
[90m   8 │ [39musing FleetTracker.Services.Core.Models;
[90m   9 │ [39m
[90m  10 │ [39mnamespace FleetTracker.Services.Api.Features.Customers
[90m   3 │ [39musing System.Linq;
[90m   4 │ [39musing System.Threading;
[90m   5 │ [39musing System.Threading.Tasks;
[90m   6 │ [39musing Mediator;
[90m   7 │ [39musing Microsoft.AspNetCore.Http;
[90m   8 │ [39musing FleetTracker.Services.Core.Interfaces;
[90m   9 │ [39musing FleetTracker.Services.Core.Models;
[90m  10 │ [39m
[90m  11 │ [39mnamespace FleetTracker.Services.Api.Features.Rentals

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Features/Rentals/RentalsCommands.cs [1:1 - 10:46]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Features/Vehicles/VehiclesCommands.cs [1:1 - 10:46]
[90m   1 │ [39musing System;
[90m   2 │ [39musing System.Threading;
[90m   3 │ [39musing System.Threading.Tasks;
[90m   4 │ [39musing Mediator;
[90m   5 │ [39musing Microsoft.AspNetCore.Http;
[90m   6 │ [39musing FleetTracker.Services.Core.Interfaces;
[90m   7 │ [39musing FleetTracker.Services.Core.Models;
[90m   8 │ [39musing FleetTracker.Services.Core.DataModels;
[90m   9 │ [39m
[90m  10 │ [39mnamespace FleetTracker.Services.Api.Features.Rentals
[90m   1 │ [39musing System;
[90m   2 │ [39musing System.Threading;
[90m   3 │ [39musing System.Threading.Tasks;
[90m   4 │ [39musing Mediator;
[90m   5 │ [39musing Microsoft.AspNetCore.Http;
[90m   6 │ [39musing FleetTracker.Services.Core.Interfaces;
[90m   7 │ [39musing FleetTracker.Services.Core.Models;
[90m   8 │ [39musing FleetTracker.Services.Core.DataModels;
[90m   9 │ [39m
[90m  10 │ [39mnamespace FleetTracker.Services.Api.Features.Vehicles

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Features/Rentals/RentalsQueries.cs [1:1 - 11:46]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Features/Vehicles/VehiclesQueries.cs [1:1 - 11:46]
[90m   1 │ [39musing System;
[90m   2 │ [39musing System.Collections.Generic;
[90m   3 │ [39musing System.Linq;
[90m   4 │ [39musing System.Threading;
[90m   5 │ [39musing System.Threading.Tasks;
[90m   6 │ [39musing Mediator;
[90m   7 │ [39musing Microsoft.AspNetCore.Http;
[90m   8 │ [39musing FleetTracker.Services.Core.Interfaces;
[90m   9 │ [39musing FleetTracker.Services.Core.Models;
[90m  10 │ [39m
[90m  11 │ [39mnamespace FleetTracker.Services.Api.Features.Rentals
[90m   1 │ [39musing System;
[90m   2 │ [39musing System.Collections.Generic;
[90m   3 │ [39musing System.Linq;
[90m   4 │ [39musing System.Threading;
[90m   5 │ [39musing System.Threading.Tasks;
[90m   6 │ [39musing Mediator;
[90m   7 │ [39musing Microsoft.AspNetCore.Http;
[90m   8 │ [39musing FleetTracker.Services.Core.Interfaces;
[90m   9 │ [39musing FleetTracker.Services.Core.Models;
[90m  10 │ [39m
[90m  11 │ [39mnamespace FleetTracker.Services.Api.Features.Vehicles

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [122:89 - 130:14]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [197:97 - 204:14]
[90m 122 │ [39m            string license = _console.PromptForDriversLicense("Enter Driver's License: ");
[90m 123 │ [39m
[90m 124 │ [39m            var customer = _customerRepository.GetCustomerByLicense(license);
[90m 125 │ [39m            while (customer == null)
[90m 126 │ [39m            {
[90m 127 │ [39m                license = _console.PromptForDriversLicense("Customer not found. Try another license or type 'CANCEL' to go back: ");
[90m 128 │ [39m                if (license.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
[90m 129 │ [39m                customer = _customerRepository.GetCustomerByLicense(license);
[90m 130 │ [39m            }
[90m 197 │ [39m            string license = _console.PromptForDriversLicense("Enter Driver's License to edit: ");
[90m 198 │ [39m            var customer = _customerRepository.GetCustomerByLicense(license);
[90m 199 │ [39m            while (customer == null)
[90m 200 │ [39m            {
[90m 201 │ [39m                license = _console.PromptForDriversLicense("Customer not found. Try another license or type 'CANCEL' to go back: ");
[90m 202 │ [39m                if (license.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
[90m 203 │ [39m                customer = _customerRepository.GetCustomerByLicense(license);
[90m 204 │ [39m            }

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [122:89 - 132:43]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [68:98 - 78:32]
[90m 122 │ [39m            string license = _console.PromptForDriversLicense("Enter Driver's License: ");
[90m 123 │ [39m
[90m 124 │ [39m            var customer = _customerRepository.GetCustomerByLicense(license);
[90m 125 │ [39m            while (customer == null)
[90m 126 │ [39m            {
[90m 127 │ [39m                license = _console.PromptForDriversLicense("Customer not found. Try another license or type 'CANCEL' to go back: ");
[90m 128 │ [39m                if (license.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
[90m 129 │ [39m                customer = _customerRepository.GetCustomerByLicense(license);
[90m 130 │ [39m            }
[90m 131 │ [39m
[90m 132 │ [39m            PrintCustomerDetails(customer);
[90m  68 │ [39m            string license = _console.PromptForDriversLicense("Enter Customer Driver's License: ");
[90m  69 │ [39m
[90m  70 │ [39m            var customer = _customerRepository.GetCustomerByLicense(license);
[90m  71 │ [39m            while (customer == null)
[90m  72 │ [39m            {
[90m  73 │ [39m                license = _console.PromptForDriversLicense("Customer not found. Try another license or type 'CANCEL' to go back: ");
[90m  74 │ [39m                if (license.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;
[90m  75 │ [39m                customer = _customerRepository.GetCustomerByLicense(license);
[90m  76 │ [39m            }
[90m  77 │ [39m
[90m  78 │ [39m            _console.WriteLine();

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [150:76 - 162:24]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/VehicleManager.cs [196:74 - 208:24]
[90m 150 │ [39m            var rentals = _rentalRepository.GetRentalsByCustomerId(customer.Id).ToList();
[90m 151 │ [39m
[90m 152 │ [39m            if (rentals.Count == 0)
[90m 153 │ [39m            {
[90m 154 │ [39m                _console.WriteLine("Total Rentals: 0");
[90m 155 │ [39m            }
[90m 156 │ [39m            else
[90m 157 │ [39m            {
[90m 158 │ [39m                _console.WriteLine($"Total Rentals: {rentals.Count}");
[90m 159 │ [39m                _console.WriteLine("Rental History:");
[90m 160 │ [39m                foreach (var rh in rentals)
[90m 161 │ [39m                {
[90m 162 │ [39m                    var vehicle = rh.VehicleId.HasValue ? _vehicleRepository.GetVehicleById(rh.VehicleId.Value) : null;
[90m 196 │ [39m            var rentals = _rentalRepository.GetRentalsByVehicleId(vehicle.Id).ToList();
[90m 197 │ [39m
[90m 198 │ [39m            if (rentals.Count == 0)
[90m 199 │ [39m            {
[90m 200 │ [39m                _console.WriteLine("Total Rentals: 0");
[90m 201 │ [39m            }
[90m 202 │ [39m            else
[90m 203 │ [39m            {
[90m 204 │ [39m                _console.WriteLine($"Total Rentals: {rentals.Count}");
[90m 205 │ [39m                _console.WriteLine("Rental History:");
[90m 206 │ [39m                foreach (var rh in rentals)
[90m 207 │ [39m                {
[90m 208 │ [39m                    var customer = _customerRepository.GetCustomerById(rh.CustomerId.GetValueOrDefault());

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [127:13 - 136:14]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [179:13 - 187:14]
[90m 127 │ [39m            var activeRentals = _rentalRepository.GetAllRentals().Where(r => r.Status == RentalStatus.Active);
[90m 128 │ [39m
[90m 129 │ [39m            if (!activeRentals.Any())
[90m 130 │ [39m            {
[90m 131 │ [39m                _console.WriteLine("No active rentals found.");
[90m 132 │ [39m                return;
[90m 133 │ [39m            }
[90m 134 │ [39m
[90m 135 │ [39m            foreach (var r in activeRentals)
[90m 136 │ [39m            {
[90m 179 │ [39m            var activeRentals = _rentalRepository.GetAllRentals().Where(r => r.Status == RentalStatus.Active);
[90m 180 │ [39m            if (!activeRentals.Any())
[90m 181 │ [39m            {
[90m 182 │ [39m                _console.WriteLine("No active rentals found.");
[90m 183 │ [39m                return;
[90m 184 │ [39m            }
[90m 185 │ [39m
[90m 186 │ [39m            foreach (var r in activeRentals)
[90m 187 │ [39m            {

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/VehicleManager.cs [160:61 - 172:14]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/VehicleManager.cs [415:69 - 426:14]
[90m 160 │ [39m            string vin = _console.PromptForVin("Enter VIN: ");
[90m 161 │ [39m
[90m 162 │ [39m            var vehicle = _vehicleRepository.GetVehicleByVin(vin);
[90m 163 │ [39m            while (vehicle == null)
[90m 164 │ [39m            {
[90m 165 │ [39m                vin = _console.PromptForVin("Vehicle not found. Try another VIN or type 'CANCEL' to go back: ");
[90m 166 │ [39m                if (vin.Equals("CANCEL", StringComparison.OrdinalIgnoreCase))
[90m 167 │ [39m                {
[90m 168 │ [39m                    return;
[90m 169 │ [39m                }
[90m 170 │ [39m
[90m 171 │ [39m                vehicle = _vehicleRepository.GetVehicleByVin(vin);
[90m 172 │ [39m            }
[90m 415 │ [39m            string vin = _console.PromptForVin("Enter VIN to edit: ");
[90m 416 │ [39m            var vehicle = _vehicleRepository.GetVehicleByVin(vin);
[90m 417 │ [39m            while (vehicle == null)
[90m 418 │ [39m            {
[90m 419 │ [39m                vin = _console.PromptForVin("Vehicle not found. Try another VIN or type 'CANCEL' to go back: ");
[90m 420 │ [39m                if (vin.Equals("CANCEL", StringComparison.OrdinalIgnoreCase))
[90m 421 │ [39m                {
[90m 422 │ [39m                    return;
[90m 423 │ [39m                }
[90m 424 │ [39m
[90m 425 │ [39m                vehicle = _vehicleRepository.GetVehicleByVin(vin);
[90m 426 │ [39m            }

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [53:13 - 90:40]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [97:13 - 134:40]
[90m  53 │ [39m            {
[90m  54 │ [39m                DriversLicense = customer.DriversLicense,
[90m  55 │ [39m                DateOfBirth = customer.DateOfBirth,
[90m  56 │ [39m                Contact = new ContactData
[90m  57 │ [39m                {
[90m  58 │ [39m                    Name = customer.Contact.Name,
[90m  59 │ [39m                    Email = customer.Contact.Email,
[90m  60 │ [39m                    PhoneNumber = customer.Contact.PhoneNumber
[90m  61 │ [39m                },
[90m  62 │ [39m                HomeAddress = new AddressData
[90m  63 │ [39m                {
[90m  64 │ [39m                    Street = customer.HomeAddress.Street,
[90m  65 │ [39m                    City = customer.HomeAddress.City,
[90m  66 │ [39m                    State = customer.HomeAddress.State,
[90m  67 │ [39m                    Zip = customer.HomeAddress.Zip,
[90m  68 │ [39m                    Country = customer.HomeAddress.Country
[90m  69 │ [39m                },
[90m  70 │ [39m                PaymentInformation = new PaymentData
[90m  71 │ [39m                {
[90m  72 │ [39m                    BillingAddress = new AddressData
[90m     … 18 more lines[39m
[90m  97 │ [39m            {
[90m  98 │ [39m                DriversLicense = customer.DriversLicense,
[90m  99 │ [39m                DateOfBirth = customer.DateOfBirth,
[90m 100 │ [39m                Contact = new ContactData
[90m 101 │ [39m                {
[90m 102 │ [39m                    Name = customer.Contact.Name,
[90m 103 │ [39m                    Email = customer.Contact.Email,
[90m 104 │ [39m                    PhoneNumber = customer.Contact.PhoneNumber
[90m 105 │ [39m                },
[90m 106 │ [39m                HomeAddress = new AddressData
[90m 107 │ [39m                {
[90m 108 │ [39m                    Street = customer.HomeAddress.Street,
[90m 109 │ [39m                    City = customer.HomeAddress.City,
[90m 110 │ [39m                    State = customer.HomeAddress.State,
[90m 111 │ [39m                    Zip = customer.HomeAddress.Zip,
[90m 112 │ [39m                    Country = customer.HomeAddress.Country
[90m 113 │ [39m                },
[90m 114 │ [39m                PaymentInformation = new PaymentData
[90m 115 │ [39m                {
[90m 116 │ [39m                    BillingAddress = new AddressData
[90m     … 18 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [241:86 - 247:15]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [249:84 - 255:15]
[90m 241 │ [39m            var response = _httpClient.GetAsync($"/api/rentals/customer/{customerId}").Result;
[90m 242 │ [39m            if (!response.IsSuccessStatusCode) return new List<RentalAgreement>();
[90m 243 │ [39m            var json = response.Content.ReadAsStringAsync().Result;
[90m 244 │ [39m            return JsonConvert.DeserializeObject<List<RentalAgreement>>(json, _jsonSettings) ?? new List<RentalAgreement>();
[90m 245 │ [39m        }
[90m 246 │ [39m
[90m 247 │ [39m        public IEnumerable<RentalAgreement> GetRentalsByVehicleId(Guid vehicleId)
[90m 249 │ [39m            var response = _httpClient.GetAsync($"/api/rentals/vehicle/{vehicleId}").Result;
[90m 250 │ [39m            if (!response.IsSuccessStatusCode) return new List<RentalAgreement>();
[90m 251 │ [39m            var json = response.Content.ReadAsStringAsync().Result;
[90m 252 │ [39m            return JsonConvert.DeserializeObject<List<RentalAgreement>>(json, _jsonSettings) ?? new List<RentalAgreement>();
[90m 253 │ [39m        }
[90m 254 │ [39m
[90m 255 │ [39m        public RentalAgreement? GetRentalById(Guid id)

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Core/DataModels/DataModels.cs [73:5 - 91:17]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Core/DataModels/DataModels.cs [133:5 - 151:17]
[90m  73 │ [39m    {
[90m  74 │ [39m        [Required(ErrorMessage = "Input cannot be null or empty.")]
[90m  75 │ [39m        [RegularExpression(@"^[A-Z0-9\-]+$", ErrorMessage = "Drivers license contains invalid characters.")]
[90m  76 │ [39m        public string DriversLicense { get; set; } = string.Empty;
[90m  77 │ [39m
[90m  78 │ [39m        [Required]
[90m  79 │ [39m        public DateTime DateOfBirth { get; set; }
[90m  80 │ [39m
[90m  81 │ [39m        [Required]
[90m  82 │ [39m        public PaymentData PaymentInformation { get; set; } = new();
[90m  83 │ [39m
[90m  84 │ [39m        [Required]
[90m  85 │ [39m        public ContactData Contact { get; set; } = new();
[90m  86 │ [39m
[90m  87 │ [39m        [Required]
[90m  88 │ [39m        public AddressData HomeAddress { get; set; } = new();
[90m  89 │ [39m    }
[90m  90 │ [39m
[90m  91 │ [39m    public class StartRentalRequest
[90m 133 │ [39m    {
[90m 134 │ [39m        [Required(ErrorMessage = "Input cannot be null or empty.")]
[90m 135 │ [39m        [RegularExpression(@"^[A-Z0-9\-]+$", ErrorMessage = "Drivers license contains invalid characters.")]
[90m 136 │ [39m        public string DriversLicense { get; set; } = string.Empty;
[90m 137 │ [39m
[90m 138 │ [39m        [Required]
[90m 139 │ [39m        public DateTime DateOfBirth { get; set; }
[90m 140 │ [39m
[90m 141 │ [39m        [Required]
[90m 142 │ [39m        public PaymentData PaymentInformation { get; set; } = new();
[90m 143 │ [39m
[90m 144 │ [39m        [Required]
[90m 145 │ [39m        public ContactData Contact { get; set; } = new();
[90m 146 │ [39m
[90m 147 │ [39m        [Required]
[90m 148 │ [39m        public AddressData HomeAddress { get; set; } = new();
[90m 149 │ [39m    }
[90m 150 │ [39m
[90m 151 │ [39m    public class CreateVehicleRequest : UpdateVehicleRequest

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/EfFleetRepository.cs [126:9 - 136:18]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Repositories/InMemoryFleetRepository.cs [77:9 - 87:18]
[90m 126 │ [39m        }
[90m 127 │ [39m
[90m 128 │ [39m        public void DeleteVehicle(Guid id)
[90m 129 │ [39m        {
[90m 130 │ [39m            var vehicle = GetVehicleById(id);
[90m 131 │ [39m            if (vehicle != null)
[90m 132 │ [39m            {
[90m 133 │ [39m                if (vehicle.Status != VehicleStatus.Available && vehicle.Status != VehicleStatus.Unavailable)
[90m 134 │ [39m                {
[90m 135 │ [39m                    throw new InvalidOperationException($"Cannot delete vehicle in status: {vehicle.Status}. Ensure the vehicle is Available or Unavailable first.");
[90m 136 │ [39m                }
[90m  77 │ [39m        }
[90m  78 │ [39m
[90m  79 │ [39m        public void DeleteVehicle(Guid id)
[90m  80 │ [39m        {
[90m  81 │ [39m            var vehicle = GetVehicleById(id);
[90m  82 │ [39m            if (vehicle != null)
[90m  83 │ [39m            {
[90m  84 │ [39m                if (vehicle.Status != VehicleStatus.Available && vehicle.Status != VehicleStatus.Unavailable)
[90m  85 │ [39m                {
[90m  86 │ [39m                    throw new InvalidOperationException($"Cannot delete vehicle in status: {vehicle.Status}. Ensure the vehicle is Available or Unavailable first.");
[90m  87 │ [39m                }

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/EfFleetRepository.cs [184:33 - 195:67]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Repositories/InMemoryFleetRepository.cs [105:72 - 116:67]
[90m 184 │ [39m            _context.SaveChanges();
[90m 185 │ [39m        }
[90m 186 │ [39m
[90m 187 │ [39m        public void CompleteRental(Guid id, int endingMileage)
[90m 188 │ [39m        {
[90m 189 │ [39m            var rental = GetRentalById(id);
[90m 190 │ [39m            if (rental != null)
[90m 191 │ [39m            {
[90m 192 │ [39m                var vehicle = GetVehicleById(rental.VehicleId.GetValueOrDefault());
[90m 193 │ [39m                if (vehicle != null)
[90m 194 │ [39m                {
[90m 195 │ [39m                    vehicle.CompleteRental(rental, endingMileage);
[90m 105 │ [39m            return _rentals.Where(r => r.VehicleId == vehicleId).ToList();
[90m 106 │ [39m        }
[90m 107 │ [39m
[90m 108 │ [39m        public void CompleteRental(Guid id, int endingMileage)
[90m 109 │ [39m        {
[90m 110 │ [39m            var rental = GetRentalById(id);
[90m 111 │ [39m            if (rental != null)
[90m 112 │ [39m            {
[90m 113 │ [39m                var vehicle = GetVehicleById(rental.VehicleId.GetValueOrDefault());
[90m 114 │ [39m                if (vehicle != null)
[90m 115 │ [39m                {
[90m 116 │ [39m                    vehicle.CompleteRental(rental, endingMileage);

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [1:1 - 15:16]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs [1:1 - 15:16]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260601134929_InitialCreate")]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260602151152_MakeRentalIdsNullable")]

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [1:1 - 15:16]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [1:1 - 15:16]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260601134929_InitialCreate")]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260602154919_MaintenanceCostPrecision")]

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [1:1 - 15:16]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs [1:1 - 15:16]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260601134929_InitialCreate")]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260603140044_FixMaintenanceMapping")]

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [1:1 - 15:16]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.Designer.cs [1:1 - 15:16]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260601134929_InitialCreate")]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260603152232_DecoupleRentalHistory")]

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [1:1 - 15:16]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153037_AddRentalIndexes.Designer.cs [1:1 - 15:16]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260601134929_InitialCreate")]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260603153037_AddRentalIndexes")]

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [1:1 - 15:16]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153426_AddCustomerLicenseIndex.Designer.cs [1:1 - 15:16]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260601134929_InitialCreate")]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260603153426_AddCustomerLicenseIndex")]

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [1:1 - 15:16]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:1 - 15:16]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260601134929_InitialCreate")]
[90m   1 │ [39m﻿// <auto-generated />
[90m   2 │ [39musing System;
[90m   3 │ [39musing FleetTracker.Services.Data;
[90m   4 │ [39musing Microsoft.EntityFrameworkCore;
[90m   5 │ [39musing Microsoft.EntityFrameworkCore.Infrastructure;
[90m   6 │ [39musing Microsoft.EntityFrameworkCore.Metadata;
[90m   7 │ [39musing Microsoft.EntityFrameworkCore.Migrations;
[90m   8 │ [39musing Microsoft.EntityFrameworkCore.Storage.ValueConversion;
[90m   9 │ [39m
[90m  10 │ [39m#nullable disable
[90m  11 │ [39m
[90m  12 │ [39mnamespace FleetTracker.Services.Data.Migrations
[90m  13 │ [39m{
[90m  14 │ [39m    [DbContext(typeof(FleetTrackerDbContext))]
[90m  15 │ [39m    [Migration("20260603155146_MakeMaintenanceRecordValueObject")]

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [17:5 - 59:36]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs [17:5 - 59:36]
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 23 more lines[39m
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 23 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [17:5 - 381:24]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [17:5 - 382:2]
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 345 more lines[39m
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 346 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [17:5 - 46:33]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs [17:5 - 46:33]
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 10 more lines[39m
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 10 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [17:5 - 88:32]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.Designer.cs [17:5 - 88:23]
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 52 more lines[39m
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 52 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [17:5 - 342:44]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153037_AddRentalIndexes.Designer.cs [17:5 - 344:2]
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 306 more lines[39m
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 308 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [17:5 - 39:40]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153426_AddCustomerLicenseIndex.Designer.cs [17:5 - 39:40]
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 3 more lines[39m
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 3 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [17:5 - 345:31]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 347:2]
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 309 more lines[39m
[90m  17 │ [39m    {
[90m  18 │ [39m        /// <inheritdoc />
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m     … 311 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [19:49 - 345:31]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [16:43 - 344:2]
[90m  19 │ [39m        protected override void BuildTargetModel(ModelBuilder modelBuilder)
[90m  20 │ [39m        {
[90m  21 │ [39m#pragma warning disable 612, 618
[90m  22 │ [39m            modelBuilder
[90m  23 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  24 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  25 │ [39m
[90m  26 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  27 │ [39m
[90m  28 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    b.Property<Guid>("Id")
[90m  31 │ [39m                        .ValueGeneratedOnAdd()
[90m  32 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  35 │ [39m                        .HasColumnType("datetime2");
[90m  36 │ [39m
[90m  37 │ [39m                    b.Property<string>("DriversLicense")
[90m  38 │ [39m                        .IsRequired()
[90m     … 307 more lines[39m
[90m  16 │ [39m        protected override void BuildModel(ModelBuilder modelBuilder)
[90m  17 │ [39m        {
[90m  18 │ [39m#pragma warning disable 612, 618
[90m  19 │ [39m            modelBuilder
[90m  20 │ [39m                .HasAnnotation("ProductVersion", "10.0.8")
[90m  21 │ [39m                .HasAnnotation("Relational:MaxIdentifierLength", 128);
[90m  22 │ [39m
[90m  23 │ [39m            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
[90m  24 │ [39m
[90m  25 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
[90m  26 │ [39m                {
[90m  27 │ [39m                    b.Property<Guid>("Id")
[90m  28 │ [39m                        .ValueGeneratedOnAdd()
[90m  29 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  30 │ [39m
[90m  31 │ [39m                    b.Property<DateTime>("DateOfBirth")
[90m  32 │ [39m                        .HasColumnType("datetime2");
[90m  33 │ [39m
[90m  34 │ [39m                    b.Property<string>("DriversLicense")
[90m  35 │ [39m                        .IsRequired()
[90m     … 309 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [41:34 - 342:44]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153426_AddCustomerLicenseIndex.Designer.cs [44:35 - 347:2]
[90m  41 │ [39m                    b.HasKey("Id");
[90m  42 │ [39m
[90m  43 │ [39m                    b.ToTable("Customers");
[90m  44 │ [39m                });
[90m  45 │ [39m
[90m  46 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
[90m  47 │ [39m                {
[90m  48 │ [39m                    b.Property<Guid>("Id")
[90m  49 │ [39m                        .ValueGeneratedOnAdd()
[90m  50 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  51 │ [39m
[90m  52 │ [39m                    b.Property<DateTime?>("ActualReturnDate")
[90m  53 │ [39m                        .HasColumnType("datetime2");
[90m  54 │ [39m
[90m  55 │ [39m                    b.Property<string>("AgreementNumber")
[90m  56 │ [39m                        .IsRequired()
[90m  57 │ [39m                        .HasColumnType("nvarchar(450)");
[90m  58 │ [39m
[90m  59 │ [39m                    b.Property<Guid>("CustomerId")
[90m  60 │ [39m                        .HasColumnType("uniqueidentifier");
[90m     … 282 more lines[39m
[90m  44 │ [39m                        .IsUnique();
[90m  45 │ [39m
[90m  46 │ [39m                    b.ToTable("Customers");
[90m  47 │ [39m                });
[90m  48 │ [39m
[90m  49 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
[90m  50 │ [39m                {
[90m  51 │ [39m                    b.Property<Guid>("Id")
[90m  52 │ [39m                        .ValueGeneratedOnAdd()
[90m  53 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  54 │ [39m
[90m  55 │ [39m                    b.Property<DateTime?>("ActualReturnDate")
[90m  56 │ [39m                        .HasColumnType("datetime2");
[90m  57 │ [39m
[90m  58 │ [39m                    b.Property<string>("AgreementNumber")
[90m  59 │ [39m                        .IsRequired()
[90m  60 │ [39m                        .HasColumnType("nvarchar(450)");
[90m  61 │ [39m
[90m  62 │ [39m                    b.Property<Guid?>("CustomerId")
[90m  63 │ [39m                        .HasColumnType("uniqueidentifier");
[90m     … 284 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [43:42 - 305:85]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs [72:51 - 334:33]
[90m  43 │ [39m                    b.ToTable("Customers");
[90m  44 │ [39m                });
[90m  45 │ [39m
[90m  46 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
[90m  47 │ [39m                {
[90m  48 │ [39m                    b.Property<Guid>("Id")
[90m  49 │ [39m                        .ValueGeneratedOnAdd()
[90m  50 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  51 │ [39m
[90m  52 │ [39m                    b.Property<DateTime?>("ActualReturnDate")
[90m  53 │ [39m                        .HasColumnType("datetime2");
[90m  54 │ [39m
[90m  55 │ [39m                    b.Property<string>("AgreementNumber")
[90m  56 │ [39m                        .IsRequired()
[90m  57 │ [39m                        .HasColumnType("nvarchar(450)");
[90m  58 │ [39m
[90m  59 │ [39m                    b.Property<Guid>("CustomerId")
[90m  60 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  61 │ [39m
[90m  62 │ [39m                    b.Property<int?>("EndingMileage")
[90m     … 243 more lines[39m
[90m  72 │ [39m                    b.ToTable("MaintenanceRecords");
[90m  73 │ [39m                });
[90m  74 │ [39m
[90m  75 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
[90m  76 │ [39m                {
[90m  77 │ [39m                    b.Property<Guid>("Id")
[90m  78 │ [39m                        .ValueGeneratedOnAdd()
[90m  79 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  80 │ [39m
[90m  81 │ [39m                    b.Property<DateTime?>("ActualReturnDate")
[90m  82 │ [39m                        .HasColumnType("datetime2");
[90m  83 │ [39m
[90m  84 │ [39m                    b.Property<string>("AgreementNumber")
[90m  85 │ [39m                        .IsRequired()
[90m  86 │ [39m                        .HasColumnType("nvarchar(450)");
[90m  87 │ [39m
[90m  88 │ [39m                    b.Property<Guid?>("CustomerId")
[90m  89 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  90 │ [39m
[90m  91 │ [39m                    b.Property<int?>("EndingMileage")
[90m     … 243 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [59:36 - 80:36]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs [59:37 - 80:36]
[90m  59 │ [39m                    b.Property<Guid>("CustomerId")
[90m  60 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  61 │ [39m
[90m  62 │ [39m                    b.Property<int?>("EndingMileage")
[90m  63 │ [39m                        .HasColumnType("int");
[90m  64 │ [39m
[90m  65 │ [39m                    b.Property<DateTime>("ExpectedReturnDate")
[90m  66 │ [39m                        .HasColumnType("datetime2");
[90m  67 │ [39m
[90m  68 │ [39m                    b.Property<DateTime>("PickupDate")
[90m  69 │ [39m                        .HasColumnType("datetime2");
[90m  70 │ [39m
[90m  71 │ [39m                    b.Property<int>("StartingMileage")
[90m  72 │ [39m                        .HasColumnType("int");
[90m  73 │ [39m
[90m  74 │ [39m                    b.Property<int>("Status")
[90m  75 │ [39m                        .HasColumnType("int");
[90m  76 │ [39m
[90m  77 │ [39m                    b.Property<decimal?>("TotalCost")
[90m  78 │ [39m                        .HasColumnType("decimal(18,2)");
[90m     … 2 more lines[39m
[90m  59 │ [39m                    b.Property<Guid?>("CustomerId")
[90m  60 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  61 │ [39m
[90m  62 │ [39m                    b.Property<int?>("EndingMileage")
[90m  63 │ [39m                        .HasColumnType("int");
[90m  64 │ [39m
[90m  65 │ [39m                    b.Property<DateTime>("ExpectedReturnDate")
[90m  66 │ [39m                        .HasColumnType("datetime2");
[90m  67 │ [39m
[90m  68 │ [39m                    b.Property<DateTime>("PickupDate")
[90m  69 │ [39m                        .HasColumnType("datetime2");
[90m  70 │ [39m
[90m  71 │ [39m                    b.Property<int>("StartingMileage")
[90m  72 │ [39m                        .HasColumnType("int");
[90m  73 │ [39m
[90m  74 │ [39m                    b.Property<int>("Status")
[90m  75 │ [39m                        .HasColumnType("int");
[90m  76 │ [39m
[90m  77 │ [39m                    b.Property<decimal?>("TotalCost")
[90m  78 │ [39m                        .HasColumnType("decimal(18,2)");
[90m     … 2 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [80:36 - 310:50]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs [80:37 - 310:50]
[90m  80 │ [39m                    b.Property<Guid>("VehicleId")
[90m  81 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  82 │ [39m
[90m  83 │ [39m                    b.HasKey("Id");
[90m  84 │ [39m
[90m  85 │ [39m                    b.HasIndex("AgreementNumber")
[90m  86 │ [39m                        .IsUnique();
[90m  87 │ [39m
[90m  88 │ [39m                    b.HasIndex("CustomerId");
[90m  89 │ [39m
[90m  90 │ [39m                    b.HasIndex("VehicleId");
[90m  91 │ [39m
[90m  92 │ [39m                    b.ToTable("RentalAgreements");
[90m  93 │ [39m                });
[90m  94 │ [39m
[90m  95 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
[90m  96 │ [39m                {
[90m  97 │ [39m                    b.Property<Guid>("Id")
[90m  98 │ [39m                        .ValueGeneratedOnAdd()
[90m  99 │ [39m                        .HasColumnType("uniqueidentifier");
[90m     … 211 more lines[39m
[90m  80 │ [39m                    b.Property<Guid?>("VehicleId")
[90m  81 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  82 │ [39m
[90m  83 │ [39m                    b.HasKey("Id");
[90m  84 │ [39m
[90m  85 │ [39m                    b.HasIndex("AgreementNumber")
[90m  86 │ [39m                        .IsUnique();
[90m  87 │ [39m
[90m  88 │ [39m                    b.HasIndex("CustomerId");
[90m  89 │ [39m
[90m  90 │ [39m                    b.HasIndex("VehicleId");
[90m  91 │ [39m
[90m  92 │ [39m                    b.ToTable("RentalAgreements");
[90m  93 │ [39m                });
[90m  94 │ [39m
[90m  95 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
[90m  96 │ [39m                {
[90m  97 │ [39m                    b.Property<Guid>("Id")
[90m  98 │ [39m                        .ValueGeneratedOnAdd()
[90m  99 │ [39m                        .HasColumnType("uniqueidentifier");
[90m     … 211 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [90:43 - 305:33]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.Designer.cs [86:35 - 301:33]
[90m  90 │ [39m                    b.HasIndex("VehicleId");
[90m  91 │ [39m
[90m  92 │ [39m                    b.ToTable("RentalAgreements");
[90m  93 │ [39m                });
[90m  94 │ [39m
[90m  95 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
[90m  96 │ [39m                {
[90m  97 │ [39m                    b.Property<Guid>("Id")
[90m  98 │ [39m                        .ValueGeneratedOnAdd()
[90m  99 │ [39m                        .HasColumnType("uniqueidentifier");
[90m 100 │ [39m
[90m 101 │ [39m                    b.Property<int>("Class")
[90m 102 │ [39m                        .HasColumnType("int");
[90m 103 │ [39m
[90m 104 │ [39m                    b.Property<decimal>("DailyRate")
[90m 105 │ [39m                        .HasColumnType("decimal(18,2)");
[90m 106 │ [39m
[90m 107 │ [39m                    b.Property<string>("LicensePlate")
[90m 108 │ [39m                        .IsRequired()
[90m 109 │ [39m                        .HasColumnType("nvarchar(max)");
[90m     … 196 more lines[39m
[90m  86 │ [39m                        .IsUnique();
[90m  87 │ [39m
[90m  88 │ [39m                    b.ToTable("RentalAgreements");
[90m  89 │ [39m                });
[90m  90 │ [39m
[90m  91 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
[90m  92 │ [39m                {
[90m  93 │ [39m                    b.Property<Guid>("Id")
[90m  94 │ [39m                        .ValueGeneratedOnAdd()
[90m  95 │ [39m                        .HasColumnType("uniqueidentifier");
[90m  96 │ [39m
[90m  97 │ [39m                    b.Property<int>("Class")
[90m  98 │ [39m                        .HasColumnType("int");
[90m  99 │ [39m
[90m 100 │ [39m                    b.Property<decimal>("DailyRate")
[90m 101 │ [39m                        .HasColumnType("decimal(18,2)");
[90m 102 │ [39m
[90m 103 │ [39m                    b.Property<string>("LicensePlate")
[90m 104 │ [39m                        .IsRequired()
[90m 105 │ [39m                        .HasColumnType("nvarchar(max)");
[90m     … 196 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [317:37 - 384:2]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs [315:57 - 382:2]
[90m 317 │ [39m                        .IsRequired();
[90m 318 │ [39m
[90m 319 │ [39m                    b.Navigation("Customer");
[90m 320 │ [39m
[90m 321 │ [39m                    b.Navigation("Vehicle");
[90m 322 │ [39m                });
[90m 323 │ [39m
[90m 324 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
[90m 325 │ [39m                {
[90m 326 │ [39m                    b.OwnsMany("FleetTracker.Services.Core.Models.MaintenanceRecord", "MaintenanceHistory", b1 =>
[90m 327 │ [39m                        {
[90m 328 │ [39m                            b1.Property<Guid>("Id")
[90m 329 │ [39m                                .ValueGeneratedOnAdd()
[90m 330 │ [39m                                .HasColumnType("uniqueidentifier");
[90m 331 │ [39m
[90m 332 │ [39m                            b1.Property<decimal>("Cost")
[90m 333 │ [39m                                .HasColumnType("decimal(18,2)");
[90m 334 │ [39m
[90m 335 │ [39m                            b1.Property<string>("Description")
[90m 336 │ [39m                                .IsRequired()
[90m     … 48 more lines[39m
[90m 315 │ [39m                        .OnDelete(DeleteBehavior.SetNull);
[90m 316 │ [39m
[90m 317 │ [39m                    b.Navigation("Customer");
[90m 318 │ [39m
[90m 319 │ [39m                    b.Navigation("Vehicle");
[90m 320 │ [39m                });
[90m 321 │ [39m
[90m 322 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
[90m 323 │ [39m                {
[90m 324 │ [39m                    b.OwnsMany("FleetTracker.Services.Core.Models.MaintenanceRecord", "MaintenanceHistory", b1 =>
[90m 325 │ [39m                        {
[90m 326 │ [39m                            b1.Property<Guid>("Id")
[90m 327 │ [39m                                .ValueGeneratedOnAdd()
[90m 328 │ [39m                                .HasColumnType("uniqueidentifier");
[90m 329 │ [39m
[90m 330 │ [39m                            b1.Property<decimal>("Cost")
[90m 331 │ [39m                                .HasColumnType("decimal(18,2)");
[90m 332 │ [39m
[90m 333 │ [39m                            b1.Property<string>("Description")
[90m 334 │ [39m                                .IsRequired()
[90m     … 48 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [321:43 - 348:32]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.Designer.cs [298:37 - 325:32]
[90m 321 │ [39m                    b.Navigation("Vehicle");
[90m 322 │ [39m                });
[90m 323 │ [39m
[90m 324 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
[90m 325 │ [39m                {
[90m 326 │ [39m                    b.OwnsMany("FleetTracker.Services.Core.Models.MaintenanceRecord", "MaintenanceHistory", b1 =>
[90m 327 │ [39m                        {
[90m 328 │ [39m                            b1.Property<Guid>("Id")
[90m 329 │ [39m                                .ValueGeneratedOnAdd()
[90m 330 │ [39m                                .HasColumnType("uniqueidentifier");
[90m 331 │ [39m
[90m 332 │ [39m                            b1.Property<decimal>("Cost")
[90m 333 │ [39m                                .HasColumnType("decimal(18,2)");
[90m 334 │ [39m
[90m 335 │ [39m                            b1.Property<string>("Description")
[90m 336 │ [39m                                .IsRequired()
[90m 337 │ [39m                                .HasColumnType("nvarchar(max)");
[90m 338 │ [39m
[90m 339 │ [39m                            b1.Property<DateTime>("ServiceDate")
[90m 340 │ [39m                                .HasColumnType("datetime2");
[90m     … 8 more lines[39m
[90m 298 │ [39m                        .IsRequired();
[90m 299 │ [39m                });
[90m 300 │ [39m
[90m 301 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
[90m 302 │ [39m                {
[90m 303 │ [39m                    b.OwnsMany("FleetTracker.Services.Core.Models.MaintenanceRecord", "MaintenanceHistory", b1 =>
[90m 304 │ [39m                        {
[90m 305 │ [39m                            b1.Property<Guid>("Id")
[90m 306 │ [39m                                .ValueGeneratedOnAdd()
[90m 307 │ [39m                                .HasColumnType("uniqueidentifier");
[90m 308 │ [39m
[90m 309 │ [39m                            b1.Property<decimal>("Cost")
[90m 310 │ [39m                                .HasColumnType("decimal(18,2)");
[90m 311 │ [39m
[90m 312 │ [39m                            b1.Property<string>("Description")
[90m 313 │ [39m                                .IsRequired()
[90m 314 │ [39m                                .HasColumnType("nvarchar(max)");
[90m 315 │ [39m
[90m 316 │ [39m                            b1.Property<DateTime>("ServiceDate")
[90m 317 │ [39m                                .HasColumnType("datetime2");
[90m     … 8 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.cs [64:42 - 72:94]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.cs [18:43 - 26:94]
[90m  64 │ [39m                name: "MaintenanceRecord",
[90m  65 │ [39m                columns: table => new
[90m  66 │ [39m                {
[90m  67 │ [39m                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
[90m  68 │ [39m                    ServiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
[90m  69 │ [39m                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
[90m  70 │ [39m                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
[90m  71 │ [39m                    Type = table.Column<int>(type: "int", nullable: false),
[90m  72 │ [39m                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
[90m  18 │ [39m                name: "MaintenanceRecords",
[90m  19 │ [39m                columns: table => new
[90m  20 │ [39m                {
[90m  21 │ [39m                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
[90m  22 │ [39m                    ServiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
[90m  23 │ [39m                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
[90m  24 │ [39m                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
[90m  25 │ [39m                    Type = table.Column<int>(type: "int", nullable: false),
[90m  26 │ [39m                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.cs [73:93 - 91:30]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.cs [61:93 - 79:30]
[90m  73 │ [39m                    VehicleId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
[90m  74 │ [39m                },
[90m  75 │ [39m                constraints: table =>
[90m  76 │ [39m                {
[90m  77 │ [39m                    table.PrimaryKey("PK_MaintenanceRecord", x => x.Id);
[90m  78 │ [39m                    table.ForeignKey(
[90m  79 │ [39m                        name: "FK_MaintenanceRecord_Vehicles_VehicleId",
[90m  80 │ [39m                        column: x => x.VehicleId,
[90m  81 │ [39m                        principalTable: "Vehicles",
[90m  82 │ [39m                        principalColumn: "Id",
[90m  83 │ [39m                        onDelete: ReferentialAction.Cascade);
[90m  84 │ [39m                    table.ForeignKey(
[90m  85 │ [39m                        name: "FK_MaintenanceRecord_Vehicles_VehicleId1",
[90m  86 │ [39m                        column: x => x.VehicleId1,
[90m  87 │ [39m                        principalTable: "Vehicles",
[90m  88 │ [39m                        principalColumn: "Id");
[90m  89 │ [39m                });
[90m  90 │ [39m
[90m  91 │ [39m            migrationBuilder.CreateTable(
[90m  61 │ [39m                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
[90m  62 │ [39m                },
[90m  63 │ [39m                constraints: table =>
[90m  64 │ [39m                {
[90m  65 │ [39m                    table.PrimaryKey("PK_MaintenanceRecord", x => x.Id);
[90m  66 │ [39m                    table.ForeignKey(
[90m  67 │ [39m                        name: "FK_MaintenanceRecord_Vehicles_VehicleId",
[90m  68 │ [39m                        column: x => x.VehicleId,
[90m  69 │ [39m                        principalTable: "Vehicles",
[90m  70 │ [39m                        principalColumn: "Id",
[90m  71 │ [39m                        onDelete: ReferentialAction.Cascade);
[90m  72 │ [39m                    table.ForeignKey(
[90m  73 │ [39m                        name: "FK_MaintenanceRecord_Vehicles_VehicleId1",
[90m  74 │ [39m                        column: x => x.VehicleId1,
[90m  75 │ [39m                        principalTable: "Vehicles",
[90m  76 │ [39m                        principalColumn: "Id");
[90m  77 │ [39m                });
[90m  78 │ [39m
[90m  79 │ [39m            migrationBuilder.CreateIndex(

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs [302:37 - 322:33]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs [342:43 - 362:33]
[90m 302 │ [39m                        .IsRequired();
[90m 303 │ [39m                });
[90m 304 │ [39m
[90m 305 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
[90m 306 │ [39m                {
[90m 307 │ [39m                    b.HasOne("FleetTracker.Services.Core.Models.Customer", "Customer")
[90m 308 │ [39m                        .WithMany("RentalHistory")
[90m 309 │ [39m                        .HasForeignKey("CustomerId")
[90m 310 │ [39m                        .OnDelete(DeleteBehavior.SetNull);
[90m 311 │ [39m
[90m 312 │ [39m                    b.HasOne("FleetTracker.Services.Core.Models.Vehicle", "Vehicle")
[90m 313 │ [39m                        .WithMany("RentalHistory")
[90m 314 │ [39m                        .HasForeignKey("VehicleId")
[90m 315 │ [39m                        .OnDelete(DeleteBehavior.SetNull);
[90m 316 │ [39m
[90m 317 │ [39m                    b.Navigation("Customer");
[90m 318 │ [39m
[90m 319 │ [39m                    b.Navigation("Vehicle");
[90m 320 │ [39m                });
[90m 321 │ [39m
[90m     … 1 more lines[39m
[90m 342 │ [39m                    b.Navigation("Vehicle");
[90m 343 │ [39m                });
[90m 344 │ [39m
[90m 345 │ [39m            modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
[90m 346 │ [39m                {
[90m 347 │ [39m                    b.HasOne("FleetTracker.Services.Core.Models.Customer", "Customer")
[90m 348 │ [39m                        .WithMany("RentalHistory")
[90m 349 │ [39m                        .HasForeignKey("CustomerId")
[90m 350 │ [39m                        .OnDelete(DeleteBehavior.SetNull);
[90m 351 │ [39m
[90m 352 │ [39m                    b.HasOne("FleetTracker.Services.Core.Models.Vehicle", "Vehicle")
[90m 353 │ [39m                        .WithMany("RentalHistory")
[90m 354 │ [39m                        .HasForeignKey("VehicleId")
[90m 355 │ [39m                        .OnDelete(DeleteBehavior.SetNull);
[90m 356 │ [39m
[90m 357 │ [39m                    b.Navigation("Customer");
[90m 358 │ [39m
[90m 359 │ [39m                    b.Navigation("Vehicle");
[90m 360 │ [39m                });
[90m 361 │ [39m
[90m     … 1 more lines[39m

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.cs [12:35 - 26:26]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.cs [56:37 - 70:26]
[90m  12 │ [39m        protected override void Up(MigrationBuilder migrationBuilder)
[90m  13 │ [39m        {
[90m  14 │ [39m            migrationBuilder.DropForeignKey(
[90m  15 │ [39m                name: "FK_RentalAgreements_Customers_CustomerId",
[90m  16 │ [39m                table: "RentalAgreements");
[90m  17 │ [39m
[90m  18 │ [39m            migrationBuilder.DropForeignKey(
[90m  19 │ [39m                name: "FK_RentalAgreements_Vehicles_VehicleId",
[90m  20 │ [39m                table: "RentalAgreements");
[90m  21 │ [39m
[90m  22 │ [39m            migrationBuilder.AlterColumn<Guid>(
[90m  23 │ [39m                name: "VehicleId",
[90m  24 │ [39m                table: "RentalAgreements",
[90m  25 │ [39m                type: "uniqueidentifier",
[90m  26 │ [39m                nullable: true,
[90m  56 │ [39m        protected override void Down(MigrationBuilder migrationBuilder)
[90m  57 │ [39m        {
[90m  58 │ [39m            migrationBuilder.DropForeignKey(
[90m  59 │ [39m                name: "FK_RentalAgreements_Customers_CustomerId",
[90m  60 │ [39m                table: "RentalAgreements");
[90m  61 │ [39m
[90m  62 │ [39m            migrationBuilder.DropForeignKey(
[90m  63 │ [39m                name: "FK_RentalAgreements_Vehicles_VehicleId",
[90m  64 │ [39m                table: "RentalAgreements");
[90m  65 │ [39m
[90m  66 │ [39m            migrationBuilder.AlterColumn<Guid>(
[90m  67 │ [39m                name: "VehicleId",
[90m  68 │ [39m                table: "RentalAgreements",
[90m  69 │ [39m                type: "uniqueidentifier",
[90m  70 │ [39m                nullable: false,

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.cs [36:44 - 53:10]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.cs [41:36 - 58:10]
[90m  36 │ [39m                oldType: "uniqueidentifier");
[90m  37 │ [39m
[90m  38 │ [39m            migrationBuilder.AddForeignKey(
[90m  39 │ [39m                name: "FK_RentalAgreements_Customers_CustomerId",
[90m  40 │ [39m                table: "RentalAgreements",
[90m  41 │ [39m                column: "CustomerId",
[90m  42 │ [39m                principalTable: "Customers",
[90m  43 │ [39m                principalColumn: "Id",
[90m  44 │ [39m                onDelete: ReferentialAction.SetNull);
[90m  45 │ [39m
[90m  46 │ [39m            migrationBuilder.AddForeignKey(
[90m  47 │ [39m                name: "FK_RentalAgreements_Vehicles_VehicleId",
[90m  48 │ [39m                table: "RentalAgreements",
[90m  49 │ [39m                column: "VehicleId",
[90m  50 │ [39m                principalTable: "Vehicles",
[90m  51 │ [39m                principalColumn: "Id",
[90m  52 │ [39m                onDelete: ReferentialAction.SetNull);
[90m  53 │ [39m        }
[90m  41 │ [39m                column: "VehicleId");
[90m  42 │ [39m
[90m  43 │ [39m            migrationBuilder.AddForeignKey(
[90m  44 │ [39m                name: "FK_RentalAgreements_Customers_CustomerId",
[90m  45 │ [39m                table: "RentalAgreements",
[90m  46 │ [39m                column: "CustomerId",
[90m  47 │ [39m                principalTable: "Customers",
[90m  48 │ [39m                principalColumn: "Id",
[90m  49 │ [39m                onDelete: ReferentialAction.SetNull);
[90m  50 │ [39m
[90m  51 │ [39m            migrationBuilder.AddForeignKey(
[90m  52 │ [39m                name: "FK_RentalAgreements_Vehicles_VehicleId",
[90m  53 │ [39m                table: "RentalAgreements",
[90m  54 │ [39m                column: "VehicleId",
[90m  55 │ [39m                principalTable: "Vehicles",
[90m  56 │ [39m                principalColumn: "Id",
[90m  57 │ [39m                onDelete: ReferentialAction.SetNull);
[90m  58 │ [39m        }

[1mClone found (csharp)[22m
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.cs [24:71 - 30:38]
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.cs [59:75 - 65:38]
[90m  24 │ [39m                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
[90m  25 │ [39m                    Type = table.Column<int>(type: "int", nullable: false),
[90m  26 │ [39m                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
[90m  27 │ [39m                },
[90m  28 │ [39m                constraints: table =>
[90m  29 │ [39m                {
[90m  30 │ [39m                    table.PrimaryKey("PK_MaintenanceRecords", x => x.Id);
[90m  59 │ [39m                    ServiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
[90m  60 │ [39m                    Type = table.Column<int>(type: "int", nullable: false),
[90m  61 │ [39m                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
[90m  62 │ [39m                },
[90m  63 │ [39m                constraints: table =>
[90m  64 │ [39m                {
[90m  65 │ [39m                    table.PrimaryKey("PK_MaintenanceRecord", x => x.Id);

[90m┌────────────┬────────────────┬─────────────┬──────────────┬──────────────┬──────────────────┬───────────────────┐[39m
[90m│[39m[31m Format     [39m[90m│[39m[31m Files analyzed [39m[90m│[39m[31m Total lines [39m[90m│[39m[31m Total tokens [39m[90m│[39m[31m Clones found [39m[90m│[39m[31m Duplicated lines [39m[90m│[39m[31m Duplicated tokens [39m[90m│[39m
[90m├────────────┼────────────────┼─────────────┼──────────────┼──────────────┼──────────────────┼───────────────────┤[39m
[90m│[39m bash       [90m│[39m 9              [90m│[39m 694         [90m│[39m 2543         [90m│[39m 0            [90m│[39m 0 (0.00%)        [90m│[39m 0 (0.00%)         [90m│[39m
[90m├────────────┼────────────────┼─────────────┼──────────────┼──────────────┼──────────────────┼───────────────────┤[39m
[90m│[39m csharp     [90m│[39m 54             [90m│[39m 7714        [90m│[39m 41203        [90m│[39m 43           [90m│[39m 2985 (38.70%)    [90m│[39m 13919 (33.78%)    [90m│[39m
[90m├────────────┼────────────────┼─────────────┼──────────────┼──────────────┼──────────────────┼───────────────────┤[39m
[90m│[39m css        [90m│[39m 1              [90m│[39m 12          [90m│[39m 64           [90m│[39m 0            [90m│[39m 0 (0.00%)        [90m│[39m 0 (0.00%)         [90m│[39m
[90m├────────────┼────────────────┼─────────────┼──────────────┼──────────────┼──────────────────┼───────────────────┤[39m
[90m│[39m json       [90m│[39m 8              [90m│[39m 8825        [90m│[39m 27844        [90m│[39m 10           [90m│[39m 189 (2.14%)      [90m│[39m 592 (2.13%)       [90m│[39m
[90m├────────────┼────────────────┼─────────────┼──────────────┼──────────────┼──────────────────┼───────────────────┤[39m
[90m│[39m markup     [90m│[39m 6              [90m│[39m 278         [90m│[39m 2226         [90m│[39m 2            [90m│[39m 11 (3.96%)       [90m│[39m 127 (5.71%)       [90m│[39m
[90m├────────────┼────────────────┼─────────────┼──────────────┼──────────────┼──────────────────┼───────────────────┤[39m
[90m│[39m perl       [90m│[39m 1              [90m│[39m 168         [90m│[39m 662          [90m│[39m 0            [90m│[39m 0 (0.00%)        [90m│[39m 0 (0.00%)         [90m│[39m
[90m├────────────┼────────────────┼─────────────┼──────────────┼──────────────┼──────────────────┼───────────────────┤[39m
[90m│[39m sql        [90m│[39m 1              [90m│[39m 1166        [90m│[39m 58782        [90m│[39m 0            [90m│[39m 0 (0.00%)        [90m│[39m 0 (0.00%)         [90m│[39m
[90m├────────────┼────────────────┼─────────────┼──────────────┼──────────────┼──────────────────┼───────────────────┤[39m
[90m│[39m typescript [90m│[39m 16             [90m│[39m 1563        [90m│[39m 8591         [90m│[39m 7            [90m│[39m 49 (3.13%)       [90m│[39m 443 (5.16%)       [90m│[39m
[90m├────────────┼────────────────┼─────────────┼──────────────┼──────────────┼──────────────────┼───────────────────┤[39m
[90m│[39m yaml       [90m│[39m 2              [90m│[39m 149         [90m│[39m 474          [90m│[39m 0            [90m│[39m 0 (0.00%)        [90m│[39m 0 (0.00%)         [90m│[39m
[90m├────────────┼────────────────┼─────────────┼──────────────┼──────────────┼──────────────────┼───────────────────┤[39m
[90m│[39m [1mTotal:[22m     [90m│[39m 98             [90m│[39m 20569       [90m│[39m 142389       [90m│[39m 62           [90m│[39m 3234 (15.72%)    [90m│[39m 15081 (10.59%)    [90m│[39m
[90m└────────────┴────────────────┴─────────────┴──────────────┴──────────────┴──────────────────┴───────────────────┘[39m
[90mFound 62 clones.[39m
[90mtime: 278.564ms[39mUsing config from /action/lib/.automation/.jscpd.json
ERROR: jscpd found too many duplicates (15.7%) over threshold (0.0%)
```

</details>

<details>

<summary>TRIVY</summary>

```text

Report Summary

┌───────────────────────────────────────┬──────┬─────────────────┬───────────────────┬─────────┐
│                Target                 │ Type │ Vulnerabilities │ Misconfigurations │ Secrets │
├───────────────────────────────────────┼──────┼─────────────────┼───────────────────┼─────────┤
│ FleetTracker.Client/package-lock.json │ npm  │        4        │         -         │    -    │
└───────────────────────────────────────┴──────┴─────────────────┴───────────────────┴─────────┘
Legend:
- '-': Not scanned
- '0': Clean (no security findings detected)


For OSS Maintainers: VEX Notice
--------------------------------
If you're an OSS maintainer and Trivy has detected vulnerabilities in your project that you believe are not actually exploitable, consider issuing a VEX (Vulnerability Exploitability eXchange) statement.
VEX allows you to communicate the actual status of vulnerabilities in your project, improving security transparency and reducing false positives for your users.
Learn more and start using VEX: https://trivy.dev/docs/v0.71/guide/supply-chain/vex/repo#publishing-vex-documents

To disable this notice, set the TRIVY_DISABLE_VEX_NOTICE environment variable.


FleetTracker.Client/package-lock.json (npm)
===========================================
Total: 4 (UNKNOWN: 0, LOW: 0, MEDIUM: 1, HIGH: 3, CRITICAL: 0)

┌───────────────────┬────────────────┬──────────┬────────┬───────────────────┬──────────────────────────┬──────────────────────────────────────────────────────────┐
│      Library      │ Vulnerability  │ Severity │ Status │ Installed Version │      Fixed Version       │                          Title                           │
├───────────────────┼────────────────┼──────────┼────────┼───────────────────┼──────────────────────────┼──────────────────────────────────────────────────────────┤
│ @angular/common   │ CVE-2026-54266 │ HIGH     │ fixed  │ 21.2.16           │ 22.0.1, 21.2.17, 20.3.25 │ @angular/common: Weak 32-Bit Cache Key Hashing in        │
│                   │                │          │        │                   │                          │ `HttpTransferCache` Leading to Cross-Request Data...     │
│                   │                │          │        │                   │                          │ https://avd.aquasec.com/nvd/cve-2026-54266               │
│                   ├────────────────┤          │        │                   │                          ├──────────────────────────────────────────────────────────┤
│                   │ CVE-2026-54268 │          │        │                   │                          │ @angular/common: Denial of Service (DoS) via OOM in Date │
│                   │                │          │        │                   │                          │ Formatting (formatDate)                                  │
│                   │                │          │        │                   │                          │ https://avd.aquasec.com/nvd/cve-2026-54268               │
├───────────────────┼────────────────┼──────────┤        │                   │                          ├──────────────────────────────────────────────────────────┤
│ @angular/compiler │ CVE-2026-54265 │ MEDIUM   │        │                   │                          │ @angular/compiler: Two-Way Property Binding Sanitization │
│                   │                │          │        │                   │                          │ Bypass (XSS)                                             │
│                   │                │          │        │                   │                          │ https://avd.aquasec.com/nvd/cve-2026-54265               │
├───────────────────┼────────────────┼──────────┤        │                   │                          ├──────────────────────────────────────────────────────────┤
│ @angular/core     │ CVE-2026-54267 │ HIGH     │        │                   │                          │ Angular Client Hydration DOM Clobbering & Response-Cache │
│                   │                │          │        │                   │                          │ Poisoning                                                │
│                   │                │          │        │                   │                          │ https://avd.aquasec.com/nvd/cve-2026-54267               │
└───────────────────┴────────────────┴──────────┴────────┴───────────────────┴──────────────────────────┴──────────────────────────────────────────────────────────┘
```

</details>
