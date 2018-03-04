using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADUATE.ENTITYS.Entity
{
    public class ExamplePeopleEntity:BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public bool? Gender { get; set; }
    }
}
