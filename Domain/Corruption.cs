using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Corruption
    {
        public CorruptionType CorruptionType { get; set; }
        public Sector Sector { get; set; }
        public string Description { get; set; }
        public string VideoLink { get; set; }
        public string AudioLink { get; set; }
    }
}
