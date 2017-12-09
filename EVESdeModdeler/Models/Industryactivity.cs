using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Industryactivity
    {
        public int TypeId { get; set; }
        public int ActivityId { get; set; }
        public int? Time { get; set; }
    }
}
