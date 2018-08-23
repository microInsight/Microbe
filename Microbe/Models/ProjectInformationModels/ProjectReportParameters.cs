using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ReportModels
{
    public class ProjectReportParameters
    {
        public int ID { get; set; }
        public int ClientProjectReportsID { get; set; }
        public string SpecialLabel { get; set; }
        public decimal MinimumRange { get; set; }
        public decimal MaximumRange { get; set; }
        public int GraphsPerPage { get; set; }
        public string DataFilter { get; set; }
        public string SpecialNote { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifiedDate { get; set; }
    }
}
