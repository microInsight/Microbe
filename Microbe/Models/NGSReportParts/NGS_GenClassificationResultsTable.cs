using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.NGSReportParts
{
    public class NGS_GenClassificationResultsTable
    {
        [Key]
        public int GenClassificationResultsTableID { get; set; }
        public int tableRow { get; set; }
        public int tablePage { get; set; }
        public string ProjectName { get; set; }
        public string TableLabel { get; set; }
        public string TableNum { get; set; }
        public string TableTitle { get; set; }
        public int numHits { get; set; }
        public string SampleName { get; set; }
        public string Genus { get; set; }
        public string fmtHits { get; set; }
        public string percentHits { get; set; }
        public string GenusDescription { get; set; }
    }
}
