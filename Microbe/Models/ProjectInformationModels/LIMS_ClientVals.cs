using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ProjectInformationModels
{
    public class LIMS_ClientVals
    {
        [Key]
        public int id { get; set; }
        public string concatvals { get; set; }
    }
}
