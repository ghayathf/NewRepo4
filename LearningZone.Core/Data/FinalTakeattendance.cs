using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalTakeattendance
    {
        public decimal Takeattendanceid { get; set; }
        public DateTime? Attendancedate { get; set; }
        public decimal? Tsid2 { get; set; }
        public decimal? Attendid { get; set; }
    }
}
