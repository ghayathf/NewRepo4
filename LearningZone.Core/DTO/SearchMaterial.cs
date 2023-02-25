using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.DTO
{
   public class SearchMaterial
    {
        public string MaterialName  { set; get; }
        public DateTime? DateFrom { set; get; }
        public DateTime? DateTo { set; get; }
    }
}
