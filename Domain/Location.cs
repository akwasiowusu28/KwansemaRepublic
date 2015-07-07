using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Location
    {
        public Location(string locationName)
        {
            SectorName = locationName;
        }
        public string SectorName { get; set; }
    }
}
