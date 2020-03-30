using LearningSystem.Model.DBConfig;
using LearningSystem.Model.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace LearningSystem.Model
{
    public class ELContext : DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLoggerFactory(MyLoggerFactory)
                    .EnableSensitiveDataLogging()
                    .UseLazyLoadingProxies()
                    .UseSqlServer("server=.;database=N2Learning;user=sa;password=Test@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfig());

            modelBuilder.ApplyConfiguration(new TeacherConfig());
            
            modelBuilder.ApplyConfiguration(new CourseConfig());
            
            modelBuilder.ApplyConfiguration(new CourseCategoryConfig());
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudentProfile> StudentProfiles { get; set; }
        public DbSet<TeacherProfile> TeacherProfiles { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Progress> Progresses { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }


       /* public override int SaveChanges()
        {
            //-- Filter the entites, Added/Modified --//

            var entries = this.ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                    e.State == EntityState.Added ||
                    e.State == EntityState.Modified
                ));

            foreach (var entityEntry in entries)
            {
                (entityEntry.Entity as BaseEntity).UpdatedDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    (entityEntry.Entity as BaseEntity).CreatedDate = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }*/
    }
}
