using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Raminstallationtypecontents
    {
        public int InstallationTypeId { get; set; }
        public int AssemblyLineTypeId { get; set; }
        public int? Quantity { get; set; }
    }
}
