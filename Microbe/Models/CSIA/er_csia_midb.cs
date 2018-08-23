using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.CSIA
{
    public class er_csia_midb
    {
        public int ResultsID { get; set; }
        public string CompanyName { get; set; }
        public string Branch_Name { get; set; }
        public string StateOrProvince { get; set; }
        public string CountryRegion { get; set; }
        public string Contact_Name { get; set; }
        public string ProjectID { get; set; }
        public string ClientProjectName { get; set; }
        public string DateReceived { get; set; }
        public int LabSampleID { get; set; }
        public string ClientSampleID { get; set; }
        public string TestCode { get; set; }
        public string Component { get; set; }
        public string Media { get; set; }
        public string ContainerType { get; set; }
        public float Volume { get; set; }
        public float final_result { get; set; }
        public string units { get; set; }
        public int ordered { get; set; }
        public string DateLastChange { get; set; }
        public float detection_limit { get; set; }
        public float reporting_limit { get; set; }
        public string result_qualifier { get; set; }
    }
}
