using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalMaterial
    {
        public decimal Materialid { get; set; }
        public DateTime? Dateuploaded { get; set; }
        public string Materialname { get; set; }
        public decimal? Section_Id { get; set; }

        public virtual FinalSection Section { get; set; }
    }
}
