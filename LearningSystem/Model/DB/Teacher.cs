using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Model.DB
{
    public class Teacher: BaseModel
    {
       // public int Id { get; set; }

        [MaxLength(50)]
        public string Degree { get; set; }

        public virtual TeacherProfile TeacherProfile { get; set; }

    }
}
