using ASP.NET_Core_Web_API_with_Entity_Framework.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Web_API_with_Entity_Framework
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person").HasKey(m => m.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
