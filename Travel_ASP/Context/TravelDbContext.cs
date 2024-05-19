namespace STM.DataAccess.Contexts
{
    using System;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;
    using STM.DataAccess.Configurations;
    using Travel_ASP.Models;

    public class TravelDbContext : IdentityDbContext<User, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public static readonly ILoggerFactory DbContextLoggerFactory = LoggerFactory.Create(builder => { builder.AddDebug(); });

        public TravelDbContext()
        {
        }

        public TravelDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                return;
            }

            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", true, true);

            var connectionString = builder.Build().GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);

            optionsBuilder.UseLoggerFactory(DbContextLoggerFactory);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BlogConfiguration());
            builder.ApplyConfiguration(new ConfigurationConfiguration());
            builder.ApplyConfiguration(new ContactConfiguration());
            builder.ApplyConfiguration(new ProvinceConfiguration());
            builder.ApplyConfiguration(new RoleClaimConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new TourConfiguration());
            builder.ApplyConfiguration(new UserClaimConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserLoginConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new UserTokenConfiguration());
            builder.ApplyConfiguration(new BookingConfiguration());
        }

        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
    }
}
