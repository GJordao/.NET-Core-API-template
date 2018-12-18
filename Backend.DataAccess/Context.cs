using Backend.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Backend.DataAccess
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433;Initial Catalog=EFSampleDB;User ID=sa;Password=********");
        }

        public DbSet<User> Users { get; set; }
    }
}

