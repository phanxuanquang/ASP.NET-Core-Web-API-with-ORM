using ASP.NET_Core_Web_API_with_Entity_Framework;
using ASP.NET_Core_Web_API_with_Entity_Framework.Filters;
using ASP.NET_Core_Web_API_with_Entity_Framework.Middlewares;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


// Take connection string from the 'appsettings.json' file.
//builder.Services.AddDbContext<ApiDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Npgsql"))); // Install the 'Npgsql' NuGet package first
//builder.Services.AddDbContext<ApiDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("Sqlite"))); // Install the 'Microsoft.EntityFrameworkCore.Sqlite' NuGet package first
builder.Services.AddDbContext<ApiDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"))); // Install the 'Microsoft.EntityFrameworkCore.SqlServer' NuGet package first

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddNewtonsoftJson();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicies", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Backend APIs Documentation",
        Version = "v1.0.0",
        Description = "Current CORS (Cross-Origin Resource Sharing) configuration remove all default security restrictions for the request when connecting to the backend server via these APIs. Therefore, please make sure that the CORS policies in the 'Program.cs' file matched to the production usages, otherwise, they may cause some security problems."
    });

    c.UseAllOfToExtendReferenceSchemas();
    c.MapType<ProblemDetails>(() => new OpenApiSchema { Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = "ProblemDetails" } });
    c.UseAllOfToExtendReferenceSchemas();
    c.MapType<ValidationProblemDetails>(() => new OpenApiSchema { Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = "ValidationProblemDetails" } });
    c.UseAllOfToExtendReferenceSchemas();
    c.MapType<SerializableError>(() => new OpenApiSchema { Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = "SerializableError" } });

    string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

app.UseDatabaseConnectionChecker();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Backend APIs");

    });
}

app.UseCors("CorsPolicies");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();