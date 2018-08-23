using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.CSIA
{
    public class CSIA_Deltas
    {
        public string row_names { get; set; }
        public string Reference { get; set; }
        public string Compound { get; set; }
        public float Manufactured_d13C { get; set; }
        public float Manufactured_d2H { get; set; }
        public float Manufactured_d37Cl { get; set; }
        public string Biotic_or_Abiotic { get; set; }
        public string Conditions { get; set; }
        public string Biotic_Organism { get; set; }
        public string Abiotic_Mechanism { get; set; }
    }
}
