﻿using System;
using System.Collections.Generic;

namespace EpsynServices.Models.EVEModels
{
    public partial class Trntranslationcolumns
    {
        public int? TcGroupId { get; set; }
        public int TcId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string MasterId { get; set; }
    }
}
