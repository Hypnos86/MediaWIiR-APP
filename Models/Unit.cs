using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWIiR_APP.Models
{
    public class Unit
    {
        public string UnitType { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string County { get; set; }

        internal static MigraDoc.DocumentObjectModel.Unit FromPoint(int v)
        {
            throw new NotImplementedException();
        }
    }
}
