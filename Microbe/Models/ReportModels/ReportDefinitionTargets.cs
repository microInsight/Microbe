using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ReportModels
{
    public class ReportDefinitionTargets
    {
        int id { get; set; }
        int ValidTargetID { get; set; }
        int ReportDefinitionsID { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifiedDate { get; set; }

    }
}
