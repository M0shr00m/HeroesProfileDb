﻿using System;
using System.Collections.Generic;

namespace HeroesProfileDb.HeroesProfile
{
    public partial class GlobalHeroStatsBans
    {
        public string GameVersion { get; set; }
        public sbyte GameType { get; set; }
        public sbyte LeagueTier { get; set; }
        public sbyte HeroLeagueTier { get; set; }
        public sbyte RoleLeagueTier { get; set; }
        public sbyte GameMap { get; set; }
        public int HeroLevel { get; set; }
        public int Region { get; set; }
        public sbyte Hero { get; set; }
        public uint? Bans { get; set; }
    }
}
