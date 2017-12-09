using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Planetschematicstypemap
    {
        public int SchematicId { get; set; }
        public int TypeId { get; set; }
        public int? Quantity { get; set; }
        public sbyte? IsInput { get; set; }
    }
}
