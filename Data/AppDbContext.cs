using Microsoft.EntityFrameworkCore;
using NipeNikupe.Models;

namespace NipeNikupe.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<SignUp> SignUps { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("users");
            builder.Entity<SignUp>().ToTable("signUps");
        }
    }
}
