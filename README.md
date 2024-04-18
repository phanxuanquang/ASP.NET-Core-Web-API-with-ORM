![image](https://i.imgur.com/PcgT383.png)

## 1. This template is suitable for the users
- Use C# programming language with .NET 8 for backend development
- Use SQL databases including SQL Server, PosgreSQL, and SQLite
- Want to apply ORM technique using Entity Framework for API development
- Do not want to configure too much to make the backend server run properly

## 2. Things that have been configured already
- The standard format of connection string to connect with SQL databases
- Database connection checking when starting the server
- CORS bypassed in localhost server
- The settings for HTTPS protocol, HTTP protocol, and IIS server
- XML documentation for the APIs on Swagger UI
- The filter to restruct the API response to avoid exception from the client side
- The filter to customize the message of common HTTP status codes
- Newtonsoft.Json NuGet package installed
- Examples for the standard SQL table schema creation, the standard model definition, and the way to declare the model as in the DbContext

## 3. Usage
### Step 1: Download and install
- Download the template [**HERE**](https://github.com/phanxuanquang/ASP.NET-Core-Web-API-with-ORM/releases/download/1.0.0/ASP.NET.Core.Web.API.with.Entity.Framework.zip) (do not extract the package after downloading)
- Find the below folder and put the template into it
```console
...\Document\Visual Studio 2022\Templates\ProjectTemplates
```
![image](https://i.imgur.com/9ufsemT.png)
*I use Visual Studio 2022, so my folder name is "Visual Studio 2022"*.

### Step 2: Setup connection with database
*In this step, I will take SQL server as the example*.
- Input information for the connection string. You only need to input the information for the database that you want to use.
![image](https://i.imgur.com/zRIQ0rE.png)
- Input the type of your SQL database. Change **SqlServer** to the name of the database you want to use (SqlServer, Sqlite, or Npgsql) 
![image](https://i.imgur.com/ooobHmy.png)
- Install the NuGet package coresponding to your database type
![image](https://i.imgur.com/uF5w5z7.png)
- Enable only your database type by removing the Comment mark
![image](https://i.imgur.com/RUDU39s.png)

### Step 3: Make it yours
*In this step, I will take "Person" model/table as the example*.
- Create the models and controllers as your need
![image](https://i.imgur.com/xXN8WxL.png)
- Register your models in the database context
![image](https://i.imgur.com/Krbaurp.png)
- Apply one of my filters to your controller classes if needed *(reccommended)*
![image](https://i.imgur.com/xON8Uny.png)

## 4. Note
- My template is configured to click-and-run with SQL Server as an example
- I reccommend to use PostgreSQL for large scale projects with very large dataset, and to use SQLite for pet projects with simple a structured database schema and small dataset
