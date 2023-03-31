using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.DTO
{
    public class TrainerInfo
    {
        public decimal Userid { get; set; }
        public string Username { get; set; }
        public string Userpassword { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal? RoleId { get; set; }
        public string Imagename { get; set; }
        public decimal Trainerid { get; set; }
        public decimal? Salary { get; set; }
        public string Trainerposition { get; set; }
        public string Qualification { get; set; }
        public decimal? User_Id { get; set; }
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
        public decimal Courseid { get; set; }
        public string Coursename { get; set; }
        public string Coursedescription { get; set; }
        public string Courseimage { get; set; }
        public decimal? Courselevel { get; set; }
        public decimal? category_Id { get; set; }

        public virtual FinalCategory Category { get; set; }
        public virtual FinalCourse Course { get; set; }
        public virtual FinalTrainer Trainer { get; set; }
        public virtual FinalUser User { get; set; }
        public virtual FinalRole Role { get; set; }
    }
}
