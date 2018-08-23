using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Microbe.Models.ReportSections
{
    public class ReportSections
    {
        [Key]
        public int ReportSectionID { get; set; }
        public int ReportDefinitionID { get; set; }
        public int SectionOrder { get; set; }
        public string SectionTitle { get; set; }
        public string SectionDesc { get; set; }
        public string ModifiedBy { get; set; }
        public string createDate { get; set; }
        public string modifiedDate { get; set; }
    }
}
