using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ProjectInformationModels
{
    public class ClientProjectReports
    {
        public int id { get; set; }
        public int ClientProjectsID { get; set; }
        public int ReportParametersID { get; set; }
        public int ReportDefinitionsID { get; set; }
        public string datafile { get; set; }
    }
}
