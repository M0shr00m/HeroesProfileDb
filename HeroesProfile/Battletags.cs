using System;
using System.Collections.Generic;

namespace HeroesProfileDb.HeroesProfile
{
    public partial class Battletags
    {
        public uint PlayerId { get; set; }
        public int BlizzId { get; set; }
        public string Battletag { get; set; }
        public sbyte Region { get; set; }
        public int? AccountLevel { get; set; }
        public sbyte? Patreon { get; set; }
        public sbyte? OptOut { get; set; }
        public DateTime LatestGame { get; set; }
    }
}
