using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalTask
    {
        public FinalTask()
        {
            FinalSolutions = new HashSet<FinalSolution>();
        }

        public decimal Taskid { get; set; }
        public string Tasktype { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Endtime { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Taskstatus { get; set; }
        public string Taskfile { get; set; }
        public string Tasknote { get; set; }

        public virtual ICollection<FinalSolution> FinalSolutions { get; set; }
    }
}
