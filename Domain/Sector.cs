using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sector
    {
        public Sector(string sectorName)
        {
            SectorName = sectorName;
        }
        public string SectorName { get; set; }
    }
}
