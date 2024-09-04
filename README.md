## EntityFramework.Filesystem 

FileBaseContext is a EntityFramework.Filesystem Provider for Net8+

Store tables in file, easy 'Serverless' file system text file serialised ef db persistance

https://learn.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli

Similar projects : 

## FileContextCore - Offers Different serializer supported (XML, JSON, CSV, Excel) no support Net4+
https://github.com/morrisjdev/FileContextCore
https://www.nuget.org/packages/FileContextCore/
Frameworks based on the idea of FileContext by DevMentor (https://github.com/pmizel/DevMentor.Context.FileContext)


**FileBaseContext** is a provider of **Entity Framework Core 8** to store database information in files. 

Powerful file based database provider for Entity Framework Core, easy 'Serverless' file system text file serialised ef db persistance

Works for
- Unit Test - Mocking
- Serverless db persistance, easier than Sqlite (Tables are created for one thing)
- Works cross platform, easy offline persistant data store
      
Although it was built for development purposes, it works for serverless db persistance. All information is stored in files that can be added, updated, or deleted manually via file system.

It can be used with Although it was built for development purposes. 

All information is stored in files that can be added, updated, or deleted manually.

## Benefits
- Easier than Sqlite, just works 
- you don't need a database server
- rapid modeling
- version control supported
- supports all serializable .NET types-
- unit tests

## Download



https://www.nuget.org/packages/EntityFramework.Filesystem/

## Configure Database Context

add database context to services

```cs
services.AddDbContext<ApplicationDbContext>(options => options.UseFileBaseContextDatabase("dbUser"));
```

or configure the database context itself

```cs

public static string DatabaseName = "my_local_db"; // Will create folder  \bin\my_local_db and tables.json files

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseFileBaseContextDatabase(databaseName: DatabaseName); 
}
```

## Configure Provider

##### Named database 
```cs
 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseFileBaseContextDatabase(databaseName: DatabaseName); 
    }
```

##### Custom location
```cs
optionsBuilder.UseFileBaseContextDatabase(location: "C:\Temp\userDb");
```

## Unit testing

Since 2.1.0 the FileBaseContext injects access to the file system through System.IO.Abstractions library. It allows the use of the provider in unit tests.

If you need to use the provider in unit tests, you can change IFileSystem to MockFileSystem in OnConfiguring method in datacontext class.

```cs
private readonly MockFileSystem _fileSystem;
public DbTestContext(MockFileSystem fileSystem)
{
    _fileSystem = fileSystem;
}

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseFileBaseContextDatabase(DatabaseName, null, services =>
    {
        services.AddMockFileSystem(_fileSystem);
    });
}
```
Please find example in the SimplePositiveTests class in the test project

## New in 4.0.0

Since the 4.0.0 version the FileBaseContext supports persisting data in the CSV files.
The CSV files are stored in the directory with the database name. 
The CSV files are named by the entity name. 
The first row in the CSV file is the header with the column names.

## ! Braking changes in 3.0.0 !

In 3.0.0 version the provider was changed to support numeric values without quotation marks.

```
{
    "IntProp": 42,
    "LongProperty": 420,
    "DateTime": "2023-12-26T19:28:08"
}
```

The led to breaking changes in the provider. If you have used the provider before, you need to manualy update the database files. 
The changes also affect on DateTime and DateTimeOffset values. The values are stored as string in the database.
First run of the application could be slow becasuse a lot of System.Text.Json.JsonException will be provided.
Performance be fixed after provider saves a database to files. While that the data will be stored in new formats.
If you still have performance issues you need to manualy update the database files.
