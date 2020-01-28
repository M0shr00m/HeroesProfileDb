using System;
using System.Collections.Generic;

namespace HeroesProfileDb.HeroesProfile
{
    public partial class LeagueBreakdowns
    {
        public int TypeRoleHero { get; set; }
        public sbyte GameType { get; set; }
        public sbyte LeagueTier { get; set; }
        public double? MinMmr { get; set; }
    }
}
