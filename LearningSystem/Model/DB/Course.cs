using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Model.DB
{
    public class Course: BaseModel
    {
        //public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public float TotalHours { get; set; }

        public int Lectures { get; set; }

        //public DateTime LastUpdated { get; set; }

        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Topic> Topics { get; set; }

        public virtual ICollection<CourseCategory> CourseCategories { get; set; }

    }
}


/*public DateTime CreatedDate { get; set; }
public DateTime UpdatedDate { get; set; }*/
