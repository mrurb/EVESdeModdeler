using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Skinlicense
    {
        public int LicenseTypeId { get; set; }
        public int? Duration { get; set; }
        public int? SkinId { get; set; }
    }
}
