using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADUATE.ENTITYS.Entity
{
    public class CaseRecordEntity:BaseEntity
    {
        public string CaseDesp { get; set; }
        //秒
        public int AlreadySickTimes { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }

        public long TissueId { get; set; }
        public TissueEntity Tissue { get; set; }
        public long SickTypeId { get; set; }
        public SickTypeEntity SickType { get; set; }
        public long ExamplePeopleId { get; set; }
        public virtual  ExamplePeopleEntity ExamplePeople { get; set; }
    }
}
