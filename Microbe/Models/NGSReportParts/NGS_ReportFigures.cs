using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.NGSReportParts
{
    public class NGS_ReportFigures
    {
        [Key]
        public int NGS_ReportFiguresID { get; set; }
        public string ProjectID { get; set; }
        public string SampleID { get; set; }
        public string SampleName { get; set; }
        public string imageName { get; set; }
        public string FigureType { get; set; }
        public string imageLocation { get; set; }
        public string FigureTitle { get; set; }
        public string FigureText { get; set; }
        public string ImageWidth { get; set; }
        public string ImageHeight { get; set; }
    }
}
