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
    class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> modelBuilder)
        {
            ///1-1 Teacher to Profile
            modelBuilder
                 .HasOne<TeacherProfile>(s => s.TeacherProfile)
                 .WithOne(s => s.Teacher)
                 .HasForeignKey<TeacherProfile>(s => s.TeacherId);
        }
       
    }
}
