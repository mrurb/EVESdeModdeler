using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Dgmattributetypes
    {
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string Description { get; set; }
        public int? IconId { get; set; }
        public float? DefaultValue { get; set; }
        public sbyte? Published { get; set; }
        public string DisplayName { get; set; }
        public int? UnitId { get; set; }
        public sbyte? Stackable { get; set; }
        public sbyte? HighIsGood { get; set; }
        public int? CategoryId { get; set; }
    }
}
