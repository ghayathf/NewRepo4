using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalCourse
    {
        public FinalCourse()
        {
            FinalSections = new HashSet<FinalSection>();
        }

        public decimal Courseid { get; set; }
        public string Coursename { get; set; }
        public string Coursedescription { get; set; }
        public string Courseimage { get; set; }
        public decimal? Courselevel { get; set; }
        public decimal? CategoryId { get; set; }

        public virtual FinalCategory Category { get; set; }
        public virtual ICollection<FinalSection> FinalSections { get; set; }
    }
}
