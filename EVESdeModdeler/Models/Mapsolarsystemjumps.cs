﻿using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Mapsolarsystemjumps
    {
        public int? FromRegionId { get; set; }
        public int? FromConstellationId { get; set; }
        public int FromSolarSystemId { get; set; }
        public int ToSolarSystemId { get; set; }
        public int? ToConstellationId { get; set; }
        public int? ToRegionId { get; set; }
    }
}
