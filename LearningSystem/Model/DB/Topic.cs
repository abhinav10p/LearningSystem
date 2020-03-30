using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Model.DB
{
    public class Topic: BaseModel
    {

        [MaxLength(50)]
        public string Name { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<Progress> Progresses { get; set; }
    }
}
