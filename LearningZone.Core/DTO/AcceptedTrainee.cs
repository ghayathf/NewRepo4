﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LearningZone.Core.DTO
{
    public class AcceptedTrainee
    {
        public decimal Userid { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal Traineeid { get; set; }
        public string Address { get; set; }
        public string Major { get; set; }
        public string University { get; set; }
        public string Traineefield { get; set; }
        public decimal? Registerstatus { get; set; }
    }
}
