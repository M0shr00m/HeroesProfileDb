﻿using System;
using System.Collections.Generic;

namespace HeroesProfileDb.HeroesProfile
{
    public partial class SeasonDates
    {
        public uint Id { get; set; }
        public uint Year { get; set; }
        public double Season { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
