using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ProjectInformationModels
{
    public class LIMS_Client
    {
       [Key]
       public int ClientID  { get; set; }
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Display(Name = "Notes")]
        public string ClientNotes { get; set; }
        [Display(Name = "Active?")]
        public Boolean active { get; set; }
        public Int64 primaryinvname { get; set; }
       public Int64 secondaryinvname { get; set; }
       public string DateAdded { get; set; }
    }
}
