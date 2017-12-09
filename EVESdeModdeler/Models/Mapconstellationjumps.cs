using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Mapconstellationjumps
    {
        public int? FromRegionId { get; set; }
        public int FromConstellationId { get; set; }
        public int ToConstellationId { get; set; }
        public int? ToRegionId { get; set; }
    }
}
