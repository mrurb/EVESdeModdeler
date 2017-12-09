using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Ramassemblylinestations
    {
        public int StationId { get; set; }
        public int AssemblyLineTypeId { get; set; }
        public int? Quantity { get; set; }
        public int? StationTypeId { get; set; }
        public int? OwnerId { get; set; }
        public int? SolarSystemId { get; set; }
        public int? RegionId { get; set; }
    }
}
