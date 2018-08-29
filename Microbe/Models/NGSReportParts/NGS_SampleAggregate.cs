using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Microbe.Models.NGSReportParts
{
    public class NGS_SampleAggregate
    {
        [Key]
        public int NGS_SampleAggregateID { get; set; }
        public string ProjectID { get; set; }
        public string SampleID { get; set; }
        public int SampleNumber { get; set; }
        public string SampleName { get; set; }
        public int ClientSampleNum { get; set; }
        public string MI_Identitfier { get; set; }
        public string MainFilePath { get; set; }
        public string SubFilePath { get; set; }
        public string CSVName { get; set; }
        public string FileRoot { get; set; }
        public int KingdomCnt { get; set; }
        public int PhylumCnt { get; set; }
        public int ClassCnt { get; set; }
        public int OrderCnt { get; set; }
        public int FamilyCnt { get; set; }
        public int GenusCnt { get; set; }
        public int SpeciesCnt { get; set; }
        public int ttlReads { get; set; }
        public int ClusterCnt { get; set; }
        public int ClusterCntPF { get; set; }
        public float ClassificationRate { get; set; }                          
        public float Shannon { get; set; }                                     
        public float Simpson { get; set; }                                     
        public int ChaolPredicted { get; set; }
        public int TtlGenera { get; set; }
        public float TtlEubacteria { get; set; }
        public string ClientSampleID { get; set; }
    }
}
