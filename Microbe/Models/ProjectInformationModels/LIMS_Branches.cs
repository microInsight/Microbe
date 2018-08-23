using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ProjectInformationModels
{
    public class LIMS_Branches
    {
        [Key]
        public int BranchID { get; set; }
        public int ClientID { get; set; }
        public string Abbr { get; set; }
        public string Branch_Name { get; set; }
        public string Branch_Display { get; set; }
        public string Branch_Type { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public string Address_3 { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string PostalCode { get; set; }
        public string CountryRegion { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Notes { get; set; }
        public Boolean active { get; set; }
        public Int32 EDD { get; set; }
        public string DateAdded { get; set; }
    }
}
