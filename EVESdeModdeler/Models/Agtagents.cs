using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Agtagents
    {
        public int AgentId { get; set; }
        public int? DivisionId { get; set; }
        public int? CorporationId { get; set; }
        public int? LocationId { get; set; }
        public int? Level { get; set; }
        public int? Quality { get; set; }
        public int? AgentTypeId { get; set; }
        public sbyte? IsLocator { get; set; }
    }
}
