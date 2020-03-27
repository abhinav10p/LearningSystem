using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Model.DB
{
    public class CourseCategory
    {
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }


        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
