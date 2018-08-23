using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ReportModels
{
    public class ReportDefinitions
    {
        [Key]
        public int ReportDefinitionID { get; set; }
        public string ReportType { get; set; }
        public string DefinitionDesc { get; set; }
        public string ReportFunction { get; set; }
        public ICollection<SubReportDefinitions> SubReportDefinitions { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifiedDate { get; set; }

    }
}
