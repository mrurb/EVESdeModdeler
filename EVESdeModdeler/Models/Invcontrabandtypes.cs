using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Invcontrabandtypes
    {
        public int FactionId { get; set; }
        public int TypeId { get; set; }
        public double? StandingLoss { get; set; }
        public double? ConfiscateMinSec { get; set; }
        public double? FineByValue { get; set; }
        public double? AttackMinSec { get; set; }
    }
}
