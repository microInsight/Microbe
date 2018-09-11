using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Microbe.Models.NGSReportParts
{
    public class NGS_SampleHits
    {
        [Key]
        public int NGS_SampleHits_ID { get; set; }
        public string SampleName { get; set; }
        public string Kingdom { get; set; }
        public string Phylum { get; set; }
        public string Class { get; set; }
        public string Order { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }
        public int NumHits { get; set; }
        public string ProjectID { get; set; }
    }
}
