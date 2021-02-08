## Commands on .Net CLI 
### Project Organisation
We would leverage [.Net SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net50) to create applications using VSCode. [.Net SDK](https://docs.microsoft.com/en-us/dotnet/core/sdk) offers you robust [.Net CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/) (to see the history use this link) to create, build, test and run the projects. To create a basic project structure for making an Heros app using [clean architecture](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures), follow the steps mentioned below:
* Create a folder for solution file
    * `mkdir HerosApp`
* Navigate to solution folder
    * `cd ./HerosApp/`
* Create a solution
    * `dotnet new sln`
* Create a new console app
    * `dotnet new console -lang C# -o HerosUI`
* Add the reference to the solution
    * `dotnet sln HerosApp.sln add HerosUI/HerosUI.csproj`
* Repeat steps for the rest of the projects
    * `dotnet new classLib -lang C# -o HerosLib`
    * `dotnet sln HerosApp.sln add HerosLi/HerosLib.csproj`
    * `dotnet new classLib -lang C# -o HerosDB`
    * `dotnet sln HerosApp.sln add HerosDB/HerosDB.csproj`
    * `dotnet new xUnit -o HerosTest`
    * `dotnet sln HerosApp.sln add HerosTest/HerosTest.csproj`

# Middleware 
## ADO.NET
- ActiveX Direct Object
- We use this framework as a middleware to connect Application Logic program to backend.
- Two architectures in ADO.NET
    - Connected Architecture
        - Reading from data happens when client app and backend are live 
        - reading happends in forward only directions, reading one record at a time
        - which means no back-tracking of records
    - Disconnected Architecture
        - fire and forget the query
        - once connection is made the backend would send results to client which are stored locally
        - The local data source is called *DataSet*

- to connect your application to DB there are 3 basic steps to be followed
    - create a connection
    - Fire the query
    - get the results

## Design Patterns used with EFCore
### Repository Design Pattern
- container where the data acess logic is stored
- separate logic retrieves and manipulates data (in the DB) and maps it (entites of DB to entities of BL) to logic that acts on the BL models
- You want your BL to be agnostic of whatever data storage system you might have
- Implementation:
    - Data Layer/DB Layer/Data Access/Persistence 
    - Repository Class (could also include a Mapper class)

### Facade Design Pattern
- Creating a facade to hide the complex subsystems (if they exist) that implementation might depend on, so that its easier to access the necessary methods you would need
- Implementation:
    - Creating a interface that encapsulates these subsystems (if they're interfaces as well)
        - ex: IMapper Interface (Combines the SuperHero, SuperVillain, SuperPower mapper in a easily referenced interface, that contains all the necessary methods)

## EF Core
### Packages
Install the listed packages in your Data Layer project:
- ```dotnet add package Microsoft.EntityFrameworkCore.Design```
    - This should also be installed in your startup project
- ```dotnet add package Microsoft.EntityFrameworkCore.Tools```
- ```dotnet add package Microsoft.EntityFrameworkCore.SQLServer```
- ```dotnet add package Microsoft.Extensions.Configuration.Json```
  
### DB First Steps
1. Have the following:
    - a Data Layer
    - The necessary packages installed in DL project
2. Run the long scaffold code in the DL project:
    - with Fluent API 
      - `dotnet ef dbcontext scaffold "connnection-string" Microsoft.EntityFrameworkCore.SQLServer --startup-project <relative path to project file> --force -o Entities`
    - with Data Annotations 
      - `dotnet ef dbcontext scaffold "connnection-string" Microsoft.EntityFrameworkCore.SQLServer --startup-project <relative path to project file> --force -o Entities`
3. Edit the DBContext:
    - Change the name if its weird
    - Edit the onconfiguring method to safely refer to the connection string using appsettings.json
4. Any major change to table structure:
    - If you add a new table, delete a table: go to step 2
    - If you've altered columns in an existing table: edit the necessary entity to reflect those changes

Other things you'll need with DBFirst:
- A Mapper to map your DB entities to BL entities

### Code First Steps
1. Have the following:
    - Data Layer
    - The necessary packages installed in DL project
    - Appsettings.json in both your startup project and root folder of the solution
2. Implement a DbContext
    - Override the `OnConfiguring` method to point to the connection string stored in your appsettings.json
    - Override the `OnModelCreating` method to manually map some relationships EF Core complains about
3. Run the migration code in the DL project
    - `dotnet ef migrations add NameOfMigration -c DbContext --startup-project <relative path to project file>`
4. Update your DB in the DL project
    - `dotnet ef database update --startup-project <relative path to project file>`
5. Any changes to your models/entities go to step 3



    