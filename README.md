# efcore
Implementation of Unit Of Work pattern with Entity Framework Core in .NET 6

## How to populate database
Set the "src" project as startup project. Open Package Manager Console and select "src" as the default project. Go to db/DataContext.cs. Comment out the 
DataContext constructor (already done) and allow the hardcoded connection string when adding/updating migration (already done).

``` Add-Migration ```

``` Update-Database ```

After migration, undo the DataContext constructor and the hardcoded connection string.
