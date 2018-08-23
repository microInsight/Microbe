using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ProjectInformationModels
{
    public class ProjectReportSampleSelection
    {
        public int id { get; set; }
        public int ClientProjectReportsID { get; set; }
        public string isSelected { get; set; }
        public string PointColor { get; set; }
        public int trendLine { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifiedDate { get; set; }

    }
}
