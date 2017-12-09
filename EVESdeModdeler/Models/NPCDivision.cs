using EVESdeModdeler;
using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    [EVETable("crpNPCDivisions")]
    public partial class NPCDivision
    {
        [EVEProperty("divisionID")]
        public int DivisionId { get; set; }

        [EVEProperty("divisionName")]
        public string DivisionName { get; set; }

        [EVEProperty("description")]
        public string Description { get; set; }

        [EVEProperty("leaderType")]
        public string LeaderType { get; set; }
    }
}
