using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Invflags
    {
        public int FlagId { get; set; }
        public string FlagName { get; set; }
        public string FlagText { get; set; }
        public int? OrderId { get; set; }
    }
}
