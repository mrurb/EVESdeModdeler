using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Ramactivities
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string IconNo { get; set; }
        public string Description { get; set; }
        public sbyte? Published { get; set; }
    }
}
