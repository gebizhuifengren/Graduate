using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADUATE.ENTITYS.Entity
{
    public class DataEntity:BaseEntity
    {
        // TissuseId, ParameterTypeId, SampleNumber
        public double Value { get; set; }
        public string FrequencyId { get; set; }
        public int TissueStatus { get; set; }
        public string TissuseId { get; set; }
        public string ParameterTypeId { get; set; }
        public string SampleNumber { get; set; }
    }
}
