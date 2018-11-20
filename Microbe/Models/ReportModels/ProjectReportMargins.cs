using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Microbe.Models.ReportModels
{
    public class ProjectReportMargins
    {
        [Key]
        public int ProjectReportMarginsID { get; set; }
        public string ProjectID { get; set; }
        public float MarginRight { get; set; }
        public float MarginLeft { get; set; }
        public float MarginTop { get; set; }
        public float MarginBottom { get; set; }
        public string FooterTxt { get; set; }
        public string FirstPageFooterTxt { get; set; }
        public string HeaderTxt { get; set; }
        public string FirstPageHeaderTxt { get; set; }
    }
}
           