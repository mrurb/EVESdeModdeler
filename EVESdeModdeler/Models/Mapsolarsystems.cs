using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Mapsolarsystems
    {
        public int? RegionId { get; set; }
        public int? ConstellationId { get; set; }
        public int SolarSystemId { get; set; }
        public string SolarSystemName { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Z { get; set; }
        public double? XMin { get; set; }
        public double? XMax { get; set; }
        public double? YMin { get; set; }
        public double? YMax { get; set; }
        public double? ZMin { get; set; }
        public double? ZMax { get; set; }
        public double? Luminosity { get; set; }
        public sbyte? Border { get; set; }
        public sbyte? Fringe { get; set; }
        public sbyte? Corridor { get; set; }
        public sbyte? Hub { get; set; }
        public sbyte? International { get; set; }
        public sbyte? Regional { get; set; }
        public sbyte? Constellation { get; set; }
        public double? Security { get; set; }
        public int? FactionId { get; set; }
        public double? Radius { get; set; }
        public int? SunTypeId { get; set; }
        public string SecurityClass { get; set; }
    }
}
