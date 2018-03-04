using GRADUATE.ENTITYS.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADUATE.ENTITYS.Config
{
    public class FrequencyConfig: EntityTypeConfiguration<FrequencyEntity>
    {
        public FrequencyConfig()
        {
            this.ToTable("T_FREQUENCYS");
            this.Property(it => it.Value).HasMaxLength(20).IsRequired();
        }
    }
}
