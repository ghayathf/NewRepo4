using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalTestimonial
    {
        public decimal Testimonialid { get; set; }
        public string Testimonialmessage { get; set; }
        public decimal? Testimonialstatus { get; set; }
        public decimal? UserId { get; set; }

        public virtual FinalUser User { get; set; }
    }
}
