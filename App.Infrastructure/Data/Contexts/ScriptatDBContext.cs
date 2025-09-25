using App.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace App.Infrastructure
{
    public class ScriptatDBContext : IdentityDbContext<ApplicationUser>
    {
        public ScriptatDBContext()
        {
        }
        public ScriptatDBContext(DbContextOptions<ScriptatDBContext> options)
          : base((DbContextOptions)options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            //string _EntityConnectionString = "Server=.;Database=ScriptatDBNN;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
            //optionsBuilder.UseSqlServer(_EntityConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<ScriptType> ScriptType { get; set; }

        public DbSet<ProjectType> ProjectType { get; set; }

        public DbSet<Project> Project { get; set; }

        public DbSet<ProjectPart> ProjectPart { get; set; }

        public DbSet<ProjectPartParagraph> ProjectPartParagraph { get; set; }

        public DbSet<ComponentType> ComponentType { get; set; }

        public DbSet<ComponentTypeLink> ComponentTypeLink { get; set; }

        public DbSet<ProjectElement> ProjectElement { get; set; }

        public DbSet<ProjectElementLink> ProjectElementLink { get; set; }

        public DbSet<ProjectElementImage> ProjectElementImage { get; set; }

        public DbSet<Scene> Scene { get; set; }

        public DbSet<SceneParagraph> SceneParagraph { get; set; }

        public DbSet<SceneParagraphLink> SceneParagraphLink { get; set; }

        public DbSet<SceneParagraphType> SceneParagraphType { get; set; }
    }
}
