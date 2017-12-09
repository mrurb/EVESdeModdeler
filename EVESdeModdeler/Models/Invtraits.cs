using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Invtraits
    {
        public int TraitId { get; set; }
        public int? TypeId { get; set; }
        public int? SkillId { get; set; }
        public float? Bonus { get; set; }
        public string BonusText { get; set; }
        public int? UnitId { get; set; }
    }
}
