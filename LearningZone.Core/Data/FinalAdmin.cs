﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LearningZone.Core.Data
{
    public partial class FinalAdmin
    {
        public decimal Adminid { get; set; }
        public decimal? User_Id { get; set; }

        public virtual FinalUser User { get; set; }
    }
}
