using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Microbe.Models.NGSReportParts
{
    public class NGS_Statistics
    {
        [Key]
        public int NGS_StatisticsID { get; set; }
        public string SourceFile { get; set; }
        public string ProjectID { get; set; }
        public string SampleName { get; set; }
        public string Kingdom { get; set; }
        public string Phylum { get; set; }
        public string Class { get; set; }
        public string Order { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }
        public int num_hits { get; set; }

    }
}
