# EntityFilesystem
An EntityFramework Filesystem Provider

Adds the ability to store information in files instead of being limited to databases.

FileBaseContext is a EntityFramework Filesystem Provider for Net8+

Works for
- Unit Test - Mocking
- Serverless db persistance, easier than Sqlite (Tables are created for one thing)
- Works cross platform, easy offline persistant data store
  
## Usage

Install nuget package **EntityFilesystem**
```csharp
PM> Install-Package Microsoft.EntityFrameworkCore
PM> Install-Package EntityFilesystem
```

```csharp
// DbStartup.cs
using FileBaseContext.Extensions;

partial void CustomInit(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseFileBaseContextDatabase(databaseName: "DbFolderName");
}
```

## Examples 

Created with [Entity Framework Visual Editor Extension](https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner2022) from Visual Studio Marketplace

 - [Ex1_ModelPerson](https://github.com/Opzet/EFDesignerExamples/tree/main/EFCore/Ex1_ModelPerson)
 - [Ex2_ModelOne2One](https://github.com/Opzet/EFDesignerExamples/tree/main/EFCore/Ex2_ModelOne2One)
 - [Ex3_ModelOnetoMany](https://github.com/Opzet/EFDesignerExamples/tree/main/EFCore/Ex3_ModelOnetoMany)
 - [Ex4_ModelInvoice](https://github.com/Opzet/EFDesignerExamples/tree/main/EFCore/Ex4_ModelInvoice)
 - [Ex5_Course](https://github.com/Opzet/EFDesignerExamples/tree/main/EFCore/Ex5_Course)
 - [Ex6_Mvp](https://github.com/Opzet/EFDesignerExamples/tree/main/EFCore/Ex6_Mvp)
   
[https://github.com/Opzet/EFDesignerExamples](https://github.com/Opzet/EFDesignerExamples/tree/main/EFCore)

**NUGET** package https://www.nuget.org/packages/EntityFilesystem 

https://learn.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli

## Benefits
Store tables in file, easy 'Serverless' file system text file serialised ef db persistance

- Easier than Sqlite, just works 
- you don't need a database server
- rapid modeling
- version control supported
- supports all serializable .NET types
- unit tests


## Configure Provider
Powerful file based database provider for Entity Framework Core, easy 'Serverless' file system text file serialised ef db persistance
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
## History / Forks

File system Entity Frameworks Providers

### a. FileContext by DevMentor 
https://github.com/pmizel/DevMentor.Context.FileContext
Core 2+ 

### b. FileContextCore by morrisjdev
https://github.com/morrisjdev/FileContextCore
Offers Different serializer supported (XML, JSON, CSV, Excel) 
Core 2/3 - last update Aug 2, 2020

### c. FileBaseContext by dualbios
https://github.com/dualbios/FileBaseContext
FileBaseContext is a provider of Entity Framework Core 8 to store database information in files. 
[Current developement: forked from this, adjusted namespace, tweaks, published nuget and added examples] 
Core 8+ 





