using System;
using System.Collections.Generic;

namespace HeroesProfileDb.HeroesProfile
{
    public partial class ReplaysNotProcessed
    {
        public int ReplayId { get; set; }
        public string ParsedId { get; set; }
        public int? Region { get; set; }
        public string GameType { get; set; }
        public string GameLength { get; set; }
        public DateTime? GameDate { get; set; }
        public string GameMap { get; set; }
        public string GameVersion { get; set; }
        public string Size { get; set; }
        public DateTime? DateParsed { get; set; }
        public int? CountParsed { get; set; }
        public string Url { get; set; }
        public string Processed { get; set; }
        public string FailureStatus { get; set; }
    }
}
