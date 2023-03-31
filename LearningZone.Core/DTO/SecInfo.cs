using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.DTO
{
    public class SecInfo
    {
        public decimal Courseid { get; set; }
        public string Coursename { get; set; }
        public string Coursedescription { get; set; }
        public string Courseimage { get; set; }
        public decimal? Courselevel { get; set; }
        public decimal? category_Id { get; set; }
        public decimal Materialid { get; set; }
        public DateTime? Dateuploaded { get; set; }
        public string Materialname { get; set; }
        public decimal? Section_Id { get; set; }
        public string Filepath { get; set; }
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
        public virtual FinalSection Section { get; set; }
        public virtual FinalCategory Category { get; set; }
    }
}
