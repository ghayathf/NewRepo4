using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.DTO
{
    public class Testimonial
    {
        public decimal Testimonialid { get; set; }
        public string Testimonialmessage { get; set; }
        public decimal? Testimonialstatus { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal User_Id { get; set; }
        public string Imagename { get; set; }
    }
}
