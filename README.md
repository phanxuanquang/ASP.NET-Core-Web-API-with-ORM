![image](https://i.imgur.com/PcgT383.png)
This project template tailored for backend development using C# .NET. Whether you're a newcomer to backend development or an experienced developer looking for a streamlined setup, this template provides a solid foundation to kickstart your project.

Now that you have a solid foundation, feel free to explore and extend the template to suit your project requirements. Whether you're building a small-scale application or a large-scale enterprise solution, this template provides a robust starting point for your backend development journey.

## 1. Target Audience:
- **Newcomers to Backend Development:** Get up and running quickly with a project that's ready to run out of the box.
- **C# .NET Developers:** Utilize the latest features of .NET 8 for efficient backend development.
- **Database Enthusiasts:** Connect seamlessly to popular SQL databases like SQL Server, PostgreSQL, and SQLite.
- **API Development with ORM:** Implement Object-Relational Mapping (ORM) techniques effortlessly using Entity Framework.
- **Minimal Configuration:** Minimize setup time and focus on coding with pre-configured settings.

## 2. Pre-configured features
- Standardized connection strings for SQL databases ensure smooth integration.
- Automatic database connection checks before server initialization.
- CORS policies are pre-configured to prevent blocking when accessing APIs from different origins.
- Integrated Swagger UI with pre-configured XML documentation for clear API documentation and exploration.
- Filters in place to structure API responses and provide meaningful error messages, enhancing client-side handling.
- Newtonsoft.Json NuGet package is included for efficient JSON serialization and deserialization.
- Provision of examples for standard SQL table schema creation, model definition, and DbContext declaration.

## 3. Usage
### Step 1: Download and install
- Download the template [**HERE**](https://github.com/phanxuanquang/ASP.NET-Core-Web-API-with-ORM/releases/download/1.0.0/ASP.NET.Core.Web.API.with.Entity.Framework.zip) (do not extract the package after downloading)
- Place the template in the following folder. The folder name may vary depending on your Visual Studio version.
```console
...\Document\Visual Studio 2022\Templates\ProjectTemplates
```
![image](https://i.imgur.com/9ufsemT.png)

### Step 2: Setup connection with database
*In this step, I take SQL server as the example*.
- Input information for the connection string. You only need to input the information for the database that you want to use.
![image](https://i.imgur.com/zRIQ0rE.png)
- Input the type of your SQL database. Specify your SQL database type by modifying SqlServer to the desired database (SqlServer, Sqlite, or Npgsql). 
![image](https://i.imgur.com/ooobHmy.png)
- Install the NuGet package coresponding to your database type
![image](https://i.imgur.com/uF5w5z7.png)
- Enable only your database type by removing the Comment remark
![image](https://i.imgur.com/RUDU39s.png)

### Step 3: Make it yours
*In this step, I take "Person" model/table as the example*.
- Create the models and controllers as needed
![image](https://i.imgur.com/xXN8WxL.png)
- Register your models in the database context
![image](https://i.imgur.com/Krbaurp.png)
- Optionally apply the provided filters to your controller classes.
![image](https://i.imgur.com/xON8Uny.png)

## 4. Additional Notes:
- The template is pre-configured for SQL Server; consider PostgreSQL for large-scale projects with extensive datasets and SQLite for smaller projects with simpler database schemas.
- Tailor the template to your specific project requirements and database preferences.
