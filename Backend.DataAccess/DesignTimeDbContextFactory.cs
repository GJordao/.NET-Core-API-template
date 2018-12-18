using System.Data.SqlClient;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Backend.DataAccess
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<Context> builder = new DbContextOptionsBuilder<Context>();
            string connectionString = "Server=localhost,1433;Initial Catalog=EFSampleDB;User ID=sa;Password=********";
            builder.UseSqlServer(connectionString);
            return new Context(builder.Options);
        }
    }
}