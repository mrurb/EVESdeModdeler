using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Invcategories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? IconId { get; set; }
        public sbyte? Published { get; set; }
    }
}
