# Super-linter summary

| Language                   | Validation result |
| -------------------------- | ----------------- |
| BIOME_FORMAT               | Fail ❌           |
| BIOME_LINT                 | Fail ❌           |
| CHECKOV                    | Fail ❌           |
| CSHARP                     | Pass ✅           |
| CSS                        | Fail ❌           |
| CSS_PRETTIER               | Fail ❌           |
| EDITORCONFIG               | Fail ❌           |
| GITLEAKS                   | Pass ✅           |
| GIT_MERGE_CONFLICT_MARKERS | Pass ✅           |
| HTML                       | Fail ❌           |
| HTML_PRETTIER              | Fail ❌           |
| JAVASCRIPT_ES              | Pass ✅           |
| JAVASCRIPT_PRETTIER        | Fail ❌           |
| JSCPD                      | Fail ❌           |
| JSON                       | Fail ❌           |
| JSON_PRETTIER              | Fail ❌           |
| MARKDOWN                   | Pass ✅           |
| MARKDOWN_PRETTIER          | Fail ❌           |
| NATURAL_LANGUAGE           | Fail ❌           |
| PRE_COMMIT                 | Pass ✅           |
| SPELL_CODESPELL            | Fail ❌           |
| SQLFLUFF                   | Fail ❌           |
| TRIVY                      | Pass ✅           |
| TYPESCRIPT_ES              | Fail ❌           |
| TYPESCRIPT_PRETTIER        | Fail ❌           |

All files and directories linted successfully

For more information, see the [GitHub Actions workflow run](https://github.com/ethanlally/FleetTracker/actions/runs/27019568873)

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
    3    │ - ····target:·process.env.services__api__https__0·||·process.env.services__api__http__0·||·"https://localhost:7240",
    4    │ - ····secure:·false,
    5    │ - ····changeOrigin:·true
    6    │ - ··}
       2 │ + → "/api":·{
       3 │ + → → target:
       4 │ + → → → process.env.services__api__https__0·||
       5 │ + → → → process.env.services__api__http__0·||
       6 │ + → → → "https://localhost:7240",
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
Diagnostics not shown: 61.
Checked 42 files in 120ms. No fixes applied.
Found 38 errors.
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

  ! This parameter is unused.

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

  ! This parameter is unused.

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
       │     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    11 │   </div>
    12 │   <table border="1" cellpadding="5" cellspacing="0" style="width: 100%; text-align: left;">

  i The default type of a button is submit, which causes the submission of a form when placed inside a `form` element.

  i Allowed button types are: submit, button or reset


FleetTracker.Client/src/app/dashboard/dashboard.component.html:5:54 parse ━━━━━━━━━━━━━━━━━━━━━━━━━━

  × Text expressions aren't supported.

    3 │   <div>Loading...</div>
    4 │ } @else if (store.error()) {
  > 5 │   <div style="color: red; font-weight: bold;">Error: {{ store.error() }}</div>
      │                                                      ^^^^^^^^^^^^^^^^^^^
    6 │ } @else {
    7 │   <div style="display: flex; flex-direction: column; gap: 30px;">

  i Remove it or enable the parsing using the html.parser.interpolation option.


FleetTracker.Client/src/app/dashboard/dashboard.component.html:32:21 parse ━━━━━━━━━━━━━━━━━━━━━━━━━

  × Text expressions aren't supported.

    30 │             @for (vehicle of filteredAvailableVehicles; track vehicle.id) {
    31 │               <tr [routerLink]="['/vehicles', vehicle.vin]" style="cursor: pointer; background-color: #fafafa;">
  > 32 │                 <td>{{ vehicle.make }} {{ vehicle.model }} ({{ vehicle.licensePlate }})</td>
       │                     ^^^^^^^^^^^^^^^^^^
    33 │                 <td>{{ getStatusName(vehicle.status) }}</td>
    34 │                 <td>{{ vehicle.dailyRate | currency }}</td>

  i Remove it or enable the parsing using the html.parser.interpolation option.


FleetTracker.Client/src/app/dashboard/dashboard.component.html:32:40 parse ━━━━━━━━━━━━━━━━━━━━━━━━━

  × Text expressions aren't supported.

    30 │             @for (vehicle of filteredAvailableVehicles; track vehicle.id) {
    31 │               <tr [routerLink]="['/vehicles', vehicle.vin]" style="cursor: pointer; background-color: #fafafa;">
  > 32 │                 <td>{{ vehicle.make }} {{ vehicle.model }} ({{ vehicle.licensePlate }})</td>
       │                                        ^^^^^^^^^^^^^^^^^^^
    33 │                 <td>{{ getStatusName(vehicle.status) }}</td>
    34 │                 <td>{{ vehicle.dailyRate | currency }}</td>

  i Remove it or enable the parsing using the html.parser.interpolation option.


FleetTracker.Client/src/app/dashboard/dashboard.component.html:32:61 parse ━━━━━━━━━━━━━━━━━━━━━━━━━

  × Text expressions aren't supported.

    30 │             @for (vehicle of filteredAvailableVehicles; track vehicle.id) {
    31 │               <tr [routerLink]="['/vehicles', vehicle.vin]" style="cursor: pointer; background-color: #fafafa;">
  > 32 │                 <td>{{ vehicle.make }} {{ vehicle.model }} ({{ vehicle.licensePlate }})</td>
       │                                                             ^^^^^^^^^^^^^^^^^^^^^^^^^^
    33 │                 <td>{{ getStatusName(vehicle.status) }}</td>
    34 │                 <td>{{ vehicle.dailyRate | currency }}</td>

  i Remove it or enable the parsing using the html.parser.interpolation option.


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

<summary>CSS</summary>

```text

FleetTracker.Client/src/styles.css
  [2m2:6[22m  [31m[31m✖[39m  Expected no more than 1 declaration  [2mdeclaration-block-single-line-max-declarations[22m

[31m✖[39m 1 problem ([31m1 error[39m, [33m0 warnings[39m)
```

</details>

<details>

<summary>CSS_PRETTIER</summary>

```text
Checking formatting...[[33mwarn[39m] FleetTracker.Client/src/styles.css
[[33mwarn[39m] Code style issues found in the above file. Run Prettier with --write to fix.
```

</details>

<details>

<summary>EDITORCONFIG</summary>

```text
[33;1mFleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.Designer.cs:[33;0m
[31;1m	No final newline expected[33;0m
[31;1m	Not all lines have the correct end of line character[33;0m
[33;1mFleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153037_AddRentalIndexes.Designer.cs:[33;0m
[31;1m	No final newline expected[33;0m
[31;1m	Not all lines have the correct end of line character[33;0m
[33;1mFleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs:[33;0m
[31;1m	No final newline expected[33;0m
[31;1m	Not all lines have the correct end of line character[33;0m
[33;1mFleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153426_AddCustomerLicenseIndex.Designer.cs:[33;0m
[31;1m	No final newline expected[33;0m
[31;1m	Not all lines have the correct end of line character[33;0m
[33;1mFleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs:[33;0m
[31;1m	No final newline expected[33;0m
[31;1m	Not all lines have the correct end of line character[33;0m
[33;1mFleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs:[33;0m
[31;1m	No final newline expected[33;0m
[31;1m	Not all lines have the correct end of line character[33;0m
[33;1mFleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs:[33;0m
[31;1m	No final newline expected[33;0m
[31;1m	Not all lines have the correct end of line character[33;0m
[33;1mFleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs:[33;0m
[31;1m	No final newline expected[33;0m
[31;1m	Not all lines have the correct end of line character[33;0m
[33;1mFleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs:[33;0m
[31;1m	No final newline expected[33;0m
[31;1m	Not all lines have the correct end of line character[33;0m
[31;1m
18 errors found[33;0m
```

</details>

<details>

<summary>HTML</summary>

```text

   Config loaded: /action/lib/.automation/.htmlhintrc

   /github/workspace/FleetTracker.Client/src/app/dashboard/dashboard.component.html
[37m      L1 |[90m<h2>Dashboard Overview</h2>[39m
[37m          ^ [31mDoctype must be declared before any non-comment content. (doctype-first)[39m
[37m      L11 |[90m...     <div style="height: 200px;"><canvas #fleetChart></canvas></div>[39m
[37m                                                      ^ [31mThe attribute name of [ #fleetChart ] must be in lowercase. (attr-lowercase)[39m
[37m      L19 |[90m          <input type="text" [(ngModel)]="searchAvailable" placeholder="Search available..." style="p...[39m
[37m                                       ^ [31mThe attribute name of [ [(ngModel)] ] must be in lowercase. (attr-lowercase)[39m
[37m      L31 |[90m              <tr [routerLink]="['/vehicles', vehicle.vin]" style="cursor: pointer; background-color:...[39m
[37m                            ^ [31mThe attribute name of [ [routerLink] ] must be in lowercase. (attr-lowercase)[39m
[37m      L48 |[90m          <input type="text" [(ngModel)]="searchRented" placeholder="Search rented..." style="padding...[39m
[37m                                       ^ [31mThe attribute name of [ [(ngModel)] ] must be in lowercase. (attr-lowercase)[39m
[37m      L61 |[90m              <tr [routerLink]="rentalInfo.vehicle ? ['/vehicles', rentalInfo.vehicle.vin] : null" st...[39m
[37m                            ^ [31mThe attribute name of [ [routerLink] ] must be in lowercase. (attr-lowercase)[39m

   Config loaded: /action/lib/.automation/.htmlhintrc

   /github/workspace/FleetTracker.Client/src/app/app.component.html
[37m      L1 |[90m<div style="font-family: sans-serif; padding: 20px;">[39m
[37m          ^ [31mDoctype must be declared before any non-comment content. (doctype-first)[39m
[37m      L5 |[90m      routerLink="/dashboard"[39m
[37m          ^ [31mThe attribute name of [ routerLink ] must be in lowercase. (attr-lowercase)[39m
[37m      L6 |[90m      routerLinkActive="active"[39m
[37m          ^ [31mThe attribute name of [ routerLinkActive ] must be in lowercase. (attr-lowercase)[39m
[37m      L11 |[90m      routerLink="/vehicles"[39m
[37m           ^ [31mThe attribute name of [ routerLink ] must be in lowercase. (attr-lowercase)[39m
[37m      L12 |[90m      routerLinkActive="active"[39m
[37m           ^ [31mThe attribute name of [ routerLinkActive ] must be in lowercase. (attr-lowercase)[39m
[37m      L17 |[90m      routerLink="/rentals"[39m
[37m           ^ [31mThe attribute name of [ routerLink ] must be in lowercase. (attr-lowercase)[39m
[37m      L18 |[90m      routerLinkActive="active"[39m
[37m           ^ [31mThe attribute name of [ routerLinkActive ] must be in lowercase. (attr-lowercase)[39m
[37m      L23 |[90m      routerLink="/customers"[39m
[37m           ^ [31mThe attribute name of [ routerLink ] must be in lowercase. (attr-lowercase)[39m
[37m      L24 |[90m      routerLinkActive="active"[39m
[37m           ^ [31mThe attribute name of [ routerLinkActive ] must be in lowercase. (attr-lowercase)[39m

   Config loaded: /action/lib/.automation/.htmlhintrc

   /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.html
[37m      L1 |[90m<h2>Rentals</h2>[39m
[37m          ^ [31mDoctype must be declared before any non-comment content. (doctype-first)[39m
[37m      L10 |[90m      <select [(ngModel)]="statusFilter" style="padding: 8px;">[39m
[37m                        ^ [31mThe attribute name of [ [(ngModel)] ] must be in lowercase. (attr-lowercase)[39m
[37m      L15 |[90m      <input type="text" [(ngModel)]="searchQuery" placeholder="Search customer, vehicle, agreement.....[39m
[37m                                   ^ [31mThe attribute name of [ [(ngModel)] ] must be in lowercase. (attr-lowercase)[39m
[37m      L17 |[90m    <button routerLink="/rentals/new" style="padding: 8px 16px; cursor: pointer;">+ New Rental</butto...[39m
[37m                      ^ [31mThe attribute name of [ routerLink ] must be in lowercase. (attr-lowercase)[39m
[37m      L34 |[90m...ground-color: #fafafa; cursor: pointer;" [routerLink]="['/rentals', rental.id]">[39m
[37m                                                      ^ [31mThe attribute name of [ [routerLink] ] must be in lowercase. (attr-lowercase)[39m
[37m      L37 |[90m            <a [routerLink]="['/vehicles', rental.vehicleId]" (click)="$event.stopPropagation()" styl...[39m
[37m                         ^ [31mThe attribute name of [ [routerLink] ] must be in lowercase. (attr-lowercase)[39m
[37m      L42 |[90m            <a [routerLink]="['/customers', rental.customerId]" (click)="$event.stopPropagation()" st...[39m
[37m                         ^ [31mThe attribute name of [ [routerLink] ] must be in lowercase. (attr-lowercase)[39m

   Config loaded: /action/lib/.automation/.htmlhintrc

   /github/workspace/FleetTracker.Client/src/app/customers/customers.component.html
[37m      L1 |[90m<h2>Customers</h2>[39m
[37m          ^ [31mDoctype must be declared before any non-comment content. (doctype-first)[39m
[37m      L9 |[90m    <input type="text" [(ngModel)]="filterText" placeholder="Filter by name or email..." style="paddi...[39m
[37m                                ^ [31mThe attribute name of [ [(ngModel)] ] must be in lowercase. (attr-lowercase)[39m
[37m      L10 |[90m    <button routerLink="/customers/new" style="padding: 8px 16px; cursor: pointer;">+ New Customer</b...[39m
[37m                      ^ [31mThe attribute name of [ routerLink ] must be in lowercase. (attr-lowercase)[39m
[37m      L24 |[90m        <tr [routerLink]="['/customers', customer.id]" style="cursor: pointer; background-color: #faf...[39m
[37m                      ^ [31mThe attribute name of [ [routerLink] ] must be in lowercase. (attr-lowercase)[39m

   Config loaded: /action/lib/.automation/.htmlhintrc

   /github/workspace/FleetTracker.Client/src/app/vehicles/vehicles.component.html
[37m      L1 |[90m<h2>Vehicles</h2>[39m
[37m          ^ [31mDoctype must be declared before any non-comment content. (doctype-first)[39m
[37m      L10 |[90m      <select [(ngModel)]="statusFilter" style="padding: 8px;">[39m
[37m                        ^ [31mThe attribute name of [ [(ngModel)] ] must be in lowercase. (attr-lowercase)[39m
[37m      L17 |[90m      <input type="text" [(ngModel)]="searchQuery" placeholder="Search make, model, plate..." style="...[39m
[37m                                   ^ [31mThe attribute name of [ [(ngModel)] ] must be in lowercase. (attr-lowercase)[39m
[37m      L19 |[90m    <button routerLink="/vehicles/new" style="padding: 8px 16px; cursor: pointer;">+ New Vehicle</but...[39m
[37m                      ^ [31mThe attribute name of [ routerLink ] must be in lowercase. (attr-lowercase)[39m
[37m      L35 |[90m        <tr [routerLink]="['/vehicles', vehicle.vin]" style="cursor: pointer; background-color: #fafa...[39m
[37m                      ^ [31mThe attribute name of [ [routerLink] ] must be in lowercase. (attr-lowercase)[39m

   Config loaded: /action/lib/.automation/.htmlhintrc

   /github/workspace/FleetTracker.Client/src/index.html
[37m      L13 |[90m  <script>[39m
[37m             ^ [31mThe <script> tag cannot be used in a <head> tag. (head-script-disabled)[39m

Scanned 6 files, found 32 errors in 6 files (30 ms)
```

</details>

<details>

<summary>HTML_PRETTIER</summary>

```text
Checking formatting...[[33mwarn[39m] FleetTracker.Client/src/app/dashboard/dashboard.component.html
[[33mwarn[39m] FleetTracker.Client/src/app/app.component.html
[[33mwarn[39m] FleetTracker.Client/src/app/rentals/rentals.component.html
[[33mwarn[39m] FleetTracker.Client/src/app/customers/customers.component.html
[[33mwarn[39m] FleetTracker.Client/src/app/vehicles/vehicles.component.html
[[33mwarn[39m] FleetTracker.Client/src/index.html
[[33mwarn[39m] Code style issues found in 6 files. Run Prettier with --write to fix.
```

</details>

<details>

<summary>JAVASCRIPT_PRETTIER</summary>

```text
Checking formatting...[[33mwarn[39m] FleetTracker.Client/proxy.conf.js
[[33mwarn[39m] Code style issues found in the above file. Run Prettier with --write to fix.
```

</details>

<details>

<summary>JSCPD</summary>

```text
Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/store/fleet.store.ts [130:4 - 140:2] (10 lines, 97 tokens)
   /github/workspace/FleetTracker.Client/src/app/store/fleet.store.ts [118:8 - 127:2]

Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.ts [55:3 - 64:15] (9 lines, 101 tokens)
   /github/workspace/FleetTracker.Client/src/app/vehicles/vehicle-manage.component.ts [207:2 - 216:16]

Clone found (markup):
 - /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.html [4:11 - 11:8] (7 lines, 91 tokens)
   /github/workspace/FleetTracker.Client/src/app/vehicles/vehicles.component.html [4:12 - 11:9]

Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/rentals/rental-manage.component.ts [53:2 - 61:9] (8 lines, 86 tokens)
   /github/workspace/FleetTracker.Client/src/app/vehicles/vehicle-manage.component.ts [157:2 - 165:11]

Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/rentals/rental-manage.component.ts [80:5 - 87:2] (7 lines, 134 tokens)
   /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.ts [48:5 - 55:3]

Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/rentals/rental-manage.component.ts [87:2 - 96:15] (9 lines, 104 tokens)
   /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.ts [55:2 - 216:16]

Clone found (markup):
 - /github/workspace/FleetTracker.Client/src/app/dashboard/dashboard.component.html [48:17 - 55:6] (7 lines, 75 tokens)
   /github/workspace/FleetTracker.Client/src/app/dashboard/dashboard.component.html [19:20 - 26:6]

Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/customers/customer-manage.component.ts [115:2 - 123:11] (8 lines, 86 tokens)
   /github/workspace/FleetTracker.Client/src/app/vehicles/vehicle-manage.component.ts [157:2 - 165:11]

Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/customers/customer-manage.component.ts [169:13 - 178:17] (9 lines, 101 tokens)
   /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.ts [49:14 - 90:16]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [19:17 - 347:2] (328 lines, 2062 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [16:11 - 344:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153426_AddCustomerLicenseIndex.Designer.cs [1:2 - 15:41] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153426_AddCustomerLicenseIndex.Designer.cs [17:5 - 347:2] (330 lines, 2075 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 344:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153037_AddRentalIndexes.Designer.cs [1:2 - 15:34] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153037_AddRentalIndexes.Designer.cs [17:5 - 39:16] (22 lines, 141 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 36:16]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153037_AddRentalIndexes.Designer.cs [41:5 - 344:2] (303 lines, 1907 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [41:2 - 344:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.Designer.cs [1:2 - 15:39] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.Designer.cs [17:5 - 88:8] (71 lines, 453 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 88:9]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.Designer.cs [86:2 - 340:2] (254 lines, 1593 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [90:12 - 344:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.cs [59:12 - 65:23] (6 lines, 85 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.cs [24:16 - 30:24]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs [1:2 - 15:39] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs [17:5 - 46:54] (29 lines, 176 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 46:52]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs [72:21 - 334:54] (262 lines, 1657 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [43:12 - 305:44]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [1:2 - 15:42] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [17:5 - 305:52] (288 lines, 1819 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 305:44]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [302:2 - 322:44] (20 lines, 127 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs [342:10 - 362:45]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [319:10 - 346:9] (27 lines, 179 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [302:2 - 329:7]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.cs [36:19 - 55:19] (19 lines, 131 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.cs [41:12 - 59:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.cs [56:5 - 70:6] (14 lines, 101 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.cs [12:3 - 26:5]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs [1:2 - 15:39] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs [17:5 - 382:2] (365 lines, 2295 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 382:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.cs [64:20 - 72:2] (8 lines, 172 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.cs [18:21 - 27:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.cs [73:5 - 91:12] (18 lines, 157 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.cs [61:6 - 79:12]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [1:2 - 15:31] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [17:5 - 59:2] (42 lines, 266 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 59:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [59:5 - 80:2] (21 lines, 142 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [59:2 - 80:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [80:5 - 310:8] (230 lines, 1451 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [80:2 - 310:8]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [317:2 - 384:2] (67 lines, 397 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [315:8 - 382:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Core/DataModels/DataModels.cs [133:5 - 151:21] (18 lines, 193 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Core/DataModels/DataModels.cs [73:5 - 91:19]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [97:13 - 134:15] (37 lines, 369 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [53:13 - 90:16]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [249:35 - 255:16] (6 lines, 90 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [241:37 - 247:12]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/VehicleManager.cs [415:22 - 428:9] (13 lines, 104 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/VehicleManager.cs [160:14 - 174:20]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [179:13 - 188:19] (9 lines, 89 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [127:13 - 137:4]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [122:27 - 132:21] (10 lines, 94 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [68:36 - 78:9]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [150:9 - 162:8] (12 lines, 94 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/VehicleManager.cs [196:8 - 208:9]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [197:35 - 206:58] (9 lines, 96 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [68:36 - 78:2]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/RentalsController.cs [1:1 - 12:18] (11 lines, 96 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/VehiclesController.cs [1:1 - 12:19]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/CustomersController.cs [1:1 - 12:20] (11 lines, 96 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/VehiclesController.cs [1:1 - 12:19]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/CustomersController.cs [85:8 - 90:9] (5 lines, 133 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/CustomersController.cs [54:11 - 59:4]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/EfFleetRepository.cs [126:9 - 137:9] (11 lines, 102 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Repositories/InMemoryFleetRepository.cs [77:9 - 88:10]

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/EfFleetRepository.cs [184:12 - 196:9] (12 lines, 113 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Repositories/InMemoryFleetRepository.cs [105:7 - 117:2]

Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/store/fleet.store.ts [130:4 - 140:2] (10 lines, 97 tokens)
   /github/workspace/FleetTracker.Client/src/app/store/fleet.store.ts [118:8 - 127:2]

 130 │ 118 │ ).pipe(
 131 │ 119 │           tapResponse({
 132 │ 120 │             next: () => {
 133 │ 121 │               apiService.getVehicles().subscribe(vehicles => patchState(store, { vehicles }));
 134 │ 122 │             },
 135 │ 123 │             error: (err: Error) => patchState(store, { error: err.message })
 136 │ 124 │           })
 137 │ 125 │         ))
 138 │ 126 │       )
 139 │ 127 │     )
 140 │ 128 │   }

Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.ts [55:3 - 64:15] (9 lines, 101 tokens)
   /github/workspace/FleetTracker.Client/src/app/vehicles/vehicle-manage.component.ts [207:2 - 216:16]

 55 │ 207 │ ;
 56 │ 208 │   }
 57 │ 209 │
 58 │ 210 │   getCustomerName(id: string | undefined): string {
 59 │ 211 │     if (!id) return 'Unknown Customer';
 60 │ 212 │     const c = this.store.customers().find(x => x.id === id);
 61 │ 213 │     return c && c.contact ? c.contact.name || id : id;
 62 │ 214 │   }
 63 │ 215 │
 64 │ 216 │   completeRental

Clone found (markup):
 - /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.html [4:11 - 11:8] (7 lines, 91 tokens)
   /github/workspace/FleetTracker.Client/src/app/vehicles/vehicles.component.html [4:12 - 11:9]

 4  │ 4  │ </div>
 5  │ 5  │ } @else if (store.error()) {
 6  │ 6  │   <div style="color: red; font-weight: bold;">Error: {{ store.error() }}</div>
 7  │ 7  │ } @else {
 8  │ 8  │   <div style="display: flex; justify-content: space-between; align-items: center; margin-bottom: 20px;">
 9  │ 9  │     <div style="display: flex; gap: 10px; align-items: center;">
 10 │ 10 │       <select [(ngModel)]="statusFilter" style="padding: 8px;">
 11 │ 11 │         <option value="">All Rentals

Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/rentals/rental-manage.component.ts [53:2 - 61:9] (8 lines, 86 tokens)
   /github/workspace/FleetTracker.Client/src/app/vehicles/vehicle-manage.component.ts [157:2 - 165:11]

 53 │ 157 │ implements OnInit {
 54 │ 158 │   private fb = inject(FormBuilder);
 55 │ 159 │   private route = inject(ActivatedRoute);
 56 │ 160 │   private router = inject(Router);
 57 │ 161 │   private apiService = inject(ApiService);
 58 │ 162 │   private toast = inject(ToastService);
 59 │ 163 │   private store = inject(FleetStore);
 60 │ 164 │
 61 │ 165 │   rentalId

Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/rentals/rental-manage.component.ts [80:5 - 87:2] (7 lines, 134 tokens)
   /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.ts [48:5 - 55:3]

 80 │ 48 │ if (!this.store.vehicles().length) this.store.loadVehicles();
 81 │ 49 │     if (!this.store.customers().length) this.store.loadCustomers();
 82 │ 50 │   }
 83 │ 51 │
 84 │ 52 │   getVehicleName(id: string | undefined): string {
 85 │ 53 │     if (!id) return 'Unknown Vehicle';
 86 │ 54 │     const v = this.store.vehicles().find(x => x.id === id);
 87 │ 55 │     return v ? `${v.make} ${v.model}`

Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/rentals/rental-manage.component.ts [87:2 - 96:15] (9 lines, 104 tokens)
   /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.ts [55:2 - 216:16]

 87 │ 55 │ : id;
 88 │ 56 │   }
 89 │ 57 │
 90 │ 58 │   getCustomerName(id: string | undefined): string {
 91 │ 59 │     if (!id) return 'Unknown Customer';
 92 │ 60 │     const c = this.store.customers().find(x => x.id === id);
 93 │ 61 │     return c && c.contact ? c.contact.name || id : id;
 94 │ 62 │   }
 95 │ 63 │
 96 │ 64 │   loadRentalData

Clone found (markup):
 - /github/workspace/FleetTracker.Client/src/app/dashboard/dashboard.component.html [48:17 - 55:6] (7 lines, 75 tokens)
   /github/workspace/FleetTracker.Client/src/app/dashboard/dashboard.component.html [19:20 - 26:6]

 48 │ 19 │ " style="padding: 6px; width: 200px;">
 49 │ 20 │         </div>
 50 │ 21 │         <table border="1" cellpadding="5" cellspacing="0" style="width: 100%; text-align: left;">
 51 │ 22 │           <thead>
 52 │ 23 │             <tr>
 53 │ 24 │               <th>Name</th>
 54 │ 25 │               <th>Status</th>
 55 │ 26 │               <th>Start

Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/customers/customer-manage.component.ts [115:2 - 123:11] (8 lines, 86 tokens)
   /github/workspace/FleetTracker.Client/src/app/vehicles/vehicle-manage.component.ts [157:2 - 165:11]

 115 │ 157 │ implements OnInit {
 116 │ 158 │   private fb = inject(FormBuilder);
 117 │ 159 │   private route = inject(ActivatedRoute);
 118 │ 160 │   private router = inject(Router);
 119 │ 161 │   private apiService = inject(ApiService);
 120 │ 162 │   private toast = inject(ToastService);
 121 │ 163 │   private store = inject(FleetStore);
 122 │ 164 │
 123 │ 165 │   customerId

Clone found (typescript):
 - /github/workspace/FleetTracker.Client/src/app/customers/customer-manage.component.ts [169:13 - 178:17] (9 lines, 101 tokens)
   /github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.ts [49:14 - 90:16]

 169 │ 49 │ ();
 170 │ 50 │   }
 171 │ 51 │
 172 │ 52 │   getVehicleName(id: string | undefined): string {
 173 │ 53 │     if (!id) return 'Unknown Vehicle';
 174 │ 54 │     const v = this.store.vehicles().find(x => x.id === id);
 175 │ 55 │     return v ? `${v.make} ${v.model}` : id;
 176 │ 56 │   }
 177 │ 57 │
 178 │ 58 │   toggleSameAsHome

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [19:17 - 347:2] (328 lines, 2062 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [16:11 - 344:2]

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
 39  │ 36  │                         .HasColumnType("nvarchar(450)");
 40  │ 37  │
 41  │ 38  │                     b.HasKey("Id");
 42  │ 39  │
 43  │ 40  │                     b.HasIndex("DriversLicense")
 44  │ 41  │                         .IsUnique();
 45  │ 42  │
 46  │ 43  │                     b.ToTable("Customers");
 47  │ 44  │                 });
 48  │ 45  │
 49  │ 46  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
 50  │ 47  │                 {
 51  │ 48  │                     b.Property<Guid>("Id")
 52  │ 49  │                         .ValueGeneratedOnAdd()
 53  │ 50  │                         .HasColumnType("uniqueidentifier");
 54  │ 51  │
 55  │ 52  │                     b.Property<DateTime?>("ActualReturnDate")
 56  │ 53  │                         .HasColumnType("datetime2");
 57  │ 54  │
 58  │ 55  │                     b.Property<string>("AgreementNumber")
 59  │ 56  │                         .IsRequired()
 60  │ 57  │                         .HasColumnType("nvarchar(450)");
 61  │ 58  │
 62  │ 59  │                     b.Property<Guid?>("CustomerId")
 63  │ 60  │                         .HasColumnType("uniqueidentifier");
 64  │ 61  │
 65  │ 62  │                     b.Property<int?>("EndingMileage")
 66  │ 63  │                         .HasColumnType("int");
 67  │ 64  │
 68  │ 65  │                     b.Property<DateTime>("ExpectedReturnDate")
 69  │ 66  │                         .HasColumnType("datetime2");
 70  │ 67  │
 71  │ 68  │                     b.Property<DateTime>("PickupDate")
 72  │ 69  │                         .HasColumnType("datetime2");
 73  │ 70  │
 74  │ 71  │                     b.Property<int>("StartingMileage")
 75  │ 72  │                         .HasColumnType("int");
 76  │ 73  │
 77  │ 74  │                     b.Property<int>("Status")
 78  │ 75  │                         .HasColumnType("int");
 79  │ 76  │
 80  │ 77  │                     b.Property<decimal?>("TotalCost")
 81  │ 78  │                         .HasColumnType("decimal(18,2)");
 82  │ 79  │
 83  │ 80  │                     b.Property<Guid?>("VehicleId")
 84  │ 81  │                         .HasColumnType("uniqueidentifier");
 85  │ 82  │
 86  │ 83  │                     b.HasKey("Id");
 87  │ 84  │
 88  │ 85  │                     b.HasIndex("AgreementNumber")
 89  │ 86  │                         .IsUnique();
 90  │ 87  │
 91  │ 88  │                     b.HasIndex("CustomerId");
 92  │ 89  │
 93  │ 90  │                     b.HasIndex("VehicleId");
 94  │ 91  │
 95  │ 92  │                     b.ToTable("RentalAgreements");
 96  │ 93  │                 });
 97  │ 94  │
 98  │ 95  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 99  │ 96  │                 {
 100 │ 97  │                     b.Property<Guid>("Id")
 101 │ 98  │                         .ValueGeneratedOnAdd()
 102 │ 99  │                         .HasColumnType("uniqueidentifier");
 103 │ 100 │
 104 │ 101 │                     b.Property<int>("Class")
 105 │ 102 │                         .HasColumnType("int");
 106 │ 103 │
 107 │ 104 │                     b.Property<decimal>("DailyRate")
 108 │ 105 │                         .HasColumnType("decimal(18,2)");
 109 │ 106 │
 110 │ 107 │                     b.Property<string>("LicensePlate")
 111 │ 108 │                         .IsRequired()
 112 │ 109 │                         .HasColumnType("nvarchar(max)");
 113 │ 110 │
 114 │ 111 │                     b.Property<string>("Make")
 115 │ 112 │                         .IsRequired()
 116 │ 113 │                         .HasColumnType("nvarchar(max)");
 117 │ 114 │
 118 │ 115 │                     b.Property<string>("Model")
 119 │ 116 │                         .IsRequired()
 120 │ 117 │                         .HasColumnType("nvarchar(max)");
 121 │ 118 │
 122 │ 119 │                     b.Property<int>("Status")
 123 │ 120 │                         .HasColumnType("int");
 124 │ 121 │
 125 │ 122 │                     b.Property<string>("VIN")
 126 │ 123 │                         .IsRequired()
 127 │ 124 │                         .HasColumnType("nvarchar(450)");
 128 │ 125 │
 129 │ 126 │                     b.Property<int>("Year")
 130 │ 127 │                         .HasColumnType("int");
 131 │ 128 │
 132 │ 129 │                     b.HasKey("Id");
 133 │ 130 │
 134 │ 131 │                     b.HasIndex("VIN")
 135 │ 132 │                         .IsUnique();
 136 │ 133 │
 137 │ 134 │                     b.ToTable("Vehicles");
 138 │ 135 │                 });
 139 │ 136 │
 140 │ 137 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 141 │ 138 │                 {
 142 │ 139 │                     b.OwnsOne("FleetTracker.Services.Core.Models.ContactInfo", "Contact", b1 =>
 143 │ 140 │                         {
 144 │ 141 │                             b1.Property<Guid>("CustomerId")
 145 │ 142 │                                 .HasColumnType("uniqueidentifier");
 146 │ 143 │
 147 │ 144 │                             b1.Property<string>("Email")
 148 │ 145 │                                 .IsRequired()
 149 │ 146 │                                 .HasColumnType("nvarchar(max)")
 150 │ 147 │                                 .HasColumnName("ContactEmail");
 151 │ 148 │
 152 │ 149 │                             b1.Property<string>("Name")
 153 │ 150 │                                 .IsRequired()
 154 │ 151 │                                 .HasColumnType("nvarchar(max)")
 155 │ 152 │                                 .HasColumnName("ContactName");
 156 │ 153 │
 157 │ 154 │                             b1.Property<string>("PhoneNumber")
 158 │ 155 │                                 .IsRequired()
 159 │ 156 │                                 .HasColumnType("nvarchar(max)")
 160 │ 157 │                                 .HasColumnName("ContactPhone");
 161 │ 158 │
 162 │ 159 │                             b1.HasKey("CustomerId");
 163 │ 160 │
 164 │ 161 │                             b1.ToTable("Customers");
 165 │ 162 │
 166 │ 163 │                             b1.WithOwner()
 167 │ 164 │                                 .HasForeignKey("CustomerId");
 168 │ 165 │                         });
 169 │ 166 │
 170 │ 167 │                     b.OwnsOne("FleetTracker.Services.Core.Models.Address", "HomeAddress", b1 =>
 171 │ 168 │                         {
 172 │ 169 │                             b1.Property<Guid>("CustomerId")
 173 │ 170 │                                 .HasColumnType("uniqueidentifier");
 174 │ 171 │
 175 │ 172 │                             b1.Property<string>("City")
 176 │ 173 │                                 .IsRequired()
 177 │ 174 │                                 .HasColumnType("nvarchar(max)")
 178 │ 175 │                                 .HasColumnName("HomeCity");
 179 │ 176 │
 180 │ 177 │                             b1.Property<string>("Country")
 181 │ 178 │                                 .IsRequired()
 182 │ 179 │                                 .HasColumnType("nvarchar(max)")
 183 │ 180 │                                 .HasColumnName("HomeCountry");
 184 │ 181 │
 185 │ 182 │                             b1.Property<string>("State")
 186 │ 183 │                                 .IsRequired()
 187 │ 184 │                                 .HasColumnType("nvarchar(max)")
 188 │ 185 │                                 .HasColumnName("HomeState");
 189 │ 186 │
 190 │ 187 │                             b1.Property<string>("Street")
 191 │ 188 │                                 .IsRequired()
 192 │ 189 │                                 .HasColumnType("nvarchar(max)")
 193 │ 190 │                                 .HasColumnName("HomeStreet");
 194 │ 191 │
 195 │ 192 │                             b1.Property<string>("Zip")
 196 │ 193 │                                 .IsRequired()
 197 │ 194 │                                 .HasColumnType("nvarchar(max)")
 198 │ 195 │                                 .HasColumnName("HomeZip");
 199 │ 196 │
 200 │ 197 │                             b1.HasKey("CustomerId");
 201 │ 198 │
 202 │ 199 │                             b1.ToTable("Customers");
 203 │ 200 │
 204 │ 201 │                             b1.WithOwner()
 205 │ 202 │                                 .HasForeignKey("CustomerId");
 206 │ 203 │                         });
 207 │ 204 │
 208 │ 205 │                     b.OwnsOne("FleetTracker.Services.Core.Models.PaymentInformation", "PaymentInformation", b1 =>
 209 │ 206 │                         {
 210 │ 207 │                             b1.Property<Guid>("CustomerId")
 211 │ 208 │                                 .HasColumnType("uniqueidentifier");
 212 │ 209 │
 213 │ 210 │                             b1.HasKey("CustomerId");
 214 │ 211 │
 215 │ 212 │                             b1.ToTable("Customers");
 216 │ 213 │
 217 │ 214 │                             b1.WithOwner()
 218 │ 215 │                                 .HasForeignKey("CustomerId");
 219 │ 216 │
 220 │ 217 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.CreditCard", "CreditCard", b2 =>
 221 │ 218 │                                 {
 222 │ 219 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 223 │ 220 │                                         .HasColumnType("uniqueidentifier");
 224 │ 221 │
 225 │ 222 │                                     b2.Property<string>("CardHolderName")
 226 │ 223 │                                         .IsRequired()
 227 │ 224 │                                         .HasColumnType("nvarchar(max)")
 228 │ 225 │                                         .HasColumnName("CreditCardHolder");
 229 │ 226 │
 230 │ 227 │                                     b2.Property<string>("CardNumber")
 231 │ 228 │                                         .IsRequired()
 232 │ 229 │                                         .HasColumnType("nvarchar(max)")
 233 │ 230 │                                         .HasColumnName("CreditCardNumber");
 234 │ 231 │
 235 │ 232 │                                     b2.Property<string>("Cvv")
 236 │ 233 │                                         .IsRequired()
 237 │ 234 │                                         .HasColumnType("nvarchar(max)")
 238 │ 235 │                                         .HasColumnName("CreditCardCvv");
 239 │ 236 │
 240 │ 237 │                                     b2.Property<string>("ExpirationDate")
 241 │ 238 │                                         .IsRequired()
 242 │ 239 │                                         .HasColumnType("nvarchar(max)")
 243 │ 240 │                                         .HasColumnName("CreditCardExpiration");
 244 │ 241 │
 245 │ 242 │                                     b2.HasKey("PaymentInformationCustomerId");
 246 │ 243 │
 247 │ 244 │                                     b2.ToTable("Customers");
 248 │ 245 │
 249 │ 246 │                                     b2.WithOwner()
 250 │ 247 │                                         .HasForeignKey("PaymentInformationCustomerId");
 251 │ 248 │                                 });
 252 │ 249 │
 253 │ 250 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.Address", "BillingAddress", b2 =>
 254 │ 251 │                                 {
 255 │ 252 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 256 │ 253 │                                         .HasColumnType("uniqueidentifier");
 257 │ 254 │
 258 │ 255 │                                     b2.Property<string>("City")
 259 │ 256 │                                         .IsRequired()
 260 │ 257 │                                         .HasColumnType("nvarchar(max)")
 261 │ 258 │                                         .HasColumnName("BillingCity");
 262 │ 259 │
 263 │ 260 │                                     b2.Property<string>("Country")
 264 │ 261 │                                         .IsRequired()
 265 │ 262 │                                         .HasColumnType("nvarchar(max)")
 266 │ 263 │                                         .HasColumnName("BillingCountry");
 267 │ 264 │
 268 │ 265 │                                     b2.Property<string>("State")
 269 │ 266 │                                         .IsRequired()
 270 │ 267 │                                         .HasColumnType("nvarchar(max)")
 271 │ 268 │                                         .HasColumnName("BillingState");
 272 │ 269 │
 273 │ 270 │                                     b2.Property<string>("Street")
 274 │ 271 │                                         .IsRequired()
 275 │ 272 │                                         .HasColumnType("nvarchar(max)")
 276 │ 273 │                                         .HasColumnName("BillingStreet");
 277 │ 274 │
 278 │ 275 │                                     b2.Property<string>("Zip")
 279 │ 276 │                                         .IsRequired()
 280 │ 277 │                                         .HasColumnType("nvarchar(max)")
 281 │ 278 │                                         .HasColumnName("BillingZip");
 282 │ 279 │
 283 │ 280 │                                     b2.HasKey("PaymentInformationCustomerId");
 284 │ 281 │
 285 │ 282 │                                     b2.ToTable("Customers");
 286 │ 283 │
 287 │ 284 │                                     b2.WithOwner()
 288 │ 285 │                                         .HasForeignKey("PaymentInformationCustomerId");
 289 │ 286 │                                 });
 290 │ 287 │
 291 │ 288 │                             b1.Navigation("BillingAddress")
 292 │ 289 │                                 .IsRequired();
 293 │ 290 │
 294 │ 291 │                             b1.Navigation("CreditCard")
 295 │ 292 │                                 .IsRequired();
 296 │ 293 │                         });
 297 │ 294 │
 298 │ 295 │                     b.Navigation("Contact")
 299 │ 296 │                         .IsRequired();
 300 │ 297 │
 301 │ 298 │                     b.Navigation("HomeAddress")
 302 │ 299 │                         .IsRequired();
 303 │ 300 │
 304 │ 301 │                     b.Navigation("PaymentInformation")
 305 │ 302 │                         .IsRequired();
 306 │ 303 │                 });
 307 │ 304 │
 308 │ 305 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 309 │ 306 │                 {
 310 │ 307 │                     b.OwnsMany("FleetTracker.Services.Core.Models.MaintenanceRecord", "MaintenanceHistory", b1 =>
 311 │ 308 │                         {
 312 │ 309 │                             b1.Property<Guid>("Id")
 313 │ 310 │                                 .ValueGeneratedOnAdd()
 314 │ 311 │                                 .HasColumnType("uniqueidentifier");
 315 │ 312 │
 316 │ 313 │                             b1.Property<decimal>("Cost")
 317 │ 314 │                                 .HasColumnType("decimal(18,2)");
 318 │ 315 │
 319 │ 316 │                             b1.Property<string>("Description")
 320 │ 317 │                                 .IsRequired()
 321 │ 318 │                                 .HasColumnType("nvarchar(max)");
 322 │ 319 │
 323 │ 320 │                             b1.Property<DateTime>("ServiceDate")
 324 │ 321 │                                 .HasColumnType("datetime2");
 325 │ 322 │
 326 │ 323 │                             b1.Property<int>("Type")
 327 │ 324 │                                 .HasColumnType("int");
 328 │ 325 │
 329 │ 326 │                             b1.Property<Guid>("VehicleId")
 330 │ 327 │                                 .HasColumnType("uniqueidentifier");
 331 │ 328 │
 332 │ 329 │                             b1.HasKey("Id");
 333 │ 330 │
 334 │ 331 │                             b1.HasIndex("VehicleId");
 335 │ 332 │
 336 │ 333 │                             b1.ToTable("MaintenanceRecords", (string)null);
 337 │ 334 │
 338 │ 335 │                             b1.WithOwner()
 339 │ 336 │                                 .HasForeignKey("VehicleId");
 340 │ 337 │                         });
 341 │ 338 │
 342 │ 339 │                     b.Navigation("Maintenance

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153426_AddCustomerLicenseIndex.Designer.cs [1:2 - 15:41] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

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
 15 │ 15 │     [Migration("20260603153426_AddCust

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153426_AddCustomerLicenseIndex.Designer.cs [17:5 - 347:2] (330 lines, 2075 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 344:2]

 17  │ 17  │ LicenseIndex
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
 40  │ 40  │                         .HasColumnType("nvarchar(450)");
 41  │ 41  │
 42  │ 42  │                     b.HasKey("Id");
 43  │ 43  │
 44  │ 44  │                     b.HasIndex("DriversLicense")
 45  │ 45  │                         .IsUnique();
 46  │ 46  │
 47  │ 47  │                     b.ToTable("Customers");
 48  │ 48  │                 });
 49  │ 49  │
 50  │ 50  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
 51  │ 51  │                 {
 52  │ 52  │                     b.Property<Guid>("Id")
 53  │ 53  │                         .ValueGeneratedOnAdd()
 54  │ 54  │                         .HasColumnType("uniqueidentifier");
 55  │ 55  │
 56  │ 56  │                     b.Property<DateTime?>("ActualReturnDate")
 57  │ 57  │                         .HasColumnType("datetime2");
 58  │ 58  │
 59  │ 59  │                     b.Property<string>("AgreementNumber")
 60  │ 60  │                         .IsRequired()
 61  │ 61  │                         .HasColumnType("nvarchar(450)");
 62  │ 62  │
 63  │ 63  │                     b.Property<Guid?>("CustomerId")
 64  │ 64  │                         .HasColumnType("uniqueidentifier");
 65  │ 65  │
 66  │ 66  │                     b.Property<int?>("EndingMileage")
 67  │ 67  │                         .HasColumnType("int");
 68  │ 68  │
 69  │ 69  │                     b.Property<DateTime>("ExpectedReturnDate")
 70  │ 70  │                         .HasColumnType("datetime2");
 71  │ 71  │
 72  │ 72  │                     b.Property<DateTime>("PickupDate")
 73  │ 73  │                         .HasColumnType("datetime2");
 74  │ 74  │
 75  │ 75  │                     b.Property<int>("StartingMileage")
 76  │ 76  │                         .HasColumnType("int");
 77  │ 77  │
 78  │ 78  │                     b.Property<int>("Status")
 79  │ 79  │                         .HasColumnType("int");
 80  │ 80  │
 81  │ 81  │                     b.Property<decimal?>("TotalCost")
 82  │ 82  │                         .HasColumnType("decimal(18,2)");
 83  │ 83  │
 84  │ 84  │                     b.Property<Guid?>("VehicleId")
 85  │ 85  │                         .HasColumnType("uniqueidentifier");
 86  │ 86  │
 87  │ 87  │                     b.HasKey("Id");
 88  │ 88  │
 89  │ 89  │                     b.HasIndex("AgreementNumber")
 90  │ 90  │                         .IsUnique();
 91  │ 91  │
 92  │ 92  │                     b.HasIndex("CustomerId");
 93  │ 93  │
 94  │ 94  │                     b.HasIndex("VehicleId");
 95  │ 95  │
 96  │ 96  │                     b.ToTable("RentalAgreements");
 97  │ 97  │                 });
 98  │ 98  │
 99  │ 99  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 100 │ 100 │                 {
 101 │ 101 │                     b.Property<Guid>("Id")
 102 │ 102 │                         .ValueGeneratedOnAdd()
 103 │ 103 │                         .HasColumnType("uniqueidentifier");
 104 │ 104 │
 105 │ 105 │                     b.Property<int>("Class")
 106 │ 106 │                         .HasColumnType("int");
 107 │ 107 │
 108 │ 108 │                     b.Property<decimal>("DailyRate")
 109 │ 109 │                         .HasColumnType("decimal(18,2)");
 110 │ 110 │
 111 │ 111 │                     b.Property<string>("LicensePlate")
 112 │ 112 │                         .IsRequired()
 113 │ 113 │                         .HasColumnType("nvarchar(max)");
 114 │ 114 │
 115 │ 115 │                     b.Property<string>("Make")
 116 │ 116 │                         .IsRequired()
 117 │ 117 │                         .HasColumnType("nvarchar(max)");
 118 │ 118 │
 119 │ 119 │                     b.Property<string>("Model")
 120 │ 120 │                         .IsRequired()
 121 │ 121 │                         .HasColumnType("nvarchar(max)");
 122 │ 122 │
 123 │ 123 │                     b.Property<int>("Status")
 124 │ 124 │                         .HasColumnType("int");
 125 │ 125 │
 126 │ 126 │                     b.Property<string>("VIN")
 127 │ 127 │                         .IsRequired()
 128 │ 128 │                         .HasColumnType("nvarchar(450)");
 129 │ 129 │
 130 │ 130 │                     b.Property<int>("Year")
 131 │ 131 │                         .HasColumnType("int");
 132 │ 132 │
 133 │ 133 │                     b.HasKey("Id");
 134 │ 134 │
 135 │ 135 │                     b.HasIndex("VIN")
 136 │ 136 │                         .IsUnique();
 137 │ 137 │
 138 │ 138 │                     b.ToTable("Vehicles");
 139 │ 139 │                 });
 140 │ 140 │
 141 │ 141 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 142 │ 142 │                 {
 143 │ 143 │                     b.OwnsOne("FleetTracker.Services.Core.Models.ContactInfo", "Contact", b1 =>
 144 │ 144 │                         {
 145 │ 145 │                             b1.Property<Guid>("CustomerId")
 146 │ 146 │                                 .HasColumnType("uniqueidentifier");
 147 │ 147 │
 148 │ 148 │                             b1.Property<string>("Email")
 149 │ 149 │                                 .IsRequired()
 150 │ 150 │                                 .HasColumnType("nvarchar(max)")
 151 │ 151 │                                 .HasColumnName("ContactEmail");
 152 │ 152 │
 153 │ 153 │                             b1.Property<string>("Name")
 154 │ 154 │                                 .IsRequired()
 155 │ 155 │                                 .HasColumnType("nvarchar(max)")
 156 │ 156 │                                 .HasColumnName("ContactName");
 157 │ 157 │
 158 │ 158 │                             b1.Property<string>("PhoneNumber")
 159 │ 159 │                                 .IsRequired()
 160 │ 160 │                                 .HasColumnType("nvarchar(max)")
 161 │ 161 │                                 .HasColumnName("ContactPhone");
 162 │ 162 │
 163 │ 163 │                             b1.HasKey("CustomerId");
 164 │ 164 │
 165 │ 165 │                             b1.ToTable("Customers");
 166 │ 166 │
 167 │ 167 │                             b1.WithOwner()
 168 │ 168 │                                 .HasForeignKey("CustomerId");
 169 │ 169 │                         });
 170 │ 170 │
 171 │ 171 │                     b.OwnsOne("FleetTracker.Services.Core.Models.Address", "HomeAddress", b1 =>
 172 │ 172 │                         {
 173 │ 173 │                             b1.Property<Guid>("CustomerId")
 174 │ 174 │                                 .HasColumnType("uniqueidentifier");
 175 │ 175 │
 176 │ 176 │                             b1.Property<string>("City")
 177 │ 177 │                                 .IsRequired()
 178 │ 178 │                                 .HasColumnType("nvarchar(max)")
 179 │ 179 │                                 .HasColumnName("HomeCity");
 180 │ 180 │
 181 │ 181 │                             b1.Property<string>("Country")
 182 │ 182 │                                 .IsRequired()
 183 │ 183 │                                 .HasColumnType("nvarchar(max)")
 184 │ 184 │                                 .HasColumnName("HomeCountry");
 185 │ 185 │
 186 │ 186 │                             b1.Property<string>("State")
 187 │ 187 │                                 .IsRequired()
 188 │ 188 │                                 .HasColumnType("nvarchar(max)")
 189 │ 189 │                                 .HasColumnName("HomeState");
 190 │ 190 │
 191 │ 191 │                             b1.Property<string>("Street")
 192 │ 192 │                                 .IsRequired()
 193 │ 193 │                                 .HasColumnType("nvarchar(max)")
 194 │ 194 │                                 .HasColumnName("HomeStreet");
 195 │ 195 │
 196 │ 196 │                             b1.Property<string>("Zip")
 197 │ 197 │                                 .IsRequired()
 198 │ 198 │                                 .HasColumnType("nvarchar(max)")
 199 │ 199 │                                 .HasColumnName("HomeZip");
 200 │ 200 │
 201 │ 201 │                             b1.HasKey("CustomerId");
 202 │ 202 │
 203 │ 203 │                             b1.ToTable("Customers");
 204 │ 204 │
 205 │ 205 │                             b1.WithOwner()
 206 │ 206 │                                 .HasForeignKey("CustomerId");
 207 │ 207 │                         });
 208 │ 208 │
 209 │ 209 │                     b.OwnsOne("FleetTracker.Services.Core.Models.PaymentInformation", "PaymentInformation", b1 =>
 210 │ 210 │                         {
 211 │ 211 │                             b1.Property<Guid>("CustomerId")
 212 │ 212 │                                 .HasColumnType("uniqueidentifier");
 213 │ 213 │
 214 │ 214 │                             b1.HasKey("CustomerId");
 215 │ 215 │
 216 │ 216 │                             b1.ToTable("Customers");
 217 │ 217 │
 218 │ 218 │                             b1.WithOwner()
 219 │ 219 │                                 .HasForeignKey("CustomerId");
 220 │ 220 │
 221 │ 221 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.CreditCard", "CreditCard", b2 =>
 222 │ 222 │                                 {
 223 │ 223 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 224 │ 224 │                                         .HasColumnType("uniqueidentifier");
 225 │ 225 │
 226 │ 226 │                                     b2.Property<string>("CardHolderName")
 227 │ 227 │                                         .IsRequired()
 228 │ 228 │                                         .HasColumnType("nvarchar(max)")
 229 │ 229 │                                         .HasColumnName("CreditCardHolder");
 230 │ 230 │
 231 │ 231 │                                     b2.Property<string>("CardNumber")
 232 │ 232 │                                         .IsRequired()
 233 │ 233 │                                         .HasColumnType("nvarchar(max)")
 234 │ 234 │                                         .HasColumnName("CreditCardNumber");
 235 │ 235 │
 236 │ 236 │                                     b2.Property<string>("Cvv")
 237 │ 237 │                                         .IsRequired()
 238 │ 238 │                                         .HasColumnType("nvarchar(max)")
 239 │ 239 │                                         .HasColumnName("CreditCardCvv");
 240 │ 240 │
 241 │ 241 │                                     b2.Property<string>("ExpirationDate")
 242 │ 242 │                                         .IsRequired()
 243 │ 243 │                                         .HasColumnType("nvarchar(max)")
 244 │ 244 │                                         .HasColumnName("CreditCardExpiration");
 245 │ 245 │
 246 │ 246 │                                     b2.HasKey("PaymentInformationCustomerId");
 247 │ 247 │
 248 │ 248 │                                     b2.ToTable("Customers");
 249 │ 249 │
 250 │ 250 │                                     b2.WithOwner()
 251 │ 251 │                                         .HasForeignKey("PaymentInformationCustomerId");
 252 │ 252 │                                 });
 253 │ 253 │
 254 │ 254 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.Address", "BillingAddress", b2 =>
 255 │ 255 │                                 {
 256 │ 256 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 257 │ 257 │                                         .HasColumnType("uniqueidentifier");
 258 │ 258 │
 259 │ 259 │                                     b2.Property<string>("City")
 260 │ 260 │                                         .IsRequired()
 261 │ 261 │                                         .HasColumnType("nvarchar(max)")
 262 │ 262 │                                         .HasColumnName("BillingCity");
 263 │ 263 │
 264 │ 264 │                                     b2.Property<string>("Country")
 265 │ 265 │                                         .IsRequired()
 266 │ 266 │                                         .HasColumnType("nvarchar(max)")
 267 │ 267 │                                         .HasColumnName("BillingCountry");
 268 │ 268 │
 269 │ 269 │                                     b2.Property<string>("State")
 270 │ 270 │                                         .IsRequired()
 271 │ 271 │                                         .HasColumnType("nvarchar(max)")
 272 │ 272 │                                         .HasColumnName("BillingState");
 273 │ 273 │
 274 │ 274 │                                     b2.Property<string>("Street")
 275 │ 275 │                                         .IsRequired()
 276 │ 276 │                                         .HasColumnType("nvarchar(max)")
 277 │ 277 │                                         .HasColumnName("BillingStreet");
 278 │ 278 │
 279 │ 279 │                                     b2.Property<string>("Zip")
 280 │ 280 │                                         .IsRequired()
 281 │ 281 │                                         .HasColumnType("nvarchar(max)")
 282 │ 282 │                                         .HasColumnName("BillingZip");
 283 │ 283 │
 284 │ 284 │                                     b2.HasKey("PaymentInformationCustomerId");
 285 │ 285 │
 286 │ 286 │                                     b2.ToTable("Customers");
 287 │ 287 │
 288 │ 288 │                                     b2.WithOwner()
 289 │ 289 │                                         .HasForeignKey("PaymentInformationCustomerId");
 290 │ 290 │                                 });
 291 │ 291 │
 292 │ 292 │                             b1.Navigation("BillingAddress")
 293 │ 293 │                                 .IsRequired();
 294 │ 294 │
 295 │ 295 │                             b1.Navigation("CreditCard")
 296 │ 296 │                                 .IsRequired();
 297 │ 297 │                         });
 298 │ 298 │
 299 │ 299 │                     b.Navigation("Contact")
 300 │ 300 │                         .IsRequired();
 301 │ 301 │
 302 │ 302 │                     b.Navigation("HomeAddress")
 303 │ 303 │                         .IsRequired();
 304 │ 304 │
 305 │ 305 │                     b.Navigation("PaymentInformation")
 306 │ 306 │                         .IsRequired();
 307 │ 307 │                 });
 308 │ 308 │
 309 │ 309 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 310 │ 310 │                 {
 311 │ 311 │                     b.OwnsMany("FleetTracker.Services.Core.Models.MaintenanceRecord", "MaintenanceHistory", b1 =>
 312 │ 312 │                         {
 313 │ 313 │                             b1.Property<Guid>("Id")
 314 │ 314 │                                 .ValueGeneratedOnAdd()
 315 │ 315 │                                 .HasColumnType("uniqueidentifier");
 316 │ 316 │
 317 │ 317 │                             b1.Property<decimal>("Cost")
 318 │ 318 │                                 .HasColumnType("decimal(18,2)");
 319 │ 319 │
 320 │ 320 │                             b1.Property<string>("Description")
 321 │ 321 │                                 .IsRequired()
 322 │ 322 │                                 .HasColumnType("nvarchar(max)");
 323 │ 323 │
 324 │ 324 │                             b1.Property<DateTime>("ServiceDate")
 325 │ 325 │                                 .HasColumnType("datetime2");
 326 │ 326 │
 327 │ 327 │                             b1.Property<int>("Type")
 328 │ 328 │                                 .HasColumnType("int");
 329 │ 329 │
 330 │ 330 │                             b1.Property<Guid>("VehicleId")
 331 │ 331 │                                 .HasColumnType("uniqueidentifier");
 332 │ 332 │
 333 │ 333 │                             b1.HasKey("Id");
 334 │ 334 │
 335 │ 335 │                             b1.HasIndex("VehicleId");
 336 │ 336 │
 337 │ 337 │                             b1.ToTable("MaintenanceRecords", (string)null);
 338 │ 338 │
 339 │ 339 │                             b1.WithOwner()
 340 │ 340 │                                 .HasForeignKey("VehicleId");
 341 │ 341 │                         });
 342 │ 342 │
 343 │ 343 │                     b.Navigation("Maintenance

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153037_AddRentalIndexes.Designer.cs [1:2 - 15:34] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

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
 15 │ 15 │     [Migration("20260603153037_

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153037_AddRentalIndexes.Designer.cs [17:5 - 39:16] (22 lines, 141 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 36:16]

 17 │ 17 │ entalIndexes
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
 40 │ 40 │

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153037_AddRentalIndexes.Designer.cs [41:5 - 344:2] (303 lines, 1907 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [41:2 - 344:2]

 41  │ 41  │ archar(max)");
 42  │ 42  │
 43  │ 43  │                     b.HasKey("Id");
 44  │ 44  │
 45  │ 45  │                     b.ToTable("Customers");
 46  │ 46  │                 });
 47  │ 47  │
 48  │ 48  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
 49  │ 49  │                 {
 50  │ 50  │                     b.Property<Guid>("Id")
 51  │ 51  │                         .ValueGeneratedOnAdd()
 52  │ 52  │                         .HasColumnType("uniqueidentifier");
 53  │ 53  │
 54  │ 54  │                     b.Property<DateTime?>("ActualReturnDate")
 55  │ 55  │                         .HasColumnType("datetime2");
 56  │ 56  │
 57  │ 57  │                     b.Property<string>("AgreementNumber")
 58  │ 58  │                         .IsRequired()
 59  │ 59  │                         .HasColumnType("nvarchar(450)");
 60  │ 60  │
 61  │ 61  │                     b.Property<Guid?>("CustomerId")
 62  │ 62  │                         .HasColumnType("uniqueidentifier");
 63  │ 63  │
 64  │ 64  │                     b.Property<int?>("EndingMileage")
 65  │ 65  │                         .HasColumnType("int");
 66  │ 66  │
 67  │ 67  │                     b.Property<DateTime>("ExpectedReturnDate")
 68  │ 68  │                         .HasColumnType("datetime2");
 69  │ 69  │
 70  │ 70  │                     b.Property<DateTime>("PickupDate")
 71  │ 71  │                         .HasColumnType("datetime2");
 72  │ 72  │
 73  │ 73  │                     b.Property<int>("StartingMileage")
 74  │ 74  │                         .HasColumnType("int");
 75  │ 75  │
 76  │ 76  │                     b.Property<int>("Status")
 77  │ 77  │                         .HasColumnType("int");
 78  │ 78  │
 79  │ 79  │                     b.Property<decimal?>("TotalCost")
 80  │ 80  │                         .HasColumnType("decimal(18,2)");
 81  │ 81  │
 82  │ 82  │                     b.Property<Guid?>("VehicleId")
 83  │ 83  │                         .HasColumnType("uniqueidentifier");
 84  │ 84  │
 85  │ 85  │                     b.HasKey("Id");
 86  │ 86  │
 87  │ 87  │                     b.HasIndex("AgreementNumber")
 88  │ 88  │                         .IsUnique();
 89  │ 89  │
 90  │ 90  │                     b.HasIndex("CustomerId");
 91  │ 91  │
 92  │ 92  │                     b.HasIndex("VehicleId");
 93  │ 93  │
 94  │ 94  │                     b.ToTable("RentalAgreements");
 95  │ 95  │                 });
 96  │ 96  │
 97  │ 97  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 98  │ 98  │                 {
 99  │ 99  │                     b.Property<Guid>("Id")
 100 │ 100 │                         .ValueGeneratedOnAdd()
 101 │ 101 │                         .HasColumnType("uniqueidentifier");
 102 │ 102 │
 103 │ 103 │                     b.Property<int>("Class")
 104 │ 104 │                         .HasColumnType("int");
 105 │ 105 │
 106 │ 106 │                     b.Property<decimal>("DailyRate")
 107 │ 107 │                         .HasColumnType("decimal(18,2)");
 108 │ 108 │
 109 │ 109 │                     b.Property<string>("LicensePlate")
 110 │ 110 │                         .IsRequired()
 111 │ 111 │                         .HasColumnType("nvarchar(max)");
 112 │ 112 │
 113 │ 113 │                     b.Property<string>("Make")
 114 │ 114 │                         .IsRequired()
 115 │ 115 │                         .HasColumnType("nvarchar(max)");
 116 │ 116 │
 117 │ 117 │                     b.Property<string>("Model")
 118 │ 118 │                         .IsRequired()
 119 │ 119 │                         .HasColumnType("nvarchar(max)");
 120 │ 120 │
 121 │ 121 │                     b.Property<int>("Status")
 122 │ 122 │                         .HasColumnType("int");
 123 │ 123 │
 124 │ 124 │                     b.Property<string>("VIN")
 125 │ 125 │                         .IsRequired()
 126 │ 126 │                         .HasColumnType("nvarchar(450)");
 127 │ 127 │
 128 │ 128 │                     b.Property<int>("Year")
 129 │ 129 │                         .HasColumnType("int");
 130 │ 130 │
 131 │ 131 │                     b.HasKey("Id");
 132 │ 132 │
 133 │ 133 │                     b.HasIndex("VIN")
 134 │ 134 │                         .IsUnique();
 135 │ 135 │
 136 │ 136 │                     b.ToTable("Vehicles");
 137 │ 137 │                 });
 138 │ 138 │
 139 │ 139 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 140 │ 140 │                 {
 141 │ 141 │                     b.OwnsOne("FleetTracker.Services.Core.Models.ContactInfo", "Contact", b1 =>
 142 │ 142 │                         {
 143 │ 143 │                             b1.Property<Guid>("CustomerId")
 144 │ 144 │                                 .HasColumnType("uniqueidentifier");
 145 │ 145 │
 146 │ 146 │                             b1.Property<string>("Email")
 147 │ 147 │                                 .IsRequired()
 148 │ 148 │                                 .HasColumnType("nvarchar(max)")
 149 │ 149 │                                 .HasColumnName("ContactEmail");
 150 │ 150 │
 151 │ 151 │                             b1.Property<string>("Name")
 152 │ 152 │                                 .IsRequired()
 153 │ 153 │                                 .HasColumnType("nvarchar(max)")
 154 │ 154 │                                 .HasColumnName("ContactName");
 155 │ 155 │
 156 │ 156 │                             b1.Property<string>("PhoneNumber")
 157 │ 157 │                                 .IsRequired()
 158 │ 158 │                                 .HasColumnType("nvarchar(max)")
 159 │ 159 │                                 .HasColumnName("ContactPhone");
 160 │ 160 │
 161 │ 161 │                             b1.HasKey("CustomerId");
 162 │ 162 │
 163 │ 163 │                             b1.ToTable("Customers");
 164 │ 164 │
 165 │ 165 │                             b1.WithOwner()
 166 │ 166 │                                 .HasForeignKey("CustomerId");
 167 │ 167 │                         });
 168 │ 168 │
 169 │ 169 │                     b.OwnsOne("FleetTracker.Services.Core.Models.Address", "HomeAddress", b1 =>
 170 │ 170 │                         {
 171 │ 171 │                             b1.Property<Guid>("CustomerId")
 172 │ 172 │                                 .HasColumnType("uniqueidentifier");
 173 │ 173 │
 174 │ 174 │                             b1.Property<string>("City")
 175 │ 175 │                                 .IsRequired()
 176 │ 176 │                                 .HasColumnType("nvarchar(max)")
 177 │ 177 │                                 .HasColumnName("HomeCity");
 178 │ 178 │
 179 │ 179 │                             b1.Property<string>("Country")
 180 │ 180 │                                 .IsRequired()
 181 │ 181 │                                 .HasColumnType("nvarchar(max)")
 182 │ 182 │                                 .HasColumnName("HomeCountry");
 183 │ 183 │
 184 │ 184 │                             b1.Property<string>("State")
 185 │ 185 │                                 .IsRequired()
 186 │ 186 │                                 .HasColumnType("nvarchar(max)")
 187 │ 187 │                                 .HasColumnName("HomeState");
 188 │ 188 │
 189 │ 189 │                             b1.Property<string>("Street")
 190 │ 190 │                                 .IsRequired()
 191 │ 191 │                                 .HasColumnType("nvarchar(max)")
 192 │ 192 │                                 .HasColumnName("HomeStreet");
 193 │ 193 │
 194 │ 194 │                             b1.Property<string>("Zip")
 195 │ 195 │                                 .IsRequired()
 196 │ 196 │                                 .HasColumnType("nvarchar(max)")
 197 │ 197 │                                 .HasColumnName("HomeZip");
 198 │ 198 │
 199 │ 199 │                             b1.HasKey("CustomerId");
 200 │ 200 │
 201 │ 201 │                             b1.ToTable("Customers");
 202 │ 202 │
 203 │ 203 │                             b1.WithOwner()
 204 │ 204 │                                 .HasForeignKey("CustomerId");
 205 │ 205 │                         });
 206 │ 206 │
 207 │ 207 │                     b.OwnsOne("FleetTracker.Services.Core.Models.PaymentInformation", "PaymentInformation", b1 =>
 208 │ 208 │                         {
 209 │ 209 │                             b1.Property<Guid>("CustomerId")
 210 │ 210 │                                 .HasColumnType("uniqueidentifier");
 211 │ 211 │
 212 │ 212 │                             b1.HasKey("CustomerId");
 213 │ 213 │
 214 │ 214 │                             b1.ToTable("Customers");
 215 │ 215 │
 216 │ 216 │                             b1.WithOwner()
 217 │ 217 │                                 .HasForeignKey("CustomerId");
 218 │ 218 │
 219 │ 219 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.CreditCard", "CreditCard", b2 =>
 220 │ 220 │                                 {
 221 │ 221 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 222 │ 222 │                                         .HasColumnType("uniqueidentifier");
 223 │ 223 │
 224 │ 224 │                                     b2.Property<string>("CardHolderName")
 225 │ 225 │                                         .IsRequired()
 226 │ 226 │                                         .HasColumnType("nvarchar(max)")
 227 │ 227 │                                         .HasColumnName("CreditCardHolder");
 228 │ 228 │
 229 │ 229 │                                     b2.Property<string>("CardNumber")
 230 │ 230 │                                         .IsRequired()
 231 │ 231 │                                         .HasColumnType("nvarchar(max)")
 232 │ 232 │                                         .HasColumnName("CreditCardNumber");
 233 │ 233 │
 234 │ 234 │                                     b2.Property<string>("Cvv")
 235 │ 235 │                                         .IsRequired()
 236 │ 236 │                                         .HasColumnType("nvarchar(max)")
 237 │ 237 │                                         .HasColumnName("CreditCardCvv");
 238 │ 238 │
 239 │ 239 │                                     b2.Property<string>("ExpirationDate")
 240 │ 240 │                                         .IsRequired()
 241 │ 241 │                                         .HasColumnType("nvarchar(max)")
 242 │ 242 │                                         .HasColumnName("CreditCardExpiration");
 243 │ 243 │
 244 │ 244 │                                     b2.HasKey("PaymentInformationCustomerId");
 245 │ 245 │
 246 │ 246 │                                     b2.ToTable("Customers");
 247 │ 247 │
 248 │ 248 │                                     b2.WithOwner()
 249 │ 249 │                                         .HasForeignKey("PaymentInformationCustomerId");
 250 │ 250 │                                 });
 251 │ 251 │
 252 │ 252 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.Address", "BillingAddress", b2 =>
 253 │ 253 │                                 {
 254 │ 254 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 255 │ 255 │                                         .HasColumnType("uniqueidentifier");
 256 │ 256 │
 257 │ 257 │                                     b2.Property<string>("City")
 258 │ 258 │                                         .IsRequired()
 259 │ 259 │                                         .HasColumnType("nvarchar(max)")
 260 │ 260 │                                         .HasColumnName("BillingCity");
 261 │ 261 │
 262 │ 262 │                                     b2.Property<string>("Country")
 263 │ 263 │                                         .IsRequired()
 264 │ 264 │                                         .HasColumnType("nvarchar(max)")
 265 │ 265 │                                         .HasColumnName("BillingCountry");
 266 │ 266 │
 267 │ 267 │                                     b2.Property<string>("State")
 268 │ 268 │                                         .IsRequired()
 269 │ 269 │                                         .HasColumnType("nvarchar(max)")
 270 │ 270 │                                         .HasColumnName("BillingState");
 271 │ 271 │
 272 │ 272 │                                     b2.Property<string>("Street")
 273 │ 273 │                                         .IsRequired()
 274 │ 274 │                                         .HasColumnType("nvarchar(max)")
 275 │ 275 │                                         .HasColumnName("BillingStreet");
 276 │ 276 │
 277 │ 277 │                                     b2.Property<string>("Zip")
 278 │ 278 │                                         .IsRequired()
 279 │ 279 │                                         .HasColumnType("nvarchar(max)")
 280 │ 280 │                                         .HasColumnName("BillingZip");
 281 │ 281 │
 282 │ 282 │                                     b2.HasKey("PaymentInformationCustomerId");
 283 │ 283 │
 284 │ 284 │                                     b2.ToTable("Customers");
 285 │ 285 │
 286 │ 286 │                                     b2.WithOwner()
 287 │ 287 │                                         .HasForeignKey("PaymentInformationCustomerId");
 288 │ 288 │                                 });
 289 │ 289 │
 290 │ 290 │                             b1.Navigation("BillingAddress")
 291 │ 291 │                                 .IsRequired();
 292 │ 292 │
 293 │ 293 │                             b1.Navigation("CreditCard")
 294 │ 294 │                                 .IsRequired();
 295 │ 295 │                         });
 296 │ 296 │
 297 │ 297 │                     b.Navigation("Contact")
 298 │ 298 │                         .IsRequired();
 299 │ 299 │
 300 │ 300 │                     b.Navigation("HomeAddress")
 301 │ 301 │                         .IsRequired();
 302 │ 302 │
 303 │ 303 │                     b.Navigation("PaymentInformation")
 304 │ 304 │                         .IsRequired();
 305 │ 305 │                 });
 306 │ 306 │
 307 │ 307 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 308 │ 308 │                 {
 309 │ 309 │                     b.OwnsMany("FleetTracker.Services.Core.Models.MaintenanceRecord", "MaintenanceHistory", b1 =>
 310 │ 310 │                         {
 311 │ 311 │                             b1.Property<Guid>("Id")
 312 │ 312 │                                 .ValueGeneratedOnAdd()
 313 │ 313 │                                 .HasColumnType("uniqueidentifier");
 314 │ 314 │
 315 │ 315 │                             b1.Property<decimal>("Cost")
 316 │ 316 │                                 .HasColumnType("decimal(18,2)");
 317 │ 317 │
 318 │ 318 │                             b1.Property<string>("Description")
 319 │ 319 │                                 .IsRequired()
 320 │ 320 │                                 .HasColumnType("nvarchar(max)");
 321 │ 321 │
 322 │ 322 │                             b1.Property<DateTime>("ServiceDate")
 323 │ 323 │                                 .HasColumnType("datetime2");
 324 │ 324 │
 325 │ 325 │                             b1.Property<int>("Type")
 326 │ 326 │                                 .HasColumnType("int");
 327 │ 327 │
 328 │ 328 │                             b1.Property<Guid>("VehicleId")
 329 │ 329 │                                 .HasColumnType("uniqueidentifier");
 330 │ 330 │
 331 │ 331 │                             b1.HasKey("Id");
 332 │ 332 │
 333 │ 333 │                             b1.HasIndex("VehicleId");
 334 │ 334 │
 335 │ 335 │                             b1.ToTable("MaintenanceRecords", (string)null);
 336 │ 336 │
 337 │ 337 │                             b1.WithOwner()
 338 │ 338 │                                 .HasForeignKey("VehicleId");
 339 │ 339 │                         });
 340 │ 340 │
 341 │ 341 │                     b.Navigation("Maintenance

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.Designer.cs [1:2 - 15:39] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

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
 15 │ 15 │     [Migration("20260603152232_Decou

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.Designer.cs [17:5 - 88:8] (71 lines, 453 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 88:9]

 17 │ 17 │ entalHistory
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
 58 │ 58 │                         .HasColumnType("nvarchar(450)");
 59 │ 59 │
 60 │ 60 │                     b.Property<Guid?>("CustomerId")
 61 │ 61 │                         .HasColumnType("uniqueidentifier");
 62 │ 62 │
 63 │ 63 │                     b.Property<int?>("EndingMileage")
 64 │ 64 │                         .HasColumnType("int");
 65 │ 65 │
 66 │ 66 │                     b.Property<DateTime>("ExpectedReturnDate")
 67 │ 67 │                         .HasColumnType("datetime2");
 68 │ 68 │
 69 │ 69 │                     b.Property<DateTime>("PickupDate")
 70 │ 70 │                         .HasColumnType("datetime2");
 71 │ 71 │
 72 │ 72 │                     b.Property<int>("StartingMileage")
 73 │ 73 │                         .HasColumnType("int");
 74 │ 74 │
 75 │ 75 │                     b.Property<int>("Status")
 76 │ 76 │                         .HasColumnType("int");
 77 │ 77 │
 78 │ 78 │                     b.Property<decimal?>("TotalCost")
 79 │ 79 │                         .HasColumnType("decimal(18,2)");
 80 │ 80 │
 81 │ 81 │                     b.Property<Guid?>("VehicleId")
 82 │ 82 │                         .HasColumnType("uniqueidentifier");
 83 │ 83 │
 84 │ 84 │                     b.HasKey("Id");
 85 │ 85 │
 86 │ 86 │                     b.HasIndex("AgreementNumber")
 87 │ 87 │

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.Designer.cs [86:2 - 340:2] (254 lines, 1593 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [90:12 - 344:2]

 86  │ 90  │ eementNumber")
 87  │ 91  │                         .IsUnique();
 88  │ 92  │
 89  │ 93  │                     b.ToTable("RentalAgreements");
 90  │ 94  │                 });
 91  │ 95  │
 92  │ 96  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 93  │ 97  │                 {
 94  │ 98  │                     b.Property<Guid>("Id")
 95  │ 99  │                         .ValueGeneratedOnAdd()
 96  │ 100 │                         .HasColumnType("uniqueidentifier");
 97  │ 101 │
 98  │ 102 │                     b.Property<int>("Class")
 99  │ 103 │                         .HasColumnType("int");
 100 │ 104 │
 101 │ 105 │                     b.Property<decimal>("DailyRate")
 102 │ 106 │                         .HasColumnType("decimal(18,2)");
 103 │ 107 │
 104 │ 108 │                     b.Property<string>("LicensePlate")
 105 │ 109 │                         .IsRequired()
 106 │ 110 │                         .HasColumnType("nvarchar(max)");
 107 │ 111 │
 108 │ 112 │                     b.Property<string>("Make")
 109 │ 113 │                         .IsRequired()
 110 │ 114 │                         .HasColumnType("nvarchar(max)");
 111 │ 115 │
 112 │ 116 │                     b.Property<string>("Model")
 113 │ 117 │                         .IsRequired()
 114 │ 118 │                         .HasColumnType("nvarchar(max)");
 115 │ 119 │
 116 │ 120 │                     b.Property<int>("Status")
 117 │ 121 │                         .HasColumnType("int");
 118 │ 122 │
 119 │ 123 │                     b.Property<string>("VIN")
 120 │ 124 │                         .IsRequired()
 121 │ 125 │                         .HasColumnType("nvarchar(450)");
 122 │ 126 │
 123 │ 127 │                     b.Property<int>("Year")
 124 │ 128 │                         .HasColumnType("int");
 125 │ 129 │
 126 │ 130 │                     b.HasKey("Id");
 127 │ 131 │
 128 │ 132 │                     b.HasIndex("VIN")
 129 │ 133 │                         .IsUnique();
 130 │ 134 │
 131 │ 135 │                     b.ToTable("Vehicles");
 132 │ 136 │                 });
 133 │ 137 │
 134 │ 138 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 135 │ 139 │                 {
 136 │ 140 │                     b.OwnsOne("FleetTracker.Services.Core.Models.ContactInfo", "Contact", b1 =>
 137 │ 141 │                         {
 138 │ 142 │                             b1.Property<Guid>("CustomerId")
 139 │ 143 │                                 .HasColumnType("uniqueidentifier");
 140 │ 144 │
 141 │ 145 │                             b1.Property<string>("Email")
 142 │ 146 │                                 .IsRequired()
 143 │ 147 │                                 .HasColumnType("nvarchar(max)")
 144 │ 148 │                                 .HasColumnName("ContactEmail");
 145 │ 149 │
 146 │ 150 │                             b1.Property<string>("Name")
 147 │ 151 │                                 .IsRequired()
 148 │ 152 │                                 .HasColumnType("nvarchar(max)")
 149 │ 153 │                                 .HasColumnName("ContactName");
 150 │ 154 │
 151 │ 155 │                             b1.Property<string>("PhoneNumber")
 152 │ 156 │                                 .IsRequired()
 153 │ 157 │                                 .HasColumnType("nvarchar(max)")
 154 │ 158 │                                 .HasColumnName("ContactPhone");
 155 │ 159 │
 156 │ 160 │                             b1.HasKey("CustomerId");
 157 │ 161 │
 158 │ 162 │                             b1.ToTable("Customers");
 159 │ 163 │
 160 │ 164 │                             b1.WithOwner()
 161 │ 165 │                                 .HasForeignKey("CustomerId");
 162 │ 166 │                         });
 163 │ 167 │
 164 │ 168 │                     b.OwnsOne("FleetTracker.Services.Core.Models.Address", "HomeAddress", b1 =>
 165 │ 169 │                         {
 166 │ 170 │                             b1.Property<Guid>("CustomerId")
 167 │ 171 │                                 .HasColumnType("uniqueidentifier");
 168 │ 172 │
 169 │ 173 │                             b1.Property<string>("City")
 170 │ 174 │                                 .IsRequired()
 171 │ 175 │                                 .HasColumnType("nvarchar(max)")
 172 │ 176 │                                 .HasColumnName("HomeCity");
 173 │ 177 │
 174 │ 178 │                             b1.Property<string>("Country")
 175 │ 179 │                                 .IsRequired()
 176 │ 180 │                                 .HasColumnType("nvarchar(max)")
 177 │ 181 │                                 .HasColumnName("HomeCountry");
 178 │ 182 │
 179 │ 183 │                             b1.Property<string>("State")
 180 │ 184 │                                 .IsRequired()
 181 │ 185 │                                 .HasColumnType("nvarchar(max)")
 182 │ 186 │                                 .HasColumnName("HomeState");
 183 │ 187 │
 184 │ 188 │                             b1.Property<string>("Street")
 185 │ 189 │                                 .IsRequired()
 186 │ 190 │                                 .HasColumnType("nvarchar(max)")
 187 │ 191 │                                 .HasColumnName("HomeStreet");
 188 │ 192 │
 189 │ 193 │                             b1.Property<string>("Zip")
 190 │ 194 │                                 .IsRequired()
 191 │ 195 │                                 .HasColumnType("nvarchar(max)")
 192 │ 196 │                                 .HasColumnName("HomeZip");
 193 │ 197 │
 194 │ 198 │                             b1.HasKey("CustomerId");
 195 │ 199 │
 196 │ 200 │                             b1.ToTable("Customers");
 197 │ 201 │
 198 │ 202 │                             b1.WithOwner()
 199 │ 203 │                                 .HasForeignKey("CustomerId");
 200 │ 204 │                         });
 201 │ 205 │
 202 │ 206 │                     b.OwnsOne("FleetTracker.Services.Core.Models.PaymentInformation", "PaymentInformation", b1 =>
 203 │ 207 │                         {
 204 │ 208 │                             b1.Property<Guid>("CustomerId")
 205 │ 209 │                                 .HasColumnType("uniqueidentifier");
 206 │ 210 │
 207 │ 211 │                             b1.HasKey("CustomerId");
 208 │ 212 │
 209 │ 213 │                             b1.ToTable("Customers");
 210 │ 214 │
 211 │ 215 │                             b1.WithOwner()
 212 │ 216 │                                 .HasForeignKey("CustomerId");
 213 │ 217 │
 214 │ 218 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.CreditCard", "CreditCard", b2 =>
 215 │ 219 │                                 {
 216 │ 220 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 217 │ 221 │                                         .HasColumnType("uniqueidentifier");
 218 │ 222 │
 219 │ 223 │                                     b2.Property<string>("CardHolderName")
 220 │ 224 │                                         .IsRequired()
 221 │ 225 │                                         .HasColumnType("nvarchar(max)")
 222 │ 226 │                                         .HasColumnName("CreditCardHolder");
 223 │ 227 │
 224 │ 228 │                                     b2.Property<string>("CardNumber")
 225 │ 229 │                                         .IsRequired()
 226 │ 230 │                                         .HasColumnType("nvarchar(max)")
 227 │ 231 │                                         .HasColumnName("CreditCardNumber");
 228 │ 232 │
 229 │ 233 │                                     b2.Property<string>("Cvv")
 230 │ 234 │                                         .IsRequired()
 231 │ 235 │                                         .HasColumnType("nvarchar(max)")
 232 │ 236 │                                         .HasColumnName("CreditCardCvv");
 233 │ 237 │
 234 │ 238 │                                     b2.Property<string>("ExpirationDate")
 235 │ 239 │                                         .IsRequired()
 236 │ 240 │                                         .HasColumnType("nvarchar(max)")
 237 │ 241 │                                         .HasColumnName("CreditCardExpiration");
 238 │ 242 │
 239 │ 243 │                                     b2.HasKey("PaymentInformationCustomerId");
 240 │ 244 │
 241 │ 245 │                                     b2.ToTable("Customers");
 242 │ 246 │
 243 │ 247 │                                     b2.WithOwner()
 244 │ 248 │                                         .HasForeignKey("PaymentInformationCustomerId");
 245 │ 249 │                                 });
 246 │ 250 │
 247 │ 251 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.Address", "BillingAddress", b2 =>
 248 │ 252 │                                 {
 249 │ 253 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 250 │ 254 │                                         .HasColumnType("uniqueidentifier");
 251 │ 255 │
 252 │ 256 │                                     b2.Property<string>("City")
 253 │ 257 │                                         .IsRequired()
 254 │ 258 │                                         .HasColumnType("nvarchar(max)")
 255 │ 259 │                                         .HasColumnName("BillingCity");
 256 │ 260 │
 257 │ 261 │                                     b2.Property<string>("Country")
 258 │ 262 │                                         .IsRequired()
 259 │ 263 │                                         .HasColumnType("nvarchar(max)")
 260 │ 264 │                                         .HasColumnName("BillingCountry");
 261 │ 265 │
 262 │ 266 │                                     b2.Property<string>("State")
 263 │ 267 │                                         .IsRequired()
 264 │ 268 │                                         .HasColumnType("nvarchar(max)")
 265 │ 269 │                                         .HasColumnName("BillingState");
 266 │ 270 │
 267 │ 271 │                                     b2.Property<string>("Street")
 268 │ 272 │                                         .IsRequired()
 269 │ 273 │                                         .HasColumnType("nvarchar(max)")
 270 │ 274 │                                         .HasColumnName("BillingStreet");
 271 │ 275 │
 272 │ 276 │                                     b2.Property<string>("Zip")
 273 │ 277 │                                         .IsRequired()
 274 │ 278 │                                         .HasColumnType("nvarchar(max)")
 275 │ 279 │                                         .HasColumnName("BillingZip");
 276 │ 280 │
 277 │ 281 │                                     b2.HasKey("PaymentInformationCustomerId");
 278 │ 282 │
 279 │ 283 │                                     b2.ToTable("Customers");
 280 │ 284 │
 281 │ 285 │                                     b2.WithOwner()
 282 │ 286 │                                         .HasForeignKey("PaymentInformationCustomerId");
 283 │ 287 │                                 });
 284 │ 288 │
 285 │ 289 │                             b1.Navigation("BillingAddress")
 286 │ 290 │                                 .IsRequired();
 287 │ 291 │
 288 │ 292 │                             b1.Navigation("CreditCard")
 289 │ 293 │                                 .IsRequired();
 290 │ 294 │                         });
 291 │ 295 │
 292 │ 296 │                     b.Navigation("Contact")
 293 │ 297 │                         .IsRequired();
 294 │ 298 │
 295 │ 299 │                     b.Navigation("HomeAddress")
 296 │ 300 │                         .IsRequired();
 297 │ 301 │
 298 │ 302 │                     b.Navigation("PaymentInformation")
 299 │ 303 │                         .IsRequired();
 300 │ 304 │                 });
 301 │ 305 │
 302 │ 306 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 303 │ 307 │                 {
 304 │ 308 │                     b.OwnsMany("FleetTracker.Services.Core.Models.MaintenanceRecord", "MaintenanceHistory", b1 =>
 305 │ 309 │                         {
 306 │ 310 │                             b1.Property<Guid>("Id")
 307 │ 311 │                                 .ValueGeneratedOnAdd()
 308 │ 312 │                                 .HasColumnType("uniqueidentifier");
 309 │ 313 │
 310 │ 314 │                             b1.Property<decimal>("Cost")
 311 │ 315 │                                 .HasColumnType("decimal(18,2)");
 312 │ 316 │
 313 │ 317 │                             b1.Property<string>("Description")
 314 │ 318 │                                 .IsRequired()
 315 │ 319 │                                 .HasColumnType("nvarchar(max)");
 316 │ 320 │
 317 │ 321 │                             b1.Property<DateTime>("ServiceDate")
 318 │ 322 │                                 .HasColumnType("datetime2");
 319 │ 323 │
 320 │ 324 │                             b1.Property<int>("Type")
 321 │ 325 │                                 .HasColumnType("int");
 322 │ 326 │
 323 │ 327 │                             b1.Property<Guid>("VehicleId")
 324 │ 328 │                                 .HasColumnType("uniqueidentifier");
 325 │ 329 │
 326 │ 330 │                             b1.HasKey("Id");
 327 │ 331 │
 328 │ 332 │                             b1.HasIndex("VehicleId");
 329 │ 333 │
 330 │ 334 │                             b1.ToTable("MaintenanceRecords", (string)null);
 331 │ 335 │
 332 │ 336 │                             b1.WithOwner()
 333 │ 337 │                                 .HasForeignKey("VehicleId");
 334 │ 338 │                         });
 335 │ 339 │
 336 │ 340 │                     b.Navigation("Maintenance

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.cs [59:12 - 65:23] (6 lines, 85 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.cs [24:16 - 30:24]

 59 │ 24 │ type: "datetime2", nullable: false),

 60 │ 25 │                     Type = table.Column<int>(type: "int", nullable: false),

 61 │ 26 │                     VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)

 62 │ 27 │                 },

 63 │ 28 │                 constraints: table =>

 64 │ 29 │                 {

 65 │ 30 │                     table.PrimaryKey("PK_M

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs [1:2 - 15:39] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

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
 15 │ 15 │     [Migration("20260603140044_FixMa

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs [17:5 - 46:54] (29 lines, 176 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 46:52]

 17 │ 17 │ nanceMapping
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
 47 │ 47 │             modelBuilder.Entity("Fle

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs [72:21 - 334:54] (262 lines, 1657 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [43:12 - 305:44]

 72  │ 43  │                    b.ToTable("MaintenanceRecords");
 73  │ 44  │                 });
 74  │ 45  │
 75  │ 46  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
 76  │ 47  │                 {
 77  │ 48  │                     b.Property<Guid>("Id")
 78  │ 49  │                         .ValueGeneratedOnAdd()
 79  │ 50  │                         .HasColumnType("uniqueidentifier");
 80  │ 51  │
 81  │ 52  │                     b.Property<DateTime?>("ActualReturnDate")
 82  │ 53  │                         .HasColumnType("datetime2");
 83  │ 54  │
 84  │ 55  │                     b.Property<string>("AgreementNumber")
 85  │ 56  │                         .IsRequired()
 86  │ 57  │                         .HasColumnType("nvarchar(450)");
 87  │ 58  │
 88  │ 59  │                     b.Property<Guid?>("CustomerId")
 89  │ 60  │                         .HasColumnType("uniqueidentifier");
 90  │ 61  │
 91  │ 62  │                     b.Property<int?>("EndingMileage")
 92  │ 63  │                         .HasColumnType("int");
 93  │ 64  │
 94  │ 65  │                     b.Property<DateTime>("ExpectedReturnDate")
 95  │ 66  │                         .HasColumnType("datetime2");
 96  │ 67  │
 97  │ 68  │                     b.Property<DateTime>("PickupDate")
 98  │ 69  │                         .HasColumnType("datetime2");
 99  │ 70  │
 100 │ 71  │                     b.Property<int>("StartingMileage")
 101 │ 72  │                         .HasColumnType("int");
 102 │ 73  │
 103 │ 74  │                     b.Property<int>("Status")
 104 │ 75  │                         .HasColumnType("int");
 105 │ 76  │
 106 │ 77  │                     b.Property<decimal?>("TotalCost")
 107 │ 78  │                         .HasColumnType("decimal(18,2)");
 108 │ 79  │
 109 │ 80  │                     b.Property<Guid?>("VehicleId")
 110 │ 81  │                         .HasColumnType("uniqueidentifier");
 111 │ 82  │
 112 │ 83  │                     b.HasKey("Id");
 113 │ 84  │
 114 │ 85  │                     b.HasIndex("AgreementNumber")
 115 │ 86  │                         .IsUnique();
 116 │ 87  │
 117 │ 88  │                     b.HasIndex("CustomerId");
 118 │ 89  │
 119 │ 90  │                     b.HasIndex("VehicleId");
 120 │ 91  │
 121 │ 92  │                     b.ToTable("RentalAgreements");
 122 │ 93  │                 });
 123 │ 94  │
 124 │ 95  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 125 │ 96  │                 {
 126 │ 97  │                     b.Property<Guid>("Id")
 127 │ 98  │                         .ValueGeneratedOnAdd()
 128 │ 99  │                         .HasColumnType("uniqueidentifier");
 129 │ 100 │
 130 │ 101 │                     b.Property<int>("Class")
 131 │ 102 │                         .HasColumnType("int");
 132 │ 103 │
 133 │ 104 │                     b.Property<decimal>("DailyRate")
 134 │ 105 │                         .HasColumnType("decimal(18,2)");
 135 │ 106 │
 136 │ 107 │                     b.Property<string>("LicensePlate")
 137 │ 108 │                         .IsRequired()
 138 │ 109 │                         .HasColumnType("nvarchar(max)");
 139 │ 110 │
 140 │ 111 │                     b.Property<string>("Make")
 141 │ 112 │                         .IsRequired()
 142 │ 113 │                         .HasColumnType("nvarchar(max)");
 143 │ 114 │
 144 │ 115 │                     b.Property<string>("Model")
 145 │ 116 │                         .IsRequired()
 146 │ 117 │                         .HasColumnType("nvarchar(max)");
 147 │ 118 │
 148 │ 119 │                     b.Property<int>("Status")
 149 │ 120 │                         .HasColumnType("int");
 150 │ 121 │
 151 │ 122 │                     b.Property<string>("VIN")
 152 │ 123 │                         .IsRequired()
 153 │ 124 │                         .HasColumnType("nvarchar(450)");
 154 │ 125 │
 155 │ 126 │                     b.Property<int>("Year")
 156 │ 127 │                         .HasColumnType("int");
 157 │ 128 │
 158 │ 129 │                     b.HasKey("Id");
 159 │ 130 │
 160 │ 131 │                     b.HasIndex("VIN")
 161 │ 132 │                         .IsUnique();
 162 │ 133 │
 163 │ 134 │                     b.ToTable("Vehicles");
 164 │ 135 │                 });
 165 │ 136 │
 166 │ 137 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 167 │ 138 │                 {
 168 │ 139 │                     b.OwnsOne("FleetTracker.Services.Core.Models.ContactInfo", "Contact", b1 =>
 169 │ 140 │                         {
 170 │ 141 │                             b1.Property<Guid>("CustomerId")
 171 │ 142 │                                 .HasColumnType("uniqueidentifier");
 172 │ 143 │
 173 │ 144 │                             b1.Property<string>("Email")
 174 │ 145 │                                 .IsRequired()
 175 │ 146 │                                 .HasColumnType("nvarchar(max)")
 176 │ 147 │                                 .HasColumnName("ContactEmail");
 177 │ 148 │
 178 │ 149 │                             b1.Property<string>("Name")
 179 │ 150 │                                 .IsRequired()
 180 │ 151 │                                 .HasColumnType("nvarchar(max)")
 181 │ 152 │                                 .HasColumnName("ContactName");
 182 │ 153 │
 183 │ 154 │                             b1.Property<string>("PhoneNumber")
 184 │ 155 │                                 .IsRequired()
 185 │ 156 │                                 .HasColumnType("nvarchar(max)")
 186 │ 157 │                                 .HasColumnName("ContactPhone");
 187 │ 158 │
 188 │ 159 │                             b1.HasKey("CustomerId");
 189 │ 160 │
 190 │ 161 │                             b1.ToTable("Customers");
 191 │ 162 │
 192 │ 163 │                             b1.WithOwner()
 193 │ 164 │                                 .HasForeignKey("CustomerId");
 194 │ 165 │                         });
 195 │ 166 │
 196 │ 167 │                     b.OwnsOne("FleetTracker.Services.Core.Models.Address", "HomeAddress", b1 =>
 197 │ 168 │                         {
 198 │ 169 │                             b1.Property<Guid>("CustomerId")
 199 │ 170 │                                 .HasColumnType("uniqueidentifier");
 200 │ 171 │
 201 │ 172 │                             b1.Property<string>("City")
 202 │ 173 │                                 .IsRequired()
 203 │ 174 │                                 .HasColumnType("nvarchar(max)")
 204 │ 175 │                                 .HasColumnName("HomeCity");
 205 │ 176 │
 206 │ 177 │                             b1.Property<string>("Country")
 207 │ 178 │                                 .IsRequired()
 208 │ 179 │                                 .HasColumnType("nvarchar(max)")
 209 │ 180 │                                 .HasColumnName("HomeCountry");
 210 │ 181 │
 211 │ 182 │                             b1.Property<string>("State")
 212 │ 183 │                                 .IsRequired()
 213 │ 184 │                                 .HasColumnType("nvarchar(max)")
 214 │ 185 │                                 .HasColumnName("HomeState");
 215 │ 186 │
 216 │ 187 │                             b1.Property<string>("Street")
 217 │ 188 │                                 .IsRequired()
 218 │ 189 │                                 .HasColumnType("nvarchar(max)")
 219 │ 190 │                                 .HasColumnName("HomeStreet");
 220 │ 191 │
 221 │ 192 │                             b1.Property<string>("Zip")
 222 │ 193 │                                 .IsRequired()
 223 │ 194 │                                 .HasColumnType("nvarchar(max)")
 224 │ 195 │                                 .HasColumnName("HomeZip");
 225 │ 196 │
 226 │ 197 │                             b1.HasKey("CustomerId");
 227 │ 198 │
 228 │ 199 │                             b1.ToTable("Customers");
 229 │ 200 │
 230 │ 201 │                             b1.WithOwner()
 231 │ 202 │                                 .HasForeignKey("CustomerId");
 232 │ 203 │                         });
 233 │ 204 │
 234 │ 205 │                     b.OwnsOne("FleetTracker.Services.Core.Models.PaymentInformation", "PaymentInformation", b1 =>
 235 │ 206 │                         {
 236 │ 207 │                             b1.Property<Guid>("CustomerId")
 237 │ 208 │                                 .HasColumnType("uniqueidentifier");
 238 │ 209 │
 239 │ 210 │                             b1.HasKey("CustomerId");
 240 │ 211 │
 241 │ 212 │                             b1.ToTable("Customers");
 242 │ 213 │
 243 │ 214 │                             b1.WithOwner()
 244 │ 215 │                                 .HasForeignKey("CustomerId");
 245 │ 216 │
 246 │ 217 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.CreditCard", "CreditCard", b2 =>
 247 │ 218 │                                 {
 248 │ 219 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 249 │ 220 │                                         .HasColumnType("uniqueidentifier");
 250 │ 221 │
 251 │ 222 │                                     b2.Property<string>("CardHolderName")
 252 │ 223 │                                         .IsRequired()
 253 │ 224 │                                         .HasColumnType("nvarchar(max)")
 254 │ 225 │                                         .HasColumnName("CreditCardHolder");
 255 │ 226 │
 256 │ 227 │                                     b2.Property<string>("CardNumber")
 257 │ 228 │                                         .IsRequired()
 258 │ 229 │                                         .HasColumnType("nvarchar(max)")
 259 │ 230 │                                         .HasColumnName("CreditCardNumber");
 260 │ 231 │
 261 │ 232 │                                     b2.Property<string>("Cvv")
 262 │ 233 │                                         .IsRequired()
 263 │ 234 │                                         .HasColumnType("nvarchar(max)")
 264 │ 235 │                                         .HasColumnName("CreditCardCvv");
 265 │ 236 │
 266 │ 237 │                                     b2.Property<string>("ExpirationDate")
 267 │ 238 │                                         .IsRequired()
 268 │ 239 │                                         .HasColumnType("nvarchar(max)")
 269 │ 240 │                                         .HasColumnName("CreditCardExpiration");
 270 │ 241 │
 271 │ 242 │                                     b2.HasKey("PaymentInformationCustomerId");
 272 │ 243 │
 273 │ 244 │                                     b2.ToTable("Customers");
 274 │ 245 │
 275 │ 246 │                                     b2.WithOwner()
 276 │ 247 │                                         .HasForeignKey("PaymentInformationCustomerId");
 277 │ 248 │                                 });
 278 │ 249 │
 279 │ 250 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.Address", "BillingAddress", b2 =>
 280 │ 251 │                                 {
 281 │ 252 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 282 │ 253 │                                         .HasColumnType("uniqueidentifier");
 283 │ 254 │
 284 │ 255 │                                     b2.Property<string>("City")
 285 │ 256 │                                         .IsRequired()
 286 │ 257 │                                         .HasColumnType("nvarchar(max)")
 287 │ 258 │                                         .HasColumnName("BillingCity");
 288 │ 259 │
 289 │ 260 │                                     b2.Property<string>("Country")
 290 │ 261 │                                         .IsRequired()
 291 │ 262 │                                         .HasColumnType("nvarchar(max)")
 292 │ 263 │                                         .HasColumnName("BillingCountry");
 293 │ 264 │
 294 │ 265 │                                     b2.Property<string>("State")
 295 │ 266 │                                         .IsRequired()
 296 │ 267 │                                         .HasColumnType("nvarchar(max)")
 297 │ 268 │                                         .HasColumnName("BillingState");
 298 │ 269 │
 299 │ 270 │                                     b2.Property<string>("Street")
 300 │ 271 │                                         .IsRequired()
 301 │ 272 │                                         .HasColumnType("nvarchar(max)")
 302 │ 273 │                                         .HasColumnName("BillingStreet");
 303 │ 274 │
 304 │ 275 │                                     b2.Property<string>("Zip")
 305 │ 276 │                                         .IsRequired()
 306 │ 277 │                                         .HasColumnType("nvarchar(max)")
 307 │ 278 │                                         .HasColumnName("BillingZip");
 308 │ 279 │
 309 │ 280 │                                     b2.HasKey("PaymentInformationCustomerId");
 310 │ 281 │
 311 │ 282 │                                     b2.ToTable("Customers");
 312 │ 283 │
 313 │ 284 │                                     b2.WithOwner()
 314 │ 285 │                                         .HasForeignKey("PaymentInformationCustomerId");
 315 │ 286 │                                 });
 316 │ 287 │
 317 │ 288 │                             b1.Navigation("BillingAddress")
 318 │ 289 │                                 .IsRequired();
 319 │ 290 │
 320 │ 291 │                             b1.Navigation("CreditCard")
 321 │ 292 │                                 .IsRequired();
 322 │ 293 │                         });
 323 │ 294 │
 324 │ 295 │                     b.Navigation("Contact")
 325 │ 296 │                         .IsRequired();
 326 │ 297 │
 327 │ 298 │                     b.Navigation("HomeAddress")
 328 │ 299 │                         .IsRequired();
 329 │ 300 │
 330 │ 301 │                     b.Navigation("PaymentInformation")
 331 │ 302 │                         .IsRequired();
 332 │ 303 │                 });
 333 │ 304 │
 334 │ 305 │             modelBuilder.Entity("Fle

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [1:2 - 15:42] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

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
 15 │ 15 │     [Migration("20260602154919_Maintena

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [17:5 - 305:52] (288 lines, 1819 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 305:44]

 17  │ 17  │ ostPrecision
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
 306 │ 306 │             modelBuilder.Entity("F

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [302:2 - 322:44] (20 lines, 127 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs [342:10 - 362:45]

 302 │ 342 │ nformation")
 303 │ 343 │                         .IsRequired();
 304 │ 344 │                 });
 305 │ 345 │
 306 │ 346 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
 307 │ 347 │                 {
 308 │ 348 │                     b.HasOne("FleetTracker.Services.Core.Models.Customer", "Customer")
 309 │ 349 │                         .WithMany("RentalHistory")
 310 │ 350 │                         .HasForeignKey("CustomerId")
 311 │ 351 │                         .OnDelete(DeleteBehavior.SetNull);
 312 │ 352 │
 313 │ 353 │                     b.HasOne("FleetTracker.Services.Core.Models.Vehicle", "Vehicle")
 314 │ 354 │                         .WithMany("RentalHistory")
 315 │ 355 │                         .HasForeignKey("VehicleId")
 316 │ 356 │                         .OnDelete(DeleteBehavior.SetNull);
 317 │ 357 │
 318 │ 358 │                     b.Navigation("Customer");
 319 │ 359 │
 320 │ 360 │                     b.Navigation("Vehicle");
 321 │ 361 │                 });
 322 │ 362 │
 323 │ 363 │             modelBuilder.E

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [319:10 - 346:9] (27 lines, 179 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [302:2 - 329:7]

 319 │ 302 │ er");
 320 │ 303 │
 321 │ 304 │                     b.Navigation("Vehicle");
 322 │ 305 │                 });
 323 │ 306 │
 324 │ 307 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 325 │ 308 │                 {
 326 │ 309 │                     b.OwnsMany("FleetTracker.Services.Core.Models.MaintenanceRecord", "MaintenanceHistory", b1 =>
 327 │ 310 │                         {
 328 │ 311 │                             b1.Property<Guid>("Id")
 329 │ 312 │                                 .ValueGeneratedOnAdd()
 330 │ 313 │                                 .HasColumnType("uniqueidentifier");
 331 │ 314 │
 332 │ 315 │                             b1.Property<decimal>("Cost")
 333 │ 316 │                                 .HasColumnType("decimal(18,2)");
 334 │ 317 │
 335 │ 318 │                             b1.Property<string>("Description")
 336 │ 319 │                                 .IsRequired()
 337 │ 320 │                                 .HasColumnType("nvarchar(max)");
 338 │ 321 │
 339 │ 322 │                             b1.Property<DateTime>("ServiceDate")
 340 │ 323 │                                 .HasColumnType("datetime2");
 341 │ 324 │
 342 │ 325 │                             b1.Property<int>("Type")
 343 │ 326 │                                 .HasColumnType("int");
 344 │ 327 │
 345 │ 328 │                             b1.Property<Guid>("VehicleId")
 346 │ 329 │                                 .HasColumnType("uniqueident

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.cs [36:19 - 55:19] (19 lines, 131 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.cs [41:12 - 59:2]

 36 │ 41 │ uniqueidentifier");

 37 │ 42 │

 38 │ 43 │             migrationBuilder.AddForeignKey(

 39 │ 44 │                 name: "FK_RentalAgreements_Customers_CustomerId",

 40 │ 45 │                 table: "RentalAgreements",

 41 │ 46 │                 column: "CustomerId",

 42 │ 47 │                 principalTable: "Customers",

 43 │ 48 │                 principalColumn: "Id",

 44 │ 49 │                 onDelete: ReferentialAction.SetNull);

 45 │ 50 │

 46 │ 51 │             migrationBuilder.AddForeignKey(

 47 │ 52 │                 name: "FK_RentalAgreements_Vehicles_VehicleId",

 48 │ 53 │                 table: "RentalAgreements",

 49 │ 54 │                 column: "VehicleId",

 50 │ 55 │                 principalTable: "Vehicles",

 51 │ 56 │                 principalColumn: "Id",

 52 │ 57 │                 onDelete: ReferentialAction.SetNull);

 53 │ 58 │         }

 54 │ 59 │

 55 │ 60 │         /

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
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

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
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 382:2]

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
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.cs [64:20 - 72:2] (8 lines, 172 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.cs [18:21 - 27:2]

 64 │ 18 │ aintenanceRecord",

 65 │ 19 │                 columns: table => new

 66 │ 20 │                 {

 67 │ 21 │                     Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),

 68 │ 22 │                     ServiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),

 69 │ 23 │                     Description = table.Column<string>(type: "nvarchar(max)", nullable: false),

 70 │ 24 │                     Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),

 71 │ 25 │                     Type = table.Column<int>(type: "int", nullable: false),

 72 │ 26 │                     VehicleId = table.Column<Guid>(type: "uniqueidentifier",

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.cs [73:5 - 91:12] (18 lines, 157 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.cs [61:6 - 79:12]

 73 │ 61 │ ", nullable: true)

 74 │ 62 │                 },

 75 │ 63 │                 constraints: table =>

 76 │ 64 │                 {

 77 │ 65 │                     table.PrimaryKey("PK_MaintenanceRecord", x => x.Id);

 78 │ 66 │                     table.ForeignKey(

 79 │ 67 │                         name: "FK_MaintenanceRecord_Vehicles_VehicleId",

 80 │ 68 │                         column: x => x.VehicleId,

 81 │ 69 │                         principalTable: "Vehicles",

 82 │ 70 │                         principalColumn: "Id",

 83 │ 71 │                         onDelete: ReferentialAction.Cascade);

 84 │ 72 │                     table.ForeignKey(

 85 │ 73 │                         name: "FK_MaintenanceRecord_Vehicles_VehicleId1",

 86 │ 74 │                         column: x => x.VehicleId1,

 87 │ 75 │                         principalTable: "Vehicles",

 88 │ 76 │                         principalColumn: "Id");

 89 │ 77 │                 });

 90 │ 78 │

 91 │ 79 │             migrationBu

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [1:2 - 15:31] (14 lines, 91 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [1:2 - 15:50]

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
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs [17:5 - 59:2]

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
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [59:2 - 80:2]

 59 │ 59 │ char(450)");
 60 │ 60 │
 61 │ 61 │                     b.Property<Guid>("CustomerId")
 62 │ 62 │                         .HasColumnType("uniqueidentifier");
 63 │ 63 │
 64 │ 64 │                     b.Property<int?>("EndingMileage")
 65 │ 65 │                         .HasColumnType("int");
 66 │ 66 │
 67 │ 67 │                     b.Property<DateTime>("ExpectedReturnDate")
 68 │ 68 │                         .HasColumnType("datetime2");
 69 │ 69 │
 70 │ 70 │                     b.Property<DateTime>("PickupDate")
 71 │ 71 │                         .HasColumnType("datetime2");
 72 │ 72 │
 73 │ 73 │                     b.Property<int>("StartingMileage")
 74 │ 74 │                         .HasColumnType("int");
 75 │ 75 │
 76 │ 76 │                     b.Property<int>("Status")
 77 │ 77 │                         .HasColumnType("int");
 78 │ 78 │
 79 │ 79 │                     b.Property<decimal?>("TotalCost")
 80 │ 80 │                         .HasColumnType("decim

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [80:5 - 310:8] (230 lines, 1451 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs [80:2 - 310:8]

 80  │ 80  │ mal(18,2)");
 81  │ 81  │
 82  │ 82  │                     b.Property<Guid>("VehicleId")
 83  │ 83  │                         .HasColumnType("uniqueidentifier");
 84  │ 84  │
 85  │ 85  │                     b.HasKey("Id");
 86  │ 86  │
 87  │ 87  │                     b.HasIndex("AgreementNumber")
 88  │ 88  │                         .IsUnique();
 89  │ 89  │
 90  │ 90  │                     b.HasIndex("CustomerId");
 91  │ 91  │
 92  │ 92  │                     b.HasIndex("VehicleId");
 93  │ 93  │
 94  │ 94  │                     b.ToTable("RentalAgreements");
 95  │ 95  │                 });
 96  │ 96  │
 97  │ 97  │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 98  │ 98  │                 {
 99  │ 99  │                     b.Property<Guid>("Id")
 100 │ 100 │                         .ValueGeneratedOnAdd()
 101 │ 101 │                         .HasColumnType("uniqueidentifier");
 102 │ 102 │
 103 │ 103 │                     b.Property<int>("Class")
 104 │ 104 │                         .HasColumnType("int");
 105 │ 105 │
 106 │ 106 │                     b.Property<decimal>("DailyRate")
 107 │ 107 │                         .HasColumnType("decimal(18,2)");
 108 │ 108 │
 109 │ 109 │                     b.Property<string>("LicensePlate")
 110 │ 110 │                         .IsRequired()
 111 │ 111 │                         .HasColumnType("nvarchar(max)");
 112 │ 112 │
 113 │ 113 │                     b.Property<string>("Make")
 114 │ 114 │                         .IsRequired()
 115 │ 115 │                         .HasColumnType("nvarchar(max)");
 116 │ 116 │
 117 │ 117 │                     b.Property<string>("Model")
 118 │ 118 │                         .IsRequired()
 119 │ 119 │                         .HasColumnType("nvarchar(max)");
 120 │ 120 │
 121 │ 121 │                     b.Property<int>("Status")
 122 │ 122 │                         .HasColumnType("int");
 123 │ 123 │
 124 │ 124 │                     b.Property<string>("VIN")
 125 │ 125 │                         .IsRequired()
 126 │ 126 │                         .HasColumnType("nvarchar(450)");
 127 │ 127 │
 128 │ 128 │                     b.Property<int>("Year")
 129 │ 129 │                         .HasColumnType("int");
 130 │ 130 │
 131 │ 131 │                     b.HasKey("Id");
 132 │ 132 │
 133 │ 133 │                     b.HasIndex("VIN")
 134 │ 134 │                         .IsUnique();
 135 │ 135 │
 136 │ 136 │                     b.ToTable("Vehicles");
 137 │ 137 │                 });
 138 │ 138 │
 139 │ 139 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 140 │ 140 │                 {
 141 │ 141 │                     b.OwnsOne("FleetTracker.Services.Core.Models.ContactInfo", "Contact", b1 =>
 142 │ 142 │                         {
 143 │ 143 │                             b1.Property<Guid>("CustomerId")
 144 │ 144 │                                 .HasColumnType("uniqueidentifier");
 145 │ 145 │
 146 │ 146 │                             b1.Property<string>("Email")
 147 │ 147 │                                 .IsRequired()
 148 │ 148 │                                 .HasColumnType("nvarchar(max)")
 149 │ 149 │                                 .HasColumnName("ContactEmail");
 150 │ 150 │
 151 │ 151 │                             b1.Property<string>("Name")
 152 │ 152 │                                 .IsRequired()
 153 │ 153 │                                 .HasColumnType("nvarchar(max)")
 154 │ 154 │                                 .HasColumnName("ContactName");
 155 │ 155 │
 156 │ 156 │                             b1.Property<string>("PhoneNumber")
 157 │ 157 │                                 .IsRequired()
 158 │ 158 │                                 .HasColumnType("nvarchar(max)")
 159 │ 159 │                                 .HasColumnName("ContactPhone");
 160 │ 160 │
 161 │ 161 │                             b1.HasKey("CustomerId");
 162 │ 162 │
 163 │ 163 │                             b1.ToTable("Customers");
 164 │ 164 │
 165 │ 165 │                             b1.WithOwner()
 166 │ 166 │                                 .HasForeignKey("CustomerId");
 167 │ 167 │                         });
 168 │ 168 │
 169 │ 169 │                     b.OwnsOne("FleetTracker.Services.Core.Models.Address", "HomeAddress", b1 =>
 170 │ 170 │                         {
 171 │ 171 │                             b1.Property<Guid>("CustomerId")
 172 │ 172 │                                 .HasColumnType("uniqueidentifier");
 173 │ 173 │
 174 │ 174 │                             b1.Property<string>("City")
 175 │ 175 │                                 .IsRequired()
 176 │ 176 │                                 .HasColumnType("nvarchar(max)")
 177 │ 177 │                                 .HasColumnName("HomeCity");
 178 │ 178 │
 179 │ 179 │                             b1.Property<string>("Country")
 180 │ 180 │                                 .IsRequired()
 181 │ 181 │                                 .HasColumnType("nvarchar(max)")
 182 │ 182 │                                 .HasColumnName("HomeCountry");
 183 │ 183 │
 184 │ 184 │                             b1.Property<string>("State")
 185 │ 185 │                                 .IsRequired()
 186 │ 186 │                                 .HasColumnType("nvarchar(max)")
 187 │ 187 │                                 .HasColumnName("HomeState");
 188 │ 188 │
 189 │ 189 │                             b1.Property<string>("Street")
 190 │ 190 │                                 .IsRequired()
 191 │ 191 │                                 .HasColumnType("nvarchar(max)")
 192 │ 192 │                                 .HasColumnName("HomeStreet");
 193 │ 193 │
 194 │ 194 │                             b1.Property<string>("Zip")
 195 │ 195 │                                 .IsRequired()
 196 │ 196 │                                 .HasColumnType("nvarchar(max)")
 197 │ 197 │                                 .HasColumnName("HomeZip");
 198 │ 198 │
 199 │ 199 │                             b1.HasKey("CustomerId");
 200 │ 200 │
 201 │ 201 │                             b1.ToTable("Customers");
 202 │ 202 │
 203 │ 203 │                             b1.WithOwner()
 204 │ 204 │                                 .HasForeignKey("CustomerId");
 205 │ 205 │                         });
 206 │ 206 │
 207 │ 207 │                     b.OwnsOne("FleetTracker.Services.Core.Models.PaymentInformation", "PaymentInformation", b1 =>
 208 │ 208 │                         {
 209 │ 209 │                             b1.Property<Guid>("CustomerId")
 210 │ 210 │                                 .HasColumnType("uniqueidentifier");
 211 │ 211 │
 212 │ 212 │                             b1.HasKey("CustomerId");
 213 │ 213 │
 214 │ 214 │                             b1.ToTable("Customers");
 215 │ 215 │
 216 │ 216 │                             b1.WithOwner()
 217 │ 217 │                                 .HasForeignKey("CustomerId");
 218 │ 218 │
 219 │ 219 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.CreditCard", "CreditCard", b2 =>
 220 │ 220 │                                 {
 221 │ 221 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 222 │ 222 │                                         .HasColumnType("uniqueidentifier");
 223 │ 223 │
 224 │ 224 │                                     b2.Property<string>("CardHolderName")
 225 │ 225 │                                         .IsRequired()
 226 │ 226 │                                         .HasColumnType("nvarchar(max)")
 227 │ 227 │                                         .HasColumnName("CreditCardHolder");
 228 │ 228 │
 229 │ 229 │                                     b2.Property<string>("CardNumber")
 230 │ 230 │                                         .IsRequired()
 231 │ 231 │                                         .HasColumnType("nvarchar(max)")
 232 │ 232 │                                         .HasColumnName("CreditCardNumber");
 233 │ 233 │
 234 │ 234 │                                     b2.Property<string>("Cvv")
 235 │ 235 │                                         .IsRequired()
 236 │ 236 │                                         .HasColumnType("nvarchar(max)")
 237 │ 237 │                                         .HasColumnName("CreditCardCvv");
 238 │ 238 │
 239 │ 239 │                                     b2.Property<string>("ExpirationDate")
 240 │ 240 │                                         .IsRequired()
 241 │ 241 │                                         .HasColumnType("nvarchar(max)")
 242 │ 242 │                                         .HasColumnName("CreditCardExpiration");
 243 │ 243 │
 244 │ 244 │                                     b2.HasKey("PaymentInformationCustomerId");
 245 │ 245 │
 246 │ 246 │                                     b2.ToTable("Customers");
 247 │ 247 │
 248 │ 248 │                                     b2.WithOwner()
 249 │ 249 │                                         .HasForeignKey("PaymentInformationCustomerId");
 250 │ 250 │                                 });
 251 │ 251 │
 252 │ 252 │                             b1.OwnsOne("FleetTracker.Services.Core.Models.Address", "BillingAddress", b2 =>
 253 │ 253 │                                 {
 254 │ 254 │                                     b2.Property<Guid>("PaymentInformationCustomerId")
 255 │ 255 │                                         .HasColumnType("uniqueidentifier");
 256 │ 256 │
 257 │ 257 │                                     b2.Property<string>("City")
 258 │ 258 │                                         .IsRequired()
 259 │ 259 │                                         .HasColumnType("nvarchar(max)")
 260 │ 260 │                                         .HasColumnName("BillingCity");
 261 │ 261 │
 262 │ 262 │                                     b2.Property<string>("Country")
 263 │ 263 │                                         .IsRequired()
 264 │ 264 │                                         .HasColumnType("nvarchar(max)")
 265 │ 265 │                                         .HasColumnName("BillingCountry");
 266 │ 266 │
 267 │ 267 │                                     b2.Property<string>("State")
 268 │ 268 │                                         .IsRequired()
 269 │ 269 │                                         .HasColumnType("nvarchar(max)")
 270 │ 270 │                                         .HasColumnName("BillingState");
 271 │ 271 │
 272 │ 272 │                                     b2.Property<string>("Street")
 273 │ 273 │                                         .IsRequired()
 274 │ 274 │                                         .HasColumnType("nvarchar(max)")
 275 │ 275 │                                         .HasColumnName("BillingStreet");
 276 │ 276 │
 277 │ 277 │                                     b2.Property<string>("Zip")
 278 │ 278 │                                         .IsRequired()
 279 │ 279 │                                         .HasColumnType("nvarchar(max)")
 280 │ 280 │                                         .HasColumnName("BillingZip");
 281 │ 281 │
 282 │ 282 │                                     b2.HasKey("PaymentInformationCustomerId");
 283 │ 283 │
 284 │ 284 │                                     b2.ToTable("Customers");
 285 │ 285 │
 286 │ 286 │                                     b2.WithOwner()
 287 │ 287 │                                         .HasForeignKey("PaymentInformationCustomerId");
 288 │ 288 │                                 });
 289 │ 289 │
 290 │ 290 │                             b1.Navigation("BillingAddress")
 291 │ 291 │                                 .IsRequired();
 292 │ 292 │
 293 │ 293 │                             b1.Navigation("CreditCard")
 294 │ 294 │                                 .IsRequired();
 295 │ 295 │                         });
 296 │ 296 │
 297 │ 297 │                     b.Navigation("Contact")
 298 │ 298 │                         .IsRequired();
 299 │ 299 │
 300 │ 300 │                     b.Navigation("HomeAddress")
 301 │ 301 │                         .IsRequired();
 302 │ 302 │
 303 │ 303 │                     b.Navigation("PaymentInformation")
 304 │ 304 │                         .IsRequired();
 305 │ 305 │                 });
 306 │ 306 │
 307 │ 307 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.RentalAgreement", b =>
 308 │ 308 │                 {
 309 │ 309 │                     b.HasOne("FleetTracker.Services.Core.Models.Customer", "Customer")
 310 │ 310 │                         .WithMany("RentalHistory")
 311 │ 311 │                         .HasForeignKey("CustomerId")
 312 │ 312 │

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs [317:2 - 384:2] (67 lines, 397 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs [315:8 - 382:2]

 317 │ 315 │ ior.Cascade)
 318 │ 316 │                         .IsRequired();
 319 │ 317 │
 320 │ 318 │                     b.Navigation("Customer");
 321 │ 319 │
 322 │ 320 │                     b.Navigation("Vehicle");
 323 │ 321 │                 });
 324 │ 322 │
 325 │ 323 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 326 │ 324 │                 {
 327 │ 325 │                     b.OwnsMany("FleetTracker.Services.Core.Models.MaintenanceRecord", "MaintenanceHistory", b1 =>
 328 │ 326 │                         {
 329 │ 327 │                             b1.Property<Guid>("Id")
 330 │ 328 │                                 .ValueGeneratedOnAdd()
 331 │ 329 │                                 .HasColumnType("uniqueidentifier");
 332 │ 330 │
 333 │ 331 │                             b1.Property<decimal>("Cost")
 334 │ 332 │                                 .HasColumnType("decimal(18,2)");
 335 │ 333 │
 336 │ 334 │                             b1.Property<string>("Description")
 337 │ 335 │                                 .IsRequired()
 338 │ 336 │                                 .HasColumnType("nvarchar(max)");
 339 │ 337 │
 340 │ 338 │                             b1.Property<DateTime>("ServiceDate")
 341 │ 339 │                                 .HasColumnType("datetime2");
 342 │ 340 │
 343 │ 341 │                             b1.Property<int>("Type")
 344 │ 342 │                                 .HasColumnType("int");
 345 │ 343 │
 346 │ 344 │                             b1.Property<Guid>("VehicleId")
 347 │ 345 │                                 .HasColumnType("uniqueidentifier");
 348 │ 346 │
 349 │ 347 │                             b1.Property<Guid?>("VehicleId1")
 350 │ 348 │                                 .HasColumnType("uniqueidentifier");
 351 │ 349 │
 352 │ 350 │                             b1.HasKey("Id");
 353 │ 351 │
 354 │ 352 │                             b1.HasIndex("VehicleId");
 355 │ 353 │
 356 │ 354 │                             b1.HasIndex("VehicleId1");
 357 │ 355 │
 358 │ 356 │                             b1.ToTable("MaintenanceRecord");
 359 │ 357 │
 360 │ 358 │                             b1.WithOwner()
 361 │ 359 │                                 .HasForeignKey("VehicleId");
 362 │ 360 │
 363 │ 361 │                             b1.HasOne("FleetTracker.Services.Core.Models.Vehicle", "Vehicle")
 364 │ 362 │                                 .WithMany()
 365 │ 363 │                                 .HasForeignKey("VehicleId1");
 366 │ 364 │
 367 │ 365 │                             b1.Navigation("Vehicle");
 368 │ 366 │                         });
 369 │ 367 │
 370 │ 368 │                     b.Navigation("MaintenanceHistory");
 371 │ 369 │                 });
 372 │ 370 │
 373 │ 371 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Customer", b =>
 374 │ 372 │                 {
 375 │ 373 │                     b.Navigation("RentalHistory");
 376 │ 374 │                 });
 377 │ 375 │
 378 │ 376 │             modelBuilder.Entity("FleetTracker.Services.Core.Models.Vehicle", b =>
 379 │ 377 │                 {
 380 │ 378 │                     b.Navigation("Rental

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
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [249:35 - 255:16] (6 lines, 90 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.ConsoleApp/Infrastructure/ApiFleetRepository.cs [241:37 - 247:12]

 249 │ 241 │ ).Result;

 250 │ 242 │             if (!response.IsSuccessStatusCode) return new List<RentalAgreement>();

 251 │ 243 │             var json = response.Content.ReadAsStringAsync().Result;

 252 │ 244 │             return JsonConvert.DeserializeObject<List<RentalAgreement>>(json, _jsonSettings) ?? new List<RentalAgreement>();

 253 │ 245 │         }

 254 │ 246 │

 255 │ 247 │         public RentalAgreement

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/VehicleManager.cs [415:22 - 428:9] (13 lines, 104 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/VehicleManager.cs [160:14 - 174:20]

 415 │ 160 │ );

 416 │ 161 │             var vehicle = _vehicleRepository.GetVehicleByVin(vin);

 417 │ 162 │             while (vehicle == null)

 418 │ 163 │             {

 419 │ 164 │                 vin = _console.PromptForVin("Vehicle not found. Try another VIN or type 'CANCEL' to go back: ");

 420 │ 165 │                 if (vin.Equals("CANCEL", StringComparison.OrdinalIgnoreCase))

 421 │ 166 │                 {

 422 │ 167 │                     return;

 423 │ 168 │                 }

 424 │ 169 │

 425 │ 170 │                 vehicle = _vehicleRepository.GetVehicleByVin(vin);

 426 │ 171 │             }

 427 │ 172 │

 428 │ 173 │             _console

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
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [122:27 - 132:21] (10 lines, 94 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [68:36 - 78:9]

 122 │ 68 │ );

 123 │ 69 │

 124 │ 70 │             var customer = _customerRepository.GetCustomerByLicense(license);

 125 │ 71 │             while (customer == null)

 126 │ 72 │             {

 127 │ 73 │                 license = _console.PromptForDriversLicense("Customer not found. Try another license or type 'CANCEL' to go back: ");

 128 │ 74 │                 if (license.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;

 129 │ 75 │                 customer = _customerRepository.GetCustomerByLicense(license);

 130 │ 76 │             }

 131 │ 77 │

 132 │ 78 │             PrintCustomerDetails

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [150:9 - 162:8] (12 lines, 94 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/VehicleManager.cs [196:8 - 208:9]

 150 │ 196 │ .Id).ToList();

 151 │ 197 │

 152 │ 198 │             if (rentals.Count == 0)

 153 │ 199 │             {

 154 │ 200 │                 _console.WriteLine("Total Rentals: 0");

 155 │ 201 │             }

 156 │ 202 │             else

 157 │ 203 │             {

 158 │ 204 │                 _console.WriteLine($"Total Rentals: {rentals.Count}");

 159 │ 205 │                 _console.WriteLine("Rental History:");

 160 │ 206 │                 foreach (var rh in rentals)

 161 │ 207 │                 {

 162 │ 208 │                     var vehicle

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/CustomerManager.cs [197:35 - 206:58] (9 lines, 96 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Application/Managers/RentalManager.cs [68:36 - 78:2]

 197 │ 68 │ );

 198 │ 69 │             var customer = _customerRepository.GetCustomerByLicense(license);

 199 │ 70 │             while (customer == null)

 200 │ 71 │             {

 201 │ 72 │                 license = _console.PromptForDriversLicense("Customer not found. Try another license or type 'CANCEL' to go back: ");

 202 │ 73 │                 if (license.Equals("CANCEL", StringComparison.OrdinalIgnoreCase)) return;

 203 │ 74 │                 customer = _customerRepository.GetCustomerByLicense(license);

 204 │ 75 │             }

 205 │ 76 │

 206 │ 77 │             _console.WriteLine("Enter new values or press Enter to keep current values."

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
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/CustomersController.cs [85:8 - 90:9] (5 lines, 133 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Api/Controllers/CustomersController.cs [54:11 - 59:4]

 85 │ 54 │ );

 86 │ 55 │

 87 │ 56 │             var billingAddress = new Address(request.PaymentInformation.BillingAddress.Street, request.PaymentInformation.BillingAddress.City, request.PaymentInformation.BillingAddress.State, request.PaymentInformation.BillingAddress.Zip, request.PaymentInformation.BillingAddress.Country);

 88 │ 57 │             var creditCard = new CreditCard(request.PaymentInformation.CreditCard.CardNumber, request.PaymentInformation.CreditCard.CardHolderName, request.PaymentInformation.CreditCard.ExpirationDate, request.PaymentInformation.CreditCard.Cvv);

 89 │ 58 │             var paymentInfo = new PaymentInformation(billingAddress, creditCard);

 90 │ 59 │             customer

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/EfFleetRepository.cs [126:9 - 137:9] (11 lines, 102 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Repositories/InMemoryFleetRepository.cs [77:9 - 88:10]

 126 │ 77 │ }

 127 │ 78 │

 128 │ 79 │         public void DeleteVehicle(Guid id)

 129 │ 80 │         {

 130 │ 81 │             var vehicle = GetVehicleById(id);

 131 │ 82 │             if (vehicle != null)

 132 │ 83 │             {

 133 │ 84 │                 if (vehicle.Status != VehicleStatus.Available && vehicle.Status != VehicleStatus.Unavailable)

 134 │ 85 │                 {

 135 │ 86 │                     throw new InvalidOperationException($"Cannot delete vehicle in status: {vehicle.Status}. Ensure the vehicle is Available or Unavailable first.");

 136 │ 87 │                 }

 137 │ 88 │                 _context

Clone found (csharp):
 - /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/EfFleetRepository.cs [184:12 - 196:9] (12 lines, 113 tokens)
   /github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Repositories/InMemoryFleetRepository.cs [105:7 - 117:2]

 184 │ 105 │ ();

 185 │ 106 │         }

 186 │ 107 │

 187 │ 108 │         public void CompleteRental(Guid id, int endingMileage)

 188 │ 109 │         {

 189 │ 110 │             var rental = GetRentalById(id);

 190 │ 111 │             if (rental != null)

 191 │ 112 │             {

 192 │ 113 │                 var vehicle = GetVehicleById(rental.VehicleId.GetValueOrDefault());

 193 │ 114 │                 if (vehicle != null)

 194 │ 115 │                 {

 195 │ 116 │                     vehicle.CompleteRental(rental, endingMileage);

 196 │ 117 │                     _context

Found 50 clones.
Error: ERROR: jscpd found too many duplicates (31.21%) over threshold (0%)
    at ThresholdReporter.report (/node_modules/@jscpd/finder/dist/index.js:615:13)
    at /node_modules/@jscpd/finder/dist/index.js:109:18
    at Array.forEach (<anonymous>)
    at /node_modules/@jscpd/finder/dist/index.js:108:22
    at async /node_modules/jscpd/dist/bin/jscpd.js:9:5ERROR: jscpd found too many duplicates (31.21%) over threshold (0%)
```

</details>

<details>

<summary>JSON</summary>

```text

/github/workspace/FleetTracker.Client/.vscode/extensions.json
  2:3  error  Unexpected comment  jsonc/no-comments

/github/workspace/FleetTracker.Client/.vscode/launch.json
  2:3  error  Unexpected comment  jsonc/no-comments

/github/workspace/FleetTracker.Client/.vscode/mcp.json
  2:3  error  Unexpected comment  jsonc/no-comments

/github/workspace/FleetTracker.Client/.vscode/tasks.json
  2:3  error  Unexpected comment  jsonc/no-comments

/github/workspace/FleetTracker.Client/tsconfig.app.json
  1:1  error  Unexpected comment  jsonc/no-comments
  2:1  error  Unexpected comment  jsonc/no-comments

/github/workspace/FleetTracker.Client/tsconfig.json
  1:1  error  Unexpected comment  jsonc/no-comments
  2:1  error  Unexpected comment  jsonc/no-comments

✖ 8 problems (8 errors, 0 warnings)
```

</details>

<details>

<summary>JSON_PRETTIER</summary>

```text
Checking formatting...[[33mwarn[39m] FleetTracker.Client/angular.json
[[33mwarn[39m] FleetTracker.Client/tsconfig.app.json
[[33mwarn[39m] github_conf/branch_protection_rules.json
[[33mwarn[39m] Code style issues found in 3 files. Run Prettier with --write to fix.
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

<summary>NATURAL_LANGUAGE</summary>

```text

/github/workspace/FleetTracker.Client/README.md
  49:17  ✓ error  Incorrect term: “e2e”, use “end-to-end” instead  terminology

✖ 1 problem (1 error, 0 warnings, 0 infos)
✓ 1 fixable problem.
Try to run: $ textlint --fix [file]
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
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/FleetTrackerDbContext.cs:37: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.Designer.cs:185: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260601134929_InitialCreate.cs:35: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602151152_MakeRentalIdsNullable.Designer.cs:185: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260602154919_MaintenanceCostPrecision.Designer.cs:185: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603140044_FixMaintenanceMapping.Designer.cs:214: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603152232_DecoupleRentalHistory.Designer.cs:181: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153037_AddRentalIndexes.Designer.cs:185: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603153426_AddCustomerLicenseIndex.Designer.cs:188: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/20260603155146_MakeMaintenanceRecordValueObject.Designer.cs:188: HomeState ==> home state
/github/workspace/FleetTracker.Services/FleetTracker.Services.Data/Migrations/FleetTrackerDbContextModelSnapshot.cs:185: HomeState ==> home state
/github/workspace/SeedData.sql:1: HomeState ==> home state
/github/workspace/SeedData.sql:2: HomeState ==> home state
/github/workspace/SeedData.sql:3: HomeState ==> home state
/github/workspace/SeedData.sql:4: HomeState ==> home state
/github/workspace/SeedData.sql:5: HomeState ==> home state
/github/workspace/SeedData.sql:6: HomeState ==> home state
/github/workspace/SeedData.sql:7: HomeState ==> home state
/github/workspace/SeedData.sql:8: HomeState ==> home state
/github/workspace/SeedData.sql:9: HomeState ==> home state
/github/workspace/SeedData.sql:10: HomeState ==> home state
/github/workspace/SeedData.sql:11: HomeState ==> home state
/github/workspace/SeedData.sql:12: HomeState ==> home state
/github/workspace/SeedData.sql:13: HomeState ==> home state
/github/workspace/SeedData.sql:14: HomeState ==> home state
/github/workspace/SeedData.sql:15: HomeState ==> home state
/github/workspace/SeedData.sql:16: HomeState ==> home state
/github/workspace/SeedData.sql:17: HomeState ==> home state
/github/workspace/SeedData.sql:18: HomeState ==> home state
/github/workspace/SeedData.sql:19: HomeState ==> home state
/github/workspace/SeedData.sql:20: HomeState ==> home state
/github/workspace/SeedData.sql:21: HomeState ==> home state
/github/workspace/SeedData.sql:22: HomeState ==> home state
/github/workspace/SeedData.sql:23: HomeState ==> home state
/github/workspace/SeedData.sql:24: HomeState ==> home state
/github/workspace/SeedData.sql:25: HomeState ==> home state
/github/workspace/SeedData.sql:26: HomeState ==> home state
/github/workspace/SeedData.sql:27: HomeState ==> home state
/github/workspace/SeedData.sql:28: HomeState ==> home state
/github/workspace/SeedData.sql:29: HomeState ==> home state
/github/workspace/SeedData.sql:30: HomeState ==> home state
/github/workspace/SeedData.sql:31: HomeState ==> home state
/github/workspace/SeedData.sql:32: HomeState ==> home state
/github/workspace/SeedData.sql:33: HomeState ==> home state
/github/workspace/SeedData.sql:34: HomeState ==> home state
/github/workspace/SeedData.sql:35: HomeState ==> home state
/github/workspace/SeedData.sql:36: HomeState ==> home state
/github/workspace/SeedData.sql:37: HomeState ==> home state
/github/workspace/SeedData.sql:38: HomeState ==> home state
/github/workspace/SeedData.sql:39: HomeState ==> home state
/github/workspace/SeedData.sql:40: HomeState ==> home state
/github/workspace/SeedData.sql:41: HomeState ==> home state
/github/workspace/SeedData.sql:42: HomeState ==> home state
/github/workspace/SeedData.sql:43: HomeState ==> home state
/github/workspace/SeedData.sql:44: HomeState ==> home state
/github/workspace/SeedData.sql:45: HomeState ==> home state
/github/workspace/SeedData.sql:46: HomeState ==> home state
/github/workspace/SeedData.sql:47: HomeState ==> home state
/github/workspace/SeedData.sql:48: HomeState ==> home state
/github/workspace/SeedData.sql:49: HomeState ==> home state
/github/workspace/SeedData.sql:50: HomeState ==> home state
/github/workspace/SeedData.sql:51: HomeState ==> home state
/github/workspace/SeedData.sql:52: HomeState ==> home state
/github/workspace/SeedData.sql:53: HomeState ==> home state
/github/workspace/SeedData.sql:54: HomeState ==> home state
/github/workspace/SeedData.sql:55: HomeState ==> home state
/github/workspace/SeedData.sql:56: HomeState ==> home state
/github/workspace/SeedData.sql:57: HomeState ==> home state
/github/workspace/SeedData.sql:58: HomeState ==> home state
/github/workspace/SeedData.sql:59: HomeState ==> home state
/github/workspace/SeedData.sql:60: HomeState ==> home state
/github/workspace/SeedData.sql:61: HomeState ==> home state
/github/workspace/SeedData.sql:62: HomeState ==> home state
/github/workspace/SeedData.sql:63: HomeState ==> home state
/github/workspace/SeedData.sql:64: HomeState ==> home state
/github/workspace/SeedData.sql:65: HomeState ==> home state
/github/workspace/SeedData.sql:66: HomeState ==> home state
/github/workspace/SeedData.sql:67: HomeState ==> home state
/github/workspace/SeedData.sql:68: HomeState ==> home state
/github/workspace/SeedData.sql:69: HomeState ==> home state
/github/workspace/SeedData.sql:70: HomeState ==> home state
/github/workspace/SeedData.sql:71: HomeState ==> home state
/github/workspace/SeedData.sql:72: HomeState ==> home state
/github/workspace/SeedData.sql:73: HomeState ==> home state
/github/workspace/SeedData.sql:74: HomeState ==> home state
/github/workspace/SeedData.sql:75: HomeState ==> home state
/github/workspace/SeedData.sql:76: HomeState ==> home state
/github/workspace/SeedData.sql:77: HomeState ==> home state
/github/workspace/SeedData.sql:78: HomeState ==> home state
/github/workspace/SeedData.sql:79: HomeState ==> home state
/github/workspace/SeedData.sql:80: HomeState ==> home state
/github/workspace/SeedData.sql:81: HomeState ==> home state
/github/workspace/SeedData.sql:82: HomeState ==> home state
/github/workspace/SeedData.sql:83: HomeState ==> home state
/github/workspace/SeedData.sql:84: HomeState ==> home state
/github/workspace/SeedData.sql:85: HomeState ==> home state
/github/workspace/SeedData.sql:86: HomeState ==> home state
/github/workspace/SeedData.sql:87: HomeState ==> home state
/github/workspace/SeedData.sql:88: HomeState ==> home state
/github/workspace/SeedData.sql:89: HomeState ==> home state
/github/workspace/SeedData.sql:90: HomeState ==> home state
/github/workspace/SeedData.sql:91: HomeState ==> home state
/github/workspace/SeedData.sql:92: HomeState ==> home state
/github/workspace/SeedData.sql:93: HomeState ==> home state
/github/workspace/SeedData.sql:94: HomeState ==> home state
/github/workspace/SeedData.sql:95: HomeState ==> home state
/github/workspace/SeedData.sql:96: HomeState ==> home state
/github/workspace/SeedData.sql:97: HomeState ==> home state
/github/workspace/SeedData.sql:98: HomeState ==> home state
/github/workspace/SeedData.sql:99: HomeState ==> home state
/github/workspace/SeedData.sql:100: HomeState ==> home state
```

</details>

<details>

<summary>SQLFLUFF</summary>

```text

User Error: No dialect was specified. You must configure a dialect or specify one on the command line using --dialect after the command. Available dialects:
ansi, athena, bigquery, clickhouse, databricks, db2, doris, duckdb, exasol, flink, greenplum, hive, impala, mariadb, materialize, mysql, oracle, postgres, redshift, snowflake, soql, sparksql, sqlite, starrocks, teradata, trino, tsql, vertica
```

</details>

<details>

<summary>TYPESCRIPT_ES</summary>

```text

/github/workspace/FleetTracker.Client/src/app/app.config.ts
  1:63  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app'                         n/no-missing-import
  2:31  error  Can't resolve '@angular/router' in '/github/workspace/FleetTracker.Client/src/app'                       n/no-missing-import
  3:35  error  Can't resolve '@angular/common/http' in '/github/workspace/FleetTracker.Client/src/app'                  n/no-missing-import
  4:35  error  Can't resolve '@angular/platform-browser/animations' in '/github/workspace/FleetTracker.Client/src/app'  n/no-missing-import
  5:24  error  Can't resolve './app.routes' in '/github/workspace/FleetTracker.Client/src/app'                          n/no-missing-import

/github/workspace/FleetTracker.Client/src/app/app.routes.ts
  1:24  error  Can't resolve '@angular/router' in '/github/workspace/FleetTracker.Client/src/app'                        n/no-missing-import
  2:36  error  Can't resolve './dashboard/dashboard.component' in '/github/workspace/FleetTracker.Client/src/app'        n/no-missing-import
  3:35  error  Can't resolve './vehicles/vehicles.component' in '/github/workspace/FleetTracker.Client/src/app'          n/no-missing-import
  4:40  error  Can't resolve './vehicles/vehicle-manage.component' in '/github/workspace/FleetTracker.Client/src/app'    n/no-missing-import
  5:34  error  Can't resolve './rentals/rentals.component' in '/github/workspace/FleetTracker.Client/src/app'            n/no-missing-import
  6:39  error  Can't resolve './rentals/rental-create.component' in '/github/workspace/FleetTracker.Client/src/app'      n/no-missing-import
  7:36  error  Can't resolve './customers/customers.component' in '/github/workspace/FleetTracker.Client/src/app'        n/no-missing-import
  8:41  error  Can't resolve './customers/customer-manage.component' in '/github/workspace/FleetTracker.Client/src/app'  n/no-missing-import
  9:39  error  Can't resolve './rentals/rental-manage.component' in '/github/workspace/FleetTracker.Client/src/app'      n/no-missing-import

/github/workspace/FleetTracker.Client/src/app/app.ts
  1:27  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app'    n/no-missing-import
  2:60  error  Can't resolve '@angular/router' in '/github/workspace/FleetTracker.Client/src/app'  n/no-missing-import

/github/workspace/FleetTracker.Client/src/app/customers/customer-manage.component.ts
    1:43  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app/customers'              n/no-missing-import
    2:73  error  Can't resolve '@angular/forms' in '/github/workspace/FleetTracker.Client/src/app/customers'             n/no-missing-import
    3:52  error  Can't resolve '@angular/router' in '/github/workspace/FleetTracker.Client/src/app/customers'            n/no-missing-import
    4:46  error  Can't resolve '../services/api.service' in '/github/workspace/FleetTracker.Client/src/app/customers'    n/no-missing-import
    5:30  error  Can't resolve '../services/toast.service' in '/github/workspace/FleetTracker.Client/src/app/customers'  n/no-missing-import
    6:28  error  Can't resolve '../store/fleet.store' in '/github/workspace/FleetTracker.Client/src/app/customers'       n/no-missing-import
    7:30  error  Can't resolve '@angular/common' in '/github/workspace/FleetTracker.Client/src/app/customers'            n/no-missing-import
    8:37  error  Can't resolve '../models/enums' in '/github/workspace/FleetTracker.Client/src/app/customers'            n/no-missing-import
  178:27  error  Unexpected any. Specify a different type                                                                @typescript-eslint/no-explicit-any

/github/workspace/FleetTracker.Client/src/app/customers/customers.component.ts
  1:43  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app/customers'         n/no-missing-import
  2:30  error  Can't resolve '@angular/common' in '/github/workspace/FleetTracker.Client/src/app/customers'       n/no-missing-import
  3:28  error  Can't resolve '@angular/router' in '/github/workspace/FleetTracker.Client/src/app/customers'       n/no-missing-import
  4:29  error  Can't resolve '@angular/forms' in '/github/workspace/FleetTracker.Client/src/app/customers'        n/no-missing-import
  5:28  error  Can't resolve '../store/fleet.store' in '/github/workspace/FleetTracker.Client/src/app/customers'  n/no-missing-import
  6:27  error  Can't resolve '../pipes/phone.pipe' in '/github/workspace/FleetTracker.Client/src/app/customers'   n/no-missing-import

/github/workspace/FleetTracker.Client/src/app/dashboard/dashboard.component.ts
   1:74  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app/dashboard'         n/no-missing-import
   2:30  error  Can't resolve '@angular/common' in '/github/workspace/FleetTracker.Client/src/app/dashboard'       n/no-missing-import
   3:29  error  Can't resolve '@angular/forms' in '/github/workspace/FleetTracker.Client/src/app/dashboard'        n/no-missing-import
   4:28  error  Can't resolve '@angular/router' in '/github/workspace/FleetTracker.Client/src/app/dashboard'       n/no-missing-import
   5:28  error  Can't resolve '../store/fleet.store' in '/github/workspace/FleetTracker.Client/src/app/dashboard'  n/no-missing-import
   6:38  error  Can't resolve '../models/enums' in '/github/workspace/FleetTracker.Client/src/app/dashboard'       n/no-missing-import
   7:19  error  Can't resolve 'chart.js/auto' in '/github/workspace/FleetTracker.Client/src/app/dashboard'         n/no-missing-import
  67:38  error  Unexpected any. Specify a different type                                                           @typescript-eslint/no-explicit-any
  96:29  error  Unexpected any. Specify a different type                                                           @typescript-eslint/no-explicit-any

/github/workspace/FleetTracker.Client/src/app/pipes/phone.pipe.ts
  1:37  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app/pipes'  n/no-missing-import

/github/workspace/FleetTracker.Client/src/app/rentals/rental-create.component.ts
  1:43  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app/rentals'              n/no-missing-import
  2:73  error  Can't resolve '@angular/forms' in '/github/workspace/FleetTracker.Client/src/app/rentals'             n/no-missing-import
  3:24  error  Can't resolve '@angular/router' in '/github/workspace/FleetTracker.Client/src/app/rentals'            n/no-missing-import
  4:28  error  Can't resolve '../services/api.service' in '/github/workspace/FleetTracker.Client/src/app/rentals'    n/no-missing-import
  5:30  error  Can't resolve '../services/toast.service' in '/github/workspace/FleetTracker.Client/src/app/rentals'  n/no-missing-import
  6:28  error  Can't resolve '../store/fleet.store' in '/github/workspace/FleetTracker.Client/src/app/rentals'       n/no-missing-import
  7:30  error  Can't resolve '@angular/common' in '/github/workspace/FleetTracker.Client/src/app/rentals'            n/no-missing-import

/github/workspace/FleetTracker.Client/src/app/rentals/rental-manage.component.ts
  1:43  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app/rentals'              n/no-missing-import
  2:73  error  Can't resolve '@angular/forms' in '/github/workspace/FleetTracker.Client/src/app/rentals'             n/no-missing-import
  3:52  error  Can't resolve '@angular/router' in '/github/workspace/FleetTracker.Client/src/app/rentals'            n/no-missing-import
  4:36  error  Can't resolve '../services/api.service' in '/github/workspace/FleetTracker.Client/src/app/rentals'    n/no-missing-import
  5:30  error  Can't resolve '../services/toast.service' in '/github/workspace/FleetTracker.Client/src/app/rentals'  n/no-missing-import
  6:28  error  Can't resolve '../store/fleet.store' in '/github/workspace/FleetTracker.Client/src/app/rentals'       n/no-missing-import
  7:30  error  Can't resolve '@angular/common' in '/github/workspace/FleetTracker.Client/src/app/rentals'            n/no-missing-import
  8:37  error  Can't resolve '../models/enums' in '/github/workspace/FleetTracker.Client/src/app/rentals'            n/no-missing-import

/github/workspace/FleetTracker.Client/src/app/rentals/rentals.component.ts
  1:43  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app/rentals'              n/no-missing-import
  2:40  error  Can't resolve '@angular/common' in '/github/workspace/FleetTracker.Client/src/app/rentals'            n/no-missing-import
  3:28  error  Can't resolve '@angular/router' in '/github/workspace/FleetTracker.Client/src/app/rentals'            n/no-missing-import
  4:29  error  Can't resolve '@angular/forms' in '/github/workspace/FleetTracker.Client/src/app/rentals'             n/no-missing-import
  5:28  error  Can't resolve '../store/fleet.store' in '/github/workspace/FleetTracker.Client/src/app/rentals'       n/no-missing-import
  6:28  error  Can't resolve '../services/api.service' in '/github/workspace/FleetTracker.Client/src/app/rentals'    n/no-missing-import
  7:30  error  Can't resolve '../services/toast.service' in '/github/workspace/FleetTracker.Client/src/app/rentals'  n/no-missing-import

/github/workspace/FleetTracker.Client/src/app/services/api.service.ts
    1:28  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app/services'         n/no-missing-import
    2:47  error  Can't resolve '@angular/common/http' in '/github/workspace/FleetTracker.Client/src/app/services'  n/no-missing-import
    3:40  error  Can't resolve 'rxjs' in '/github/workspace/FleetTracker.Client/src/app/services'                  n/no-missing-import
    4:28  error  Can't resolve 'rxjs/operators' in '/github/workspace/FleetTracker.Client/src/app/services'        n/no-missing-import
   96:47  error  Unexpected any. Specify a different type                                                          @typescript-eslint/no-explicit-any
   97:27  error  Unexpected any. Specify a different type                                                          @typescript-eslint/no-explicit-any
  100:42  error  Unexpected any. Specify a different type                                                          @typescript-eslint/no-explicit-any
  129:36  error  Unexpected any. Specify a different type                                                          @typescript-eslint/no-explicit-any
  162:90  error  Unexpected any. Specify a different type                                                          @typescript-eslint/no-explicit-any

/github/workspace/FleetTracker.Client/src/app/services/toast.service.ts
  1:36  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app/services'                n/no-missing-import
  2:29  error  Can't resolve '@angular/material/snack-bar' in '/github/workspace/FleetTracker.Client/src/app/services'  n/no-missing-import

/github/workspace/FleetTracker.Client/src/app/store/fleet.store.ts
    1:34  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app/store'               n/no-missing-import
    2:79  error  Can't resolve '@ngrx/signals' in '/github/workspace/FleetTracker.Client/src/app/store'               n/no-missing-import
    3:26  error  Can't resolve '@ngrx/signals/rxjs-interop' in '/github/workspace/FleetTracker.Client/src/app/store'  n/no-missing-import
    4:29  error  Can't resolve '@ngrx/operators' in '/github/workspace/FleetTracker.Client/src/app/store'             n/no-missing-import
    5:48  error  Can't resolve 'rxjs' in '/github/workspace/FleetTracker.Client/src/app/store'                        n/no-missing-import
    6:55  error  Can't resolve '../services/api.service' in '/github/workspace/FleetTracker.Client/src/app/store'     n/no-missing-import
  116:56  error  Unexpected any. Specify a different type                                                             @typescript-eslint/no-explicit-any

/github/workspace/FleetTracker.Client/src/app/vehicles/vehicle-manage.component.ts
  1:43  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app/vehicles'              n/no-missing-import
  2:73  error  Can't resolve '@angular/forms' in '/github/workspace/FleetTracker.Client/src/app/vehicles'             n/no-missing-import
  3:52  error  Can't resolve '@angular/router' in '/github/workspace/FleetTracker.Client/src/app/vehicles'            n/no-missing-import
  4:45  error  Can't resolve '../services/api.service' in '/github/workspace/FleetTracker.Client/src/app/vehicles'    n/no-missing-import
  5:30  error  Can't resolve '../services/toast.service' in '/github/workspace/FleetTracker.Client/src/app/vehicles'  n/no-missing-import
  6:28  error  Can't resolve '../store/fleet.store' in '/github/workspace/FleetTracker.Client/src/app/vehicles'       n/no-missing-import
  7:30  error  Can't resolve '@angular/common' in '/github/workspace/FleetTracker.Client/src/app/vehicles'            n/no-missing-import
  8:61  error  Can't resolve '../models/enums' in '/github/workspace/FleetTracker.Client/src/app/vehicles'            n/no-missing-import

/github/workspace/FleetTracker.Client/src/app/vehicles/vehicles.component.ts
   1:43  error  Can't resolve '@angular/core' in '/github/workspace/FleetTracker.Client/src/app/vehicles'         n/no-missing-import
   2:44  error  Can't resolve '@angular/common' in '/github/workspace/FleetTracker.Client/src/app/vehicles'       n/no-missing-import
   3:28  error  Can't resolve '@angular/router' in '/github/workspace/FleetTracker.Client/src/app/vehicles'       n/no-missing-import
   4:29  error  Can't resolve '@angular/forms' in '/github/workspace/FleetTracker.Client/src/app/vehicles'        n/no-missing-import
   5:28  error  Can't resolve '../store/fleet.store' in '/github/workspace/FleetTracker.Client/src/app/vehicles'  n/no-missing-import
   6:38  error  Can't resolve '../models/enums' in '/github/workspace/FleetTracker.Client/src/app/vehicles'       n/no-missing-import
  38:29  error  Unexpected any. Specify a different type                                                          @typescript-eslint/no-explicit-any

/github/workspace/FleetTracker.Client/src/main.ts
  1:38  error  Can't resolve '@angular/platform-browser' in '/github/workspace/FleetTracker.Client/src'  n/no-missing-import
  2:27  error  Can't resolve './app/app.config' in '/github/workspace/FleetTracker.Client/src'           n/no-missing-import
  3:21  error  Can't resolve './app/app' in '/github/workspace/FleetTracker.Client/src'                  n/no-missing-import

✖ 99 problems (99 errors, 0 warnings)Warning: React version not specified in eslint-plugin-react settings. See https://github.com/jsx-eslint/eslint-plugin-react#configuration .
```

</details>

<details>

<summary>TYPESCRIPT_PRETTIER</summary>

```text
Checking formatting...[[33mwarn[39m] FleetTracker.Client/src/app/customers/customers.component.ts
[[33mwarn[39m] FleetTracker.Client/src/app/dashboard/dashboard.component.ts
[[33mwarn[39m] FleetTracker.Client/src/app/models/enums.ts
[[33mwarn[39m] FleetTracker.Client/src/app/pipes/phone.pipe.ts
[[33mwarn[39m] FleetTracker.Client/src/app/rentals/rental-create.component.ts
[[33mwarn[39m] FleetTracker.Client/src/app/rentals/rental-manage.component.ts
[[33mwarn[39m] FleetTracker.Client/src/app/rentals/rentals.component.ts
[[33mwarn[39m] FleetTracker.Client/src/app/services/api.service.ts
[[33mwarn[39m] FleetTracker.Client/src/app/customers/customer-manage.component.ts
[[33mwarn[39m] FleetTracker.Client/src/app/store/fleet.store.ts
[[33mwarn[39m] FleetTracker.Client/src/app/vehicles/vehicle-manage.component.ts
[[33mwarn[39m] FleetTracker.Client/src/app/vehicles/vehicles.component.ts
[[33mwarn[39m] FleetTracker.Client/src/main.ts
[[33mwarn[39m] Code style issues found in 13 files. Run Prettier with --write to fix.
```

</details>
