using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Dgmtypeeffects
    {
        public int TypeId { get; set; }
        public int EffectId { get; set; }
        public sbyte? IsDefault { get; set; }
    }
}
