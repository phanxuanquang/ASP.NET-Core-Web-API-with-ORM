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
- Download from this
- Put into this folder

### Step 2: Setup connection with database
- Input information for the connection string
- Change the type of your SQL database
- Enable only your database type

### Step 3: Make it yours
- Create the models and controllers as your need
- Add your models into the database context
- Apply my filters if needed *(reccommended)*

## 4. Note
- My template is configured to click-and-run with SQL Server as an example
- I reccommend to use PostgreSQL for large scale projects with very large dataset, and to use SQLite for pet projects with simple a structured database schema and small dataset
