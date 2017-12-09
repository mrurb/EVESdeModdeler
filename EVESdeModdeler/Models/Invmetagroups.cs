using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Invmetagroups
    {
        public int MetaGroupId { get; set; }
        public string MetaGroupName { get; set; }
        public string Description { get; set; }
        public int? IconId { get; set; }
    }
}
