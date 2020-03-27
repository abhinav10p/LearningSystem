using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Model.DB
{
    public class Progress: BaseModel
    {
       // public int Id { get; set; }

        public int Completion { get; set; }

        public int StudentId { get; set; }

        // public virtual Student Student { get; set; }


        public int TopicId { get; set; }

        //public virtual Topic Topic { get; set; }
    }
}
