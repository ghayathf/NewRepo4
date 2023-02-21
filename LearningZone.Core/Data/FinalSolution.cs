using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalSolution
    {
        public decimal Solutionid { get; set; }
        public decimal? Solutionmark { get; set; }
        public string Solutionfile { get; set; }
        public string Submitionnote { get; set; }
        public decimal? TSId { get; set; }
        public decimal? TaskId { get; set; }

        public virtual FinalTraineesection TS { get; set; }
        public virtual FinalTask Task { get; set; }
    }
}
