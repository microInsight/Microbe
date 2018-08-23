using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ReportModels
{
    public class ced_components
    {
        public int id { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public string ModifiedBy { get; set; }
        public string createDate { get; set; }
        public string modifiedDate { get; set; }
    }
}
