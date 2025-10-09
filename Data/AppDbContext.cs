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
        public virtual DbSet<County> Counties { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("users");
            builder.Entity<SignUp>().ToTable("signUps");
            builder.Entity<County>().ToTable("counties");

            builder.Entity<County>().HasData(
               new County { Id = 1, Name = "Mombasa" },
               new County { Id = 2, Name = "Kwale" },
               new County { Id = 3, Name = "Kilifi" },
               new County { Id = 4, Name = "Tana River" },
               new County { Id = 5, Name = "Lamu" },
               new County { Id = 6, Name = "Taita-Taveta" },
               new County { Id = 7, Name = "Garissa" },
               new County { Id = 8, Name = "Wajir" },
               new County { Id = 9, Name = "Mandera" },
               new County { Id = 10, Name = "Marsabit" },
               new County { Id = 11, Name = "Isiolo" },
               new County { Id = 12, Name = "Meru" },
               new County { Id = 13, Name = "Tharaka-Nithi" },
               new County { Id = 14, Name = "Embu" },
               new County { Id = 15, Name = "Kitui" },
               new County { Id = 16, Name = "Machakos" },
               new County { Id = 17, Name = "Makueni" },
               new County { Id = 18, Name = "Nyandarua" },
               new County { Id = 19, Name = "Nyeri" },
               new County { Id = 20, Name = "Kirinyaga" },
               new County { Id = 21, Name = "Murang'a" },
               new County { Id = 22, Name = "Kiambu" },
               new County { Id = 23, Name = "Turkana" },
               new County { Id = 24, Name = "West Pokot" },
               new County { Id = 25, Name = "Samburu" },
               new County { Id = 26, Name = "Trans-Nzoia" },
               new County { Id = 27, Name = "Uasin Gishu" },
               new County { Id = 28, Name = "Elgeyo-Marakwet" },
               new County { Id = 29, Name = "Nandi" },
               new County { Id = 30, Name = "Baringo" },
               new County { Id = 31, Name = "Laikipia" },
               new County { Id = 32, Name = "Nakuru" },
               new County { Id = 33, Name = "Narok" },
               new County { Id = 34, Name = "Kajiado" },
               new County { Id = 35, Name = "Kericho" },
               new County { Id = 36, Name = "Bomet" },
               new County { Id = 37, Name = "Kakamega" },
               new County { Id = 38, Name = "Vihiga" },
               new County { Id = 39, Name = "Bungoma" },
               new County { Id = 40, Name = "Busia" },
               new County { Id = 41, Name = "Siaya" },
               new County { Id = 42, Name = "Kisumu" },
               new County { Id = 43, Name = "Homa Bay" },
               new County { Id = 44, Name = "Migori" },
               new County { Id = 45, Name = "Kisii" },
               new County { Id = 46, Name = "Nyamira" },
               new County { Id = 47, Name = "Nairobi" }
           );
        }
    }
}
