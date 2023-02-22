using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalTrainer
    {
        public FinalTrainer()
        {
            FinalSections = new HashSet<FinalSection>();
        }

        public decimal Trainerid { get; set; }
        public decimal? Salary { get; set; }
        public string Trainerposition { get; set; }
        public string Qualification { get; set; }
        public decimal? User_Id { get; set; }

        public virtual FinalUser User { get; set; }
        public virtual ICollection<FinalSection> FinalSections { get; set; }
    }
}
