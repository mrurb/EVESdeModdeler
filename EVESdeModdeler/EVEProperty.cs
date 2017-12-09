using System;
using System.Collections.Generic;
using System.Text;

namespace EVESdeModdeler
{
    class EVEProperty : Attribute
    {
        private string propertyName;

        public EVEProperty(string propertyName)
        {
            this.propertyName = propertyName;
        }
    }
}
