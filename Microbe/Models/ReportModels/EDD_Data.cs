using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Microbe.Models.ReportModels
{
    public class EDD_Data
    {
        [Key]
        public int EDD_DataID { get; set; }
        public string EDD_FileName { get; set; }
        public string EDD_Sheet { get; set; }
        public string Lab_Name { get; set; }
        public string Sample_Name { get; set; }
        public string Sample_Date { get; set; }
        public string Date_Received { get; set; }
        public string Sample_Matrix { get; set; }
        public string LIMS_Identifier { get; set; }
        public string Extraction_Date { get; set; }
        public string Analysis_Date { get; set; }
        public string Analysis_Method { get; set; }
        public string Parameter { get; set; }
        public float Result { get; set; }
        public string Result_Qualifier { get; set; }
        public string Units { get; set; }
        public float Detection_Limit { get; set; }
        public float Report_Limit { get; set; }
    }
}
