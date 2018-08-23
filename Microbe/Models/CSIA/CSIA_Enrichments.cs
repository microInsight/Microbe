using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.CSIA
{
    public class CSIA_Enrichments
    {
        public string row_names { get; set; }
        public string Reference { get; set; }
        public string Compound { get; set; }
        public float Enrichment_Factor_13C_12C { get; set; }
        public float Enrichment_Factor_37Cl_35Cl { get; set; }
        public float Enrichment_Factor_2H_H { get; set; }
        public string Biotic_or_Abiotic { get; set; }
        public string Conditions { get; set; }
        public string Biotic_Organism { get; set; }
        public string Abiotic_Mechanism { get; set; }
    }
}
