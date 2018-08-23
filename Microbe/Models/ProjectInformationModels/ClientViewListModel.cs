using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ProjectInformationModels
{
    public class ClientViewListModel
    {
        public List<ClientProjects> clients;
        public SelectList ClientNames;
        public string ClientList { get; set; }
    }
}
