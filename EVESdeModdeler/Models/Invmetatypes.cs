using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Invmetatypes
    {
        public int TypeId { get; set; }
        public int? ParentTypeId { get; set; }
        public int? MetaGroupId { get; set; }
    }
}
