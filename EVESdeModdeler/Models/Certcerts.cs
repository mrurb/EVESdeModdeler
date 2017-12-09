using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Certcerts
    {
        public int CertId { get; set; }
        public string Description { get; set; }
        public int? GroupId { get; set; }
        public string Name { get; set; }
    }
}
