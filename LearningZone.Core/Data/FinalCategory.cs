using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalCategory
    {
        public FinalCategory()
        {
            FinalCourses = new HashSet<FinalCourse>();
        }

        public decimal Categoryid { get; set; }
        public string Categoryname { get; set; }
        public string Categoryimage { get; set; }

        public virtual ICollection<FinalCourse> FinalCourses { get; set; }
    }
}
