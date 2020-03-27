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
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> modelBuilder)
        {
            ///1-1 Student to Profile
            modelBuilder
                .HasOne<StudentProfile>(s => s.StudentProfile)
                .WithOne(s => s.Student)
                .HasForeignKey<StudentProfile>(s => s.StudentId);
        }
    }
}
