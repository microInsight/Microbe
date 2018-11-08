using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ReportModels
{
    public class ProjectReportSections
    {
        public int ProjectReportSectionsID { get; set; }
        public string ProjectID { get; set; }
        public string ReportType { get; set; }
        public int ReportSectionID { get; set; }
        public int ParentProjectReportSectionID { get; set; }
        public string PRS_Description { get; set; }
    }
}
