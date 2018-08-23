using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ProjectInformationModels
{
    public class LIMS_ClientContact
    {
        [Key]
        public int ContactID { get; set; }
        public int BranchID { get; set; }
        public string Contact_Type { get; set; }
        public string Contact_Name { get; set; }
        public string Contact_Title { get; set; }
        public string Contact_Phone { get; set; }
        public string Contact_PhoneExt { get; set; }
        public string Contact_Fax { get; set; }
        public string Contact_Email { get; set; }
        public string Contact_Dept { get; set; }
        public string Contact_Method { get; set; }
        public string Contact_Notes { get; set; }
        public string active { get; set; }
        public string Contact_FirstName { get; set; }
        public string Contact_LastName { get; set; }
        public string Contact_MiddleName { get; set; }
    }
}
