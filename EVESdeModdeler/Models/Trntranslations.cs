using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Trntranslations
    {
        public int TcId { get; set; }
        public int KeyId { get; set; }
        public string LanguageId { get; set; }
        public string Text { get; set; }
    }
}
