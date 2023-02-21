using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalUser
    {
        public FinalUser()
        {
            FinalAdmins = new HashSet<FinalAdmin>();
            FinalComments = new HashSet<FinalComment>();
            FinalReplies = new HashSet<FinalReply>();
            FinalTestimonials = new HashSet<FinalTestimonial>();
            FinalTrainees = new HashSet<FinalTrainee>();
            FinalTrainers = new HashSet<FinalTrainer>();
        }

        public decimal Userid { get; set; }
        public string Username { get; set; }
        public string Userpassword { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal? RoleId { get; set; }

        public virtual FinalRole Role { get; set; }
        public virtual ICollection<FinalAdmin> FinalAdmins { get; set; }
        public virtual ICollection<FinalComment> FinalComments { get; set; }
        public virtual ICollection<FinalReply> FinalReplies { get; set; }
        public virtual ICollection<FinalTestimonial> FinalTestimonials { get; set; }
        public virtual ICollection<FinalTrainee> FinalTrainees { get; set; }
        public virtual ICollection<FinalTrainer> FinalTrainers { get; set; }
    }
}
