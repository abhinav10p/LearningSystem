using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Model.DB
{
    public class TeacherProfile: BaseModel
    {

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(80)]
        [Required]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Contact { get; set; }

        [MaxLength(80)]
        [Required]
        public string Password { get; set; }

        public virtual int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
