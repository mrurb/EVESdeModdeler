using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class NPCCorpDivision
    {
        public int CorporationId { get; set; }
        public int DivisionId { get; set; }
        public int? Size { get; set; }
    }
}
