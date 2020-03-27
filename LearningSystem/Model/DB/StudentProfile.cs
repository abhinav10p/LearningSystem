using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Model.DB
{
    public class StudentProfile: BaseModel
    {
        //public int Id { get; set; }


        [MaxLength(80)]
        [Required]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Contact { get; set; }

        [MaxLength(80)]
        [Required]
        public string Password { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

    }
}
