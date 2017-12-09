using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Chrattributes
    {
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string Description { get; set; }
        public int? IconId { get; set; }
        public string ShortDescription { get; set; }
        public string Notes { get; set; }
    }
}
