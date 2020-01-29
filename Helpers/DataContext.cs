using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ReceiptifyServer.Entities;

namespace ReceiptifyServer.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlite("Data Source=data.db");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Example> Example { get; set; }
        public DbSet<Companies> Companies { get; set; }
    }
}