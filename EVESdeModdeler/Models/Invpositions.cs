using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Invpositions
    {
        public int ItemId { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float? Yaw { get; set; }
        public float? Pitch { get; set; }
        public float? Roll { get; set; }
    }
}
