# .NET 10 Upgrade Report

## Project target framework modifications

| Project name                                   | Old Target Framework | New Target Framework | Commits                                      |
|:-----------------------------------------------|:--------------------:|:--------------------:|----------------------------------------------|
| FinanceAppUI.WPF\FinanceAppUI.WPF.csproj       | net8.0-windows       | net10.0-windows      | c5ef9b0d, dc6ed3e9                           |
| FinanceApp.Core\FinanceApp.Core.csproj         | net8.0               | net10.0              | e3463eb0, 16d6d713                           |

## NuGet Packages

| Package Name                             | Old Version | New Version | Commit Id                                    |
|:-----------------------------------------|:-----------:|:-----------:|----------------------------------------------|
| MaterialDesignThemes                     | 5.3.0       | 5.2.1       | c5ef9b0d                                     |
| Microsoft.EntityFrameworkCore            | 9.0.8       | 10.0.0      | c5ef9b0d, 16d6d713                           |
| Microsoft.EntityFrameworkCore.Design     | 9.0.8       | 10.0.0      | c5ef9b0d, 16d6d713                           |
| Microsoft.EntityFrameworkCore.SqlServer  | 9.0.8       | 10.0.0      | c5ef9b0d, 16d6d713                           |
| Microsoft.Extensions.DependencyInjection | 9.0.8       | 10.0.0      | c5ef9b0d                                     |
| Microsoft.Extensions.Hosting             | 9.0.8       | 10.0.0      | c5ef9b0d                                     |
| Microsoft.Xaml.Behaviors.Wpf             | 1.1.135     | 1.1.39      | c5ef9b0d                                     |

## All commits

| Commit ID  | Description                                                                                                          |
|:-----------|:---------------------------------------------------------------------------------------------------------------------|
| c96d02e9   | Commit upgrade plan                                                                                                  |
| c5ef9b0d   | Update package versions in FinanceAppUI.WPF.csproj                                                                   |
| dc6ed3e9   | Update FinanceAppUI.WPF.csproj to .NET 10 and fix App.xaml                                                           |
| e3463eb0   | Update FinanceApp.Core.csproj to target .NET 10.0                                                                    |
| 16d6d713   | Update FinanceApp.Core.csproj to EF Core 10.0.0                                                                      |

## Summary

The upgrade from .NET 8 to .NET 10 has been completed successfully for all projects in the Finance App solution:

### FinanceAppUI.WPF
- Upgraded target framework from `net8.0-windows` to `net10.0-windows`
- Updated Entity Framework Core packages from version 9.0.8 to 10.0.0
- Updated Microsoft.Extensions packages (DependencyInjection, Hosting) from version 9.0.8 to 10.0.0
- Downgraded MaterialDesignThemes from 5.3.0 to 5.2.1 for .NET 10 compatibility
- Downgraded Microsoft.Xaml.Behaviors.Wpf from 1.1.135 to 1.1.39 for .NET 10 compatibility
- Fixed App.xaml formatting

### FinanceApp.Core
- Upgraded target framework from `net8.0` to `net10.0`
- Updated Entity Framework Core packages from version 9.0.8 to 10.0.0

## Next steps

- Test your application thoroughly to ensure all functionality works correctly with .NET 10
- Review any WPF-specific features that may have changed between .NET 8 and .NET 10
- Monitor for updates to MaterialDesignThemes and Microsoft.Xaml.Behaviors.Wpf packages that will support .NET 10 natively
- Consider updating any other third-party packages to their latest versions
- Run all unit and integration tests to verify the upgrade
