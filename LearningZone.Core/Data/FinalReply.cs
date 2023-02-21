using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalReply
    {
        public decimal Replyid { get; set; }
        public string Replymessage { get; set; }
        public DateTime? Datepublished { get; set; }
        public decimal? UserId { get; set; }
        public decimal? CommentId { get; set; }

        public virtual FinalComment Comment { get; set; }
        public virtual FinalUser User { get; set; }
    }
}
