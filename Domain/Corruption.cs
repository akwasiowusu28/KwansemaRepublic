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
        public Location Location { get; set; }
        public string Description { get; set; }
        public string VideoPath { get; set; }
        public string AudioPath { get; set; }
        public string ImagePath { get; set; }
    }
}
