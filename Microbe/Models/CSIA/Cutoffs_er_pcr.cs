using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.CSIA
{
    public class Cutoffs_er_pcr
    {
        public string Media { get; set; }
        public string Target { get; set; }
        public int MinDataCutoff { get; set; }
        public int MaxDataCutoff { get; set; }
        public decimal Minimum_Reported_Percentile_Value { get; set; }
        public int Maximum_Reported_Percentile_Value { get; set; }
        public int Minimum_Reporting_Percentage { get; set; }
        public int Maximum_Reporting_Percentage { get; set; }
    }
}
