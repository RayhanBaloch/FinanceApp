# .NET 10 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that a .NET 10 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 10 upgrade.
3. Upgrade FinanceAppUI.WPF\FinanceAppUI.WPF.csproj
4. Upgrade FinanceApp.Core\FinanceApp.Core.csproj

## Settings

This section contains settings and data used by execution steps.

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                                | Current Version | New Version | Description                                                    |
|:--------------------------------------------|:---------------:|:-----------:|:---------------------------------------------------------------|
| MaterialDesignThemes                        | 5.3.0           | 5.2.1       | Incompatible with .NET 10                                      |
| Microsoft.EntityFrameworkCore               | 9.0.8           | 10.0.0      | Recommended for .NET 10                                        |
| Microsoft.EntityFrameworkCore.Design        | 9.0.8           | 10.0.0      | Recommended for .NET 10                                        |
| Microsoft.EntityFrameworkCore.SqlServer     | 9.0.8           | 10.0.0      | Recommended for .NET 10                                        |
| Microsoft.Extensions.DependencyInjection    | 9.0.8           | 10.0.0      | Recommended for .NET 10                                        |
| Microsoft.Extensions.Hosting                | 9.0.8           | 10.0.0      | Recommended for .NET 10                                        |
| Microsoft.Xaml.Behaviors.Wpf                | 1.1.135         | 1.1.39      | Incompatible with .NET 10                                      |

### Project upgrade details

This section contains details about each project upgrade and modifications that need to be done in the project.

#### FinanceAppUI.WPF\FinanceAppUI.WPF.csproj modifications

Project properties changes:
  - Target framework should be changed from `net8.0-windows` to `net10.0-windows`

NuGet packages changes:
  - MaterialDesignThemes should be updated from `5.3.0` to `5.2.1` (*incompatible with .NET 10*)
  - Microsoft.EntityFrameworkCore should be updated from `9.0.8` to `10.0.0` (*recommended for .NET 10*)
  - Microsoft.EntityFrameworkCore.Design should be updated from `9.0.8` to `10.0.0` (*recommended for .NET 10*)
  - Microsoft.EntityFrameworkCore.SqlServer should be updated from `9.0.8` to `10.0.0` (*recommended for .NET 10*)
  - Microsoft.Extensions.DependencyInjection should be updated from `9.0.8` to `10.0.0` (*recommended for .NET 10*)
  - Microsoft.Extensions.Hosting should be updated from `9.0.8` to `10.0.0` (*recommended for .NET 10*)
  - Microsoft.Xaml.Behaviors.Wpf should be updated from `1.1.135` to `1.1.39` (*incompatible with .NET 10*)

#### FinanceApp.Core\FinanceApp.Core.csproj modifications

Project properties changes:
  - Target framework should be changed from `net8.0` to `net10.0`

NuGet packages changes:
  - Microsoft.EntityFrameworkCore should be updated from `9.0.8` to `10.0.0` (*recommended for .NET 10*)
  - Microsoft.EntityFrameworkCore.Design should be updated from `9.0.8` to `10.0.0` (*recommended for .NET 10*)
  - Microsoft.EntityFrameworkCore.SqlServer should be updated from `9.0.8` to `10.0.0` (*recommended for .NET 10*)
