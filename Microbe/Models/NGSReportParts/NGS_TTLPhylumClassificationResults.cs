using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.NGSReportParts
{
    public class NGS_TTLPhylumClassificationResults
    { 
        [Key]
        public int NGS_TTLPhylumClassificationResultsID { get; set; }
        public string ProjectID { get; set; }
        public string sampleName { get; set; }
        public int PhylumRank { get; set; }
        public string Phylum { get; set; }
        public int numHits { get; set; }
        public string fmtHits { get; set; }
        public string hitPercent { get; set; }
        public string tableNum { get; set; }
        public string tableTitle { get; set; }
        public string tableTitle2 { get; set; }
    }
}
