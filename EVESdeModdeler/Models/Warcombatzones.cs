using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Warcombatzones
    {
        public int CombatZoneId { get; set; }
        public string CombatZoneName { get; set; }
        public int? FactionId { get; set; }
        public int? CenterSystemId { get; set; }
        public string Description { get; set; }
    }
}
