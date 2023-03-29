using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalComment
    {
        public FinalComment()
        {
            FinalReplies = new HashSet<FinalReply>();
        }

        public decimal Commentid { get; set; }
        public string Commentmessage { get; set; }
        public DateTime? Datepublished { get; set; }
        public decimal? User_Id { get; set; }
        public decimal? Section_Id { get; set; }

        public virtual FinalUser User { get; set; }
        public virtual FinalSection Section{ get; set; }
        public virtual ICollection<FinalReply> FinalReplies { get; set; }
    }
}
