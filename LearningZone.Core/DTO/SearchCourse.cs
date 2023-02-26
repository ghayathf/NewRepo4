using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.DTO
{
    public class SearchCourse
    {
        public string Coursename { get; set; }
        public string Coursedescription { get; set; }
        public string Courseimage { get; set; }
        public decimal? Courselevel { get; set; }
        public string Categoryname { get; set; }

    }
}
