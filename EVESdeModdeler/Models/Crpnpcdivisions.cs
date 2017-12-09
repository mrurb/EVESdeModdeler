using EVESdeModdeler;
using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    [EVETable("crpNPCDivisions")]
    public partial class NPCCorpDivision
    {
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string Description { get; set; }
        public string LeaderType { get; set; }
    }
}
