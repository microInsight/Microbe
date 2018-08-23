using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ReportModels
{
    public class EDD_QAData
    {
        public int EDD_QADataID { get; set; }
        public string EDD_FileName { get; set; }
        public string EDD_Sheet { get; set; }
        public string Component { get; set; }
        public string DateRecieved { get; set; }
        public string DateAnalyzed { get; set; }
        public int ArrivalTemp { get; set; }
        public int PositiveControl { get; set; }
        public int ExtractionBlank { get; set; }
        public int NegativeControl { get; set; }
    }
}
