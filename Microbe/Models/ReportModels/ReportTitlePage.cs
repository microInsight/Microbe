using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Microbe.Models.ReportModels
{
    public class ReportTitlePage
    {
        [Key]
        public int ReportTitlePageID { get; set; }
        public string ProjectID { get; set; }
        public string ReportType { get; set; }
        public string ReportTitle { get; set; }
        public string ReportDate { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string AddressLine5 { get; set; }
        public string ContactEmail { get; set; }
        public string ProjectText { get; set; }
        public string ReportComments { get; set; }
    }
}
