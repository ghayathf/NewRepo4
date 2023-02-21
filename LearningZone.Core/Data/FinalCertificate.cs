using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalCertificate
    {
        public decimal Certificateid { get; set; }
        public decimal? Certificatetype { get; set; }
        public decimal? TSId { get; set; }

        public virtual FinalTraineesection TS { get; set; }
    }
}
