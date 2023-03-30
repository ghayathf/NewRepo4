using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.DTO
{
    public class SectionTrainees
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
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

        public virtual FinalUser User { get; set; }
        public virtual FinalSection Section { get; set; }
        public virtual FinalTrainee Trainee { get; set; }
    }
}
