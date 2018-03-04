using GRADUATE.ENTITYS.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADUATE.ENTITYS.Config
{
    public class DataConfig: EntityTypeConfiguration<DataEntity>
    {
        public DataConfig()
        {
            this.ToTable("T_DATAS");
            this.Property(it => it.FrequencyId).IsRequired();
            this.Property(it => it.TissuseId).IsRequired();
            this.Property(it => it.ParameterTypeId).IsRequired();
            this.Property(it => it.SampleNumber).HasMaxLength(10).IsRequired();
        }
    }
}
