using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Planetschematics
    {
        public int SchematicId { get; set; }
        public string SchematicName { get; set; }
        public int? CycleTime { get; set; }
    }
}
