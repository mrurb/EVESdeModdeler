using EVESdeModdeler;
using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    [EVETable("crpNPCCorporationDivisions")]
    public partial class NPCCorporationDivision
    {
        [EVEProperty("corporationID")]
        public int CorporationId { get; set; }

        [EVEProperty("divisionID")]
        public int DivisionId { get; set; }

        [EVEProperty("size")]
        public int Size { get; set; }
    }
}
