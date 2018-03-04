using GRADUATE.ENTITYS.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADUATE.ENTITYS.Config
{
    public class ParameterTypeConfig: EntityTypeConfiguration<ParameterEntity>
    {
        public ParameterTypeConfig()
        {
            this.ToTable("T_PARAMETERTYPES");
            this.Property(it => it.Name).HasMaxLength(50).IsRequired();
            this.Property(it => it.Description).HasMaxLength(1024).IsRequired();
        }
    }
}
