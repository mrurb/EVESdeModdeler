using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Evegraphics
    {
        public int GraphicId { get; set; }
        public string SofFactionName { get; set; }
        public string GraphicFile { get; set; }
        public string SofHullName { get; set; }
        public string SofRaceName { get; set; }
        public string Description { get; set; }
    }
}
