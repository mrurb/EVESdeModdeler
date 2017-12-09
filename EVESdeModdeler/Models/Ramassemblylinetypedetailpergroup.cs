using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Ramassemblylinetypedetailpergroup
    {
        public int AssemblyLineTypeId { get; set; }
        public int GroupId { get; set; }
        public double? TimeMultiplier { get; set; }
        public double? MaterialMultiplier { get; set; }
        public double? CostMultiplier { get; set; }
    }
}
