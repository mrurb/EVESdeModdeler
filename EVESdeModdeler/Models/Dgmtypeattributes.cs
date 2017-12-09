using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Dgmtypeattributes
    {
        public int TypeId { get; set; }
        public int AttributeId { get; set; }
        public int? ValueInt { get; set; }
        public float? ValueFloat { get; set; }
    }
}
