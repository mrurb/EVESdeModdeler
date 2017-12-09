using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Invmarketgroups
    {
        public int MarketGroupId { get; set; }
        public int? ParentGroupId { get; set; }
        public string MarketGroupName { get; set; }
        public string Description { get; set; }
        public int? IconId { get; set; }
        public sbyte? HasTypes { get; set; }
    }
}
