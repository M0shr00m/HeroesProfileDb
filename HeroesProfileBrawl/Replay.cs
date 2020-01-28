﻿using System;
using System.Collections.Generic;

namespace HeroesProfileDb.HeroesProfileBrawl
{
    public partial class Replay
    {
        public int ReplayId { get; set; }
        public DateTime GameDate { get; set; }
        public short GameLength { get; set; }
        public sbyte GameMap { get; set; }
        public string GameVersion { get; set; }
        public sbyte Region { get; set; }
        public DateTime DateAdded { get; set; }
        public sbyte GlobalsRan { get; set; }
    }
}
