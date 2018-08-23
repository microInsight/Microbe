using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ReportModels
{
    public class NGS_ViewModel
    {
        public List<NGS_Report> Items { get; set; }
    }

    public class NGS_Report
    {
        [Key]
        public string ProjectID { get; set; }
        public string htmlLine { get; set; }
    }
}
