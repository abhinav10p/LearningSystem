using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Model.API
{
    public class FullProgress : BaseModel
    {
        public string Name { get; set; }

        public string Course { get; set; }
        
        public string Topic { get; set; }
        
        public string Completion { get; set; }
        
        public int StudentId { get; set; }
        
        public int CourseId { get; set; }
        
        public int TopicId { get; set; }

    }
}
