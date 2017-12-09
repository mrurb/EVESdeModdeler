using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Ramassemblylinetypedetailpercategory
    {
        public int AssemblyLineTypeId { get; set; }
        public int CategoryId { get; set; }
        public double? TimeMultiplier { get; set; }
        public double? MaterialMultiplier { get; set; }
        public double? CostMultiplier { get; set; }
    }
}
