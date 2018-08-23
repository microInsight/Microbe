using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.ReportModels
{
    public class ReportSectionFigures
    {
        [Key]
        public int ReportSectionFigureID { get; set; }
        public int ReportSectionID { get; set; }
        public int SectionFigureOrder { get; set; }
        public String FigureType { get; set; }
        public String FigureDesc { get; set; }
        public String FigureSuffix { get; set; }

    }
}
