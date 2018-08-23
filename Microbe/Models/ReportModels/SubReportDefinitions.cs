using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ReportModels
{
    public class SubReportDefinitions
    {
        public int id { get; set; }
        public int ReportDefinitionsID { get; set; }
        public string ReportType { get; set; }
        public string DefinitionDesc { get; set; }
        public string ReportFunction { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifiedDate { get; set; }
    }
}
