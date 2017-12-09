using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Invgroups
    {
        public int GroupId { get; set; }
        public int? CategoryId { get; set; }
        public string GroupName { get; set; }
        public int? IconId { get; set; }
        public sbyte? UseBasePrice { get; set; }
        public sbyte? Anchored { get; set; }
        public sbyte? Anchorable { get; set; }
        public sbyte? FittableNonSingleton { get; set; }
        public sbyte? Published { get; set; }
    }
}
