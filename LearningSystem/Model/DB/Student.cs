using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Model.DB
{
    public class Student: BaseModel
    {
       // public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public virtual StudentProfile StudentProfile { get; set; }

        public virtual ICollection<Progress> Progresses { get; set; }

    }
}
