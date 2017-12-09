using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Chrfactions
    {
        public int FactionId { get; set; }
        public string FactionName { get; set; }
        public string Description { get; set; }
        public int? RaceIds { get; set; }
        public int? SolarSystemId { get; set; }
        public int? CorporationId { get; set; }
        public float? SizeFactor { get; set; }
        public int? StationCount { get; set; }
        public int? StationSystemCount { get; set; }
        public int? MilitiaCorporationId { get; set; }
        public int? IconId { get; set; }
    }
}
