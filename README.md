# netcore30-efcore

A sample MVC app which uses the latest preview (currently 7) of .NET SDK 3.0 together with EF Core. 

## Requirements

- .NET SDK: `3.0.100-preview7-012821`
- `dotnet ef` version `3.0.0-preview7.19362.6` installed as a global tool. [See here how to install](https://docs.microsoft.com/en-us/ef/core/what-is-new/ef-core-3.0/breaking-changes#the-ef-core-command-line-tool-dotnet-ef-is-no-longer-part-of-the-net-core-sdk)


## The app

The app contains a simple `DbContext` with one `DbSet`. 

## Adding a migration

- Navigate to `src\WebApplication11`
- Issue the command `dotnet ef migrations add Init`
- The migration should be added
