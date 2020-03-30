using LearningSystem.Model.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Model.DBConfig
{
    public class CourseCategoryConfig : IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> modelBuilder)
        {
            ///1-1 Student to Profile
            modelBuilder
                  .ToTable("CourseCategory")
                  .HasKey(k => new { k.CourseId, k.CategoryId });


            modelBuilder
                 .HasOne<Course>(c => c.Course)
                 .WithMany(c => c.CourseCategories)
                 .HasForeignKey(c => c.CourseId);


            modelBuilder
               .HasOne<Category>(c => c.Category)
               .WithMany(c => c.CourseCategories)
               .HasForeignKey(c => c.CategoryId);
        }
    }
}
