using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalRole
    {
        public FinalRole()
        {
            FinalUsers = new HashSet<FinalUser>();
        }

        public decimal Roleid { get; set; }
        public string Rolename { get; set; }

        public virtual ICollection<FinalUser> FinalUsers { get; set; }
    }
}
