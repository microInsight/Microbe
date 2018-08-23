using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ProjectInformationModels
{
    public class LIMS_ProjectClient
    {
        [Key]
        public int ProjectClientID { get; set; }
        public string ProjectID { get; set; }
        public int BranchID { get; set; }
        public Byte sort { get; set; }
        public string Branch_Address1 { get; set; }
        public string Branch_Address2 { get; set; }
        public string Branch_Address3 { get; set; }
        public string Branch_City { get; set; }
        public string Branch_StateOrProvince { get; set; }
        public string Branch_PostalCode { get; set; }
        public string Branch_CountryRegion { get; set; }
        public string Branch_Phone { get; set; }
        public string Branch_Fax { get; set; }
        public string Branch_Notes { get; set; }
        public string Contact_Name { get; set; }
        public string Contact_Title { get; set; }
        public string Contact_Dept { get; set; }
        public string Contact_Phone { get; set; }
        public string Contact_PhoneExt { get; set; }
        public string Contact_Fax { get; set; }
        public string Contact_Email { get; set; }
        public string Contact_Method { get; set; }
        public string Contact_Notes { get; set; }
        public Boolean active { get; set; }
        public string LastChangeBy { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeType { get; set; }
        public Int64 ClientIndex { get; set; }
    }
}
