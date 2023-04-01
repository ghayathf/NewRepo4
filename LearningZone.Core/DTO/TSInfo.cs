using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.DTO
{
    public class TSInfo
    {
        public decimal Sectionid { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Meetingurl { get; set; }
        public decimal? Sectioncapacity { get; set; }
        public decimal? Course_Id { get; set; }
        public decimal? Trainer_Id { get; set; }
        public decimal? Sectiondays { get; set; }
        public decimal Tsid { get; set; }
        public decimal? Totalmark { get; set; }
        public decimal? Totalattendance { get; set; }
        public decimal? T_S_Status { get; set; }
        public decimal? Trainee_Id { get; set; }
        public decimal? Section_id { get; set; }
        public decimal Courseid { get; set; }
        public string Coursename { get; set; }
        public string Coursedescription { get; set; }
        public string Courseimage { get; set; }
        public decimal? Courselevel { get; set; }
        public decimal? category_Id { get; set; }
        public decimal Taskid { get; set; }
        public string Tasktype { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Endtime { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Taskstatus { get; set; }
        public string Taskfile { get; set; }
        public string Tasknote { get; set; }
        public decimal? Sectionidd { get; set; }
        public decimal Solutionid { get; set; }
        public decimal? Solutionmark { get; set; }
        public string Solutionfile { get; set; }
        public string Submitionnote { get; set; }
        public decimal? T_S_Id { get; set; }
        public decimal? Task_Id { get; set; }
        public decimal Trainerid { get; set; }
        public decimal? Salary { get; set; }
        public string Trainerposition { get; set; }
        public string Qualification { get; set; }
        public decimal? User_Id { get; set; }
        public decimal Userid { get; set; }
        public string Username { get; set; }
        public string Userpassword { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal? RoleId { get; set; }
        public string Imagename { get; set; }
        public decimal Categoryid { get; set; }
        public string Categoryname { get; set; }
        public string Categoryimage { get; set; }
        public virtual FinalRole Role { get; set; }
        public virtual FinalUser User { get; set; }
        public virtual FinalTraineesection TS { get; set; }
        public virtual FinalTask Task { get; set; }
        public virtual FinalCategory Category { get; set; }
        public virtual FinalSection Section { get; set; }
        public virtual FinalTrainee Trainee { get; set; }
        public virtual FinalCourse Course { get; set; }
        public virtual FinalTrainer Trainer { get; set; }
    }
}
