using EVESdeModdeler;
using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    [EVETable("agtAgents")]
    public partial class Agent
    {
        [EVEProperty("agentID")]
        public int AgentId { get; set; }

        [EVEProperty("divisionID")]
        public virtual NPCDivision Division { get; set; }

        [EVEProperty("corporationID")]
        public NPCCorporation CorporationId { get; set; }
        public int? LocationId { get; set; }
        public int? Level { get; set; }
        public int? Quality { get; set; }
        public int? AgentTypeId { get; set; }
        public sbyte? IsLocator { get; set; }
    }
}
