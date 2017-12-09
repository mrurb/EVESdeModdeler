using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Translationtables
    {
        public string SourceTable { get; set; }
        public string DestinationTable { get; set; }
        public string TranslatedKey { get; set; }
        public int? TcGroupId { get; set; }
        public int? TcId { get; set; }
    }
}
