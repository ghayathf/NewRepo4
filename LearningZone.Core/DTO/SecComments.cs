using LearningZone.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.DTO
{
    public class SecComments
    {
       
        public decimal Commentid { get; set; }
        public string Commentmessage { get; set; }
        public DateTime? Datepublished { get; set; }
        public decimal? User_Id { get; set; }
        public decimal? Section_Id { get; set; }
        public decimal Userid { get; set; }
        public string Username { get; set; }
        public string Userpassword { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal? RoleId { get; set; }
        public string Imagename { get; set; }

        public virtual FinalRole Role { get; set; }
        public virtual FinalUser User { get; set; }
        public virtual FinalSection Section { get; set; }

    }
}
