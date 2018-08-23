using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ProjectInformationModels
{
    public class ClientProjects
    {
        public int id { get; set; }
        public string ClientName { get; set; }
        public string ProjectName { get; set; }
        public string Report { get; set; }
        public string OutputToScreen { get; set; }
        public string Genwiz { get; set; }
        public ICollection<ClientProjectReports> ClientProjectReports { get; set; }
    }
}
