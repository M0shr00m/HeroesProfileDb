using System;
using System.Collections.Generic;

namespace HeroesProfileDb.HeroesProfile
{
    public partial class SeasonGameVersions
    {
        public int Season { get; set; }
        public string GameVersion { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
