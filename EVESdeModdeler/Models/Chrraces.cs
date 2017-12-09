using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Chrraces
    {
        public int RaceId { get; set; }
        public string RaceName { get; set; }
        public string Description { get; set; }
        public int? IconId { get; set; }
        public string ShortDescription { get; set; }
    }
}
