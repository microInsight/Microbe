using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Microbe.Models.ReportModels
{
    public class ProjectReportSections
    {
        [Key]
        public int ProjectReportSectionsID { get; set; }
        public string ProjectID { get; set; }
        public string ReportType { get; set; }
        public int ReportSectionID { get; set; }
        public int ParentProjectReportSectionID { get; set; }
        public string PRS_Description { get; set; }
    }
}
