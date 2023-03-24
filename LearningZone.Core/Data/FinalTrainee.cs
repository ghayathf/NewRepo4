using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalTrainee
    {
        public FinalTrainee()
        {
            FinalTraineesections = new HashSet<FinalTraineesection>();
        }

        public decimal Traineeid { get; set; }
        public string Address { get; set; }
        public string Major { get; set; }
        public string University { get; set; }
        public string Traineefield { get; set; }
        public decimal? Registerstatus { get; set; }
        public decimal? User_Id { get; set; }

        public virtual FinalUser User { get; set; }
        public virtual ICollection<FinalTraineesection> FinalTraineesections { get; set; }
    }
}
