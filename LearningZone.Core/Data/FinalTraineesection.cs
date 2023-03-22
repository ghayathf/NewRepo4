using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalTraineesection
    {
        public FinalTraineesection()
        {
            FinalCertificates = new HashSet<FinalCertificate>();
            FinalSolutions = new HashSet<FinalSolution>();
        }

        public decimal Tsid { get; set; }
        public decimal? Totalmark { get; set; }
        public decimal? Totalattendance { get; set; }
        public decimal? T_S_Status { get; set; }
        public decimal? Trainee_Id { get; set; }

        public decimal? Section_id { get; set; }

        public virtual FinalSection Section { get; set; }
        public virtual FinalTrainee Trainee { get; set; }
        public virtual ICollection<FinalCertificate> FinalCertificates { get; set; }
        public virtual ICollection<FinalSolution> FinalSolutions { get; set; }
    }
}
