using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.DTO
{
    public class TaskSols
    {
        public decimal Solutionid { get; set; }
        public decimal? Solutionmark { get; set; }
        public string Solutionfile { get; set; }
        public string Submitionnote { get; set; }
        public decimal? T_S_Id { get; set; }
        public decimal? Task_Id { get; set; }
        public decimal Tsid { get; set; }
        public decimal? Totalmark { get; set; }
        public decimal? Totalattendance { get; set; }
        public decimal? T_S_Status { get; set; }
        public decimal? Trainee_Id { get; set; }
        public decimal? Section_id { get; set; }
        public decimal Traineeid { get; set; }
        public string Address { get; set; }
        public string Major { get; set; }
        public string University { get; set; }
        public string Traineefield { get; set; }
        public decimal? Registerstatus { get; set; }
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
        public decimal Taskid { get; set; }
        public string Tasktype { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Endtime { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Taskstatus { get; set; }
        public string Taskfile { get; set; }
        public string Tasknote { get; set; }
        public decimal? Sectionidd { get; set; }

        public virtual FinalSection SectioniddNavigation { get; set; }
        public virtual FinalRole Role { get; set; }
        public virtual FinalUser User { get; set; }
        public virtual FinalSection Section { get; set; }
        public virtual FinalTrainee Trainee { get; set; }
        public virtual FinalTraineesection TS { get; set; }
        public virtual FinalTask Task { get; set; }
    }
}
