using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ProjectInformationModels
{
    public class LIMS_Documents
    {

        [Key]
        public int DocIndex { get; set; }
        public string DocumentName { get; set; }
        public string DocumentLocation { get; set; }
        public string DocumentDescription { get; set; }
        public string DocumentActive { get; set; }
    }
}
