using Microsoft.Data.SqlClient;

namespace ASP.NET_Core_Web_API_with_Entity_Framework.Middlewares
{
    public class DatabaseConnectionChecking
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<DatabaseConnectionChecking> _logger;
        private readonly IConfiguration _config;

        public DatabaseConnectionChecking(RequestDelegate next, ILogger<DatabaseConnectionChecking> logger, IConfiguration config)
        {
            _next = next;
            _logger = logger;
            _config = config;
        }

        public async Task Invoke(HttpContext context)
        {
            string connectionString = _config.GetConnectionString("SqlServer"); // Change "SqlServer" to the name of the database you want to check (SqlServer, Sqlite, or Npgsql) 

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                }

                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                var message = $"Cannot connect to the database. {ex.Message}";
                _logger.LogError(ex, message);
                await context.Response.WriteAsync(message);
            }
        }
    }

    public static class DatabaseConnectionMiddlewareExtensions
    {
        public static IApplicationBuilder UseDatabaseConnectionChecker(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<DatabaseConnectionChecking>();
        }
    }
}
