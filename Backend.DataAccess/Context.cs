using Backend.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Backend.DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
    }
}