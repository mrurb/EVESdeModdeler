using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Dgmeffects
    {
        public int EffectId { get; set; }
        public string EffectName { get; set; }
        public int? EffectCategory { get; set; }
        public int? PreExpression { get; set; }
        public int? PostExpression { get; set; }
        public string Description { get; set; }
        public string Guid { get; set; }
        public int? IconId { get; set; }
        public sbyte? IsOffensive { get; set; }
        public sbyte? IsAssistance { get; set; }
        public int? DurationAttributeId { get; set; }
        public int? TrackingSpeedAttributeId { get; set; }
        public int? DischargeAttributeId { get; set; }
        public int? RangeAttributeId { get; set; }
        public int? FalloffAttributeId { get; set; }
        public sbyte? DisallowAutoRepeat { get; set; }
        public sbyte? Published { get; set; }
        public string DisplayName { get; set; }
        public sbyte? IsWarpSafe { get; set; }
        public sbyte? RangeChance { get; set; }
        public sbyte? ElectronicChance { get; set; }
        public sbyte? PropulsionChance { get; set; }
        public int? Distribution { get; set; }
        public string SfxName { get; set; }
        public int? NpcUsageChanceAttributeId { get; set; }
        public int? NpcActivationChanceAttributeId { get; set; }
        public int? FittingUsageChanceAttributeId { get; set; }
        public string ModifierInfo { get; set; }
    }
}
