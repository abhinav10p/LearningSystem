﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Model.DB
{
    public class Category: BaseModel
    {
       // public int Id { get; set; }

        [MaxLength(80)]
        public string Name { get; set; }

        public virtual ICollection<CourseCategory> CourseCategories { get; set; }
    }
}
