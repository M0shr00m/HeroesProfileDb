using System;
using System.Collections.Generic;

namespace HeroesProfileDb.HeroesProfile
{
    public partial class ReplayBans
    {
        public int BanId { get; set; }
        public int ReplayId { get; set; }
        public byte Team { get; set; }
        public uint Hero { get; set; }
    }
}
