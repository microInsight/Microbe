using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ProjectInformationModels
{
    public class ClientProjectReportTargets
    {
        public int id { get; set; }
        public int ValidTargetID { get; set; }
        public int ClientProjectReportsID { get; set; }
        public int TargetAction { get; set; }
        public string ModifiedBy { get; set; }
        public string createDate { get; set; }
        public string modifiedDate { get; set; }
    }
}
