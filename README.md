# efcore
Implementation of Unit Of Work pattern with Entity Framework Core in .NET 6

## How to populate database

Set the "src" project as startup project. Open Package Manager Console and select "src" as the default project. Go to db/DataContext.cs. Comment out the 
DataContext constructor when adding/updating migration.

``` Add-Migration ```
``` Update-Database ```

After migration, undo the DataContext constructor.
