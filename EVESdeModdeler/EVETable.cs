using System;
using System.Collections.Generic;
using System.Text;

namespace EVESdeModdeler
{
    class EVETable : Attribute
    {
        private string tableName;

        public EVETable(string tableName)
        {
            this.tableName = tableName;
        }
    }
}
