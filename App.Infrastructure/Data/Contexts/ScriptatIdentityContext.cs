using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using App.Infrastructure;

namespace App.Infrastructure
{
    public class ScriptatIdentityContext : IdentityDbContext<ApplicationUser>
    {
        public ScriptatIdentityContext()
        {

        }
        public ScriptatIdentityContext(DbContextOptions<ScriptatIdentityContext> options)
          : base((DbContextOptions)options)
        {

        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder )
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("IdentityConnection"));

            // string _IdentityConnectionString = "Server=.;Database=ScriptatDBNN;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
            //optionsBuilder.UseSqlServer(Connection);
        }
        protected override void OnModelCreating(ModelBuilder builder) => base.OnModelCreating(builder);
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.HasDefaultSchema("Identity");
        //    builder.Entity<IdentityUser>(entity =>
        //    {
        //        entity.ToTable(name: "User");
        //    });
        //    builder.Entity<IdentityRole>(entity =>
        //    {
        //        entity.ToTable(name: "Role");
        //    });
        //    builder.Entity<IdentityUserRole<string>>(entity =>
        //    {
        //        entity.ToTable("UserRoles");
        //    });
        //    builder.Entity<IdentityUserClaim<string>>(entity =>
        //    {
        //        entity.ToTable("UserClaims");
        //    });
        //    builder.Entity<IdentityUserLogin<string>>(entity =>
        //    {
        //        entity.ToTable("UserLogins");
        //    });
        //    builder.Entity<IdentityRoleClaim<string>>(entity =>
        //    {
        //        entity.ToTable("RoleClaims");
        //    });
        //    builder.Entity<IdentityUserToken<string>>(entity =>
        //    {
        //        entity.ToTable("UserTokens");
        //    });
        //}
    }
}
