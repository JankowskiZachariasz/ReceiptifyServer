using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ReceiptifyServer.Helpers
{
    public class SqliteDataContext : DataContext
    {
        public SqliteDataContext(IConfiguration configuration) : base(configuration) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite("Data Source=data.db");
        }
    }
}