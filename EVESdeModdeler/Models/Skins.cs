using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Skins
    {
        public int SkinId { get; set; }
        public string InternalName { get; set; }
        public int? SkinMaterialId { get; set; }
    }
}
