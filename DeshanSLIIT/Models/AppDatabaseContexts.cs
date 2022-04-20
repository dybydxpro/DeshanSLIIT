using Microsoft.EntityFrameworkCore;

namespace DeshanSLIIT.Models
{
    public class AppDatabaseContexts : DbContext
    {
        public AppDatabaseContexts(DbContextOptions<AppDatabaseContexts> options) : base(options)
        {

        }

        public DbSet<Asset> Assets { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Auth> Auths { get; set; } 
        public DbSet<Test> Tests { get; set; }
    }
}
