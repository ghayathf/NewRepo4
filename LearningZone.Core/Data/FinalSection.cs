﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalSection
    {
        public FinalSection()
        {
            FinalMaterials = new HashSet<FinalMaterial>();
            FinalTasks = new HashSet<FinalTask>();
            FinalTraineesections = new HashSet<FinalTraineesection>();
        }

        public decimal Sectionid { get; set; }
        public string Starttime { get; set; }
        public string Endtime { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Meetingurl { get; set; }
        public decimal? Sectioncapacity { get; set; }
        public decimal? Course_Id { get; set; }
        public decimal? Trainer_Id { get; set; }
        public decimal? Sectiondays { get; set; }

        public virtual FinalCourse Course { get; set; }
        public virtual FinalTrainer Trainer { get; set; }
        public virtual ICollection<FinalMaterial> FinalMaterials { get; set; }
        public virtual ICollection<FinalTask> FinalTasks { get; set; }
        public virtual ICollection<FinalTraineesection> FinalTraineesections { get; set; }
    }
}
