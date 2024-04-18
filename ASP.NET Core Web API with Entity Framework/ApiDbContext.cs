using ASP.NET_Core_Web_API_with_Entity_Framework.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Web_API_with_Entity_Framework
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        // Each time you create a new model, you should declare a context for it here. 
        // The name of the context must be the same as your new created model.
        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Reflect your new created model to an existing table in the database
            // You must ensure that all attributes of your model are the same as all columns of the table
            // The "ToTable" method is to declare the table that your model reflects
            // The "HasKey" method is to declare the primary key mirroring from you model to the primary key of the table
            builder.Entity<Person>().ToTable("Person").HasKey(model => model.Id);

            base.OnModelCreating(builder);
        }
    }
}
