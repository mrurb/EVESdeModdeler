using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Invtypereactions
    {
        public int ReactionTypeId { get; set; }
        public sbyte Input { get; set; }
        public int TypeId { get; set; }
        public int? Quantity { get; set; }
    }
}
