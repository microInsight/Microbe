using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ProjectInformationModels
{
    public class LIMS_DataType
    {
        public int dID { get; set; }
        public string datatype { get; set; }
        public string datatable { get; set; }
        public string columnheadings { get; set; }
        public string columnattributes { get; set; }
        public string columns { get; set; }
        public string description { get; set; }
        public string filename { get; set; }
        public string filetype { get; set; }
        public string fileextension { get; set; }
        public string includecolumnheader { get; set; }
        public string customtype { get; set; }
        public string active { get; set; }
        public string file { get; set; }
        public string searchcriteria { get; set; }
        public string searchoptions { get; set; }
    }
}
