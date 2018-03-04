using GRADUATE.ENTITYS.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADUATE.ENTITYS.Config
{
    public class TissuseConfig: EntityTypeConfiguration<TissuseEntity>
    {
        public TissuseConfig()
        {
            this.ToTable("T_TISSUSES");
            this.Property(it => it.Name).HasMaxLength(50).IsRequired();
            this.Property(it => it.Description).HasMaxLength(1024).IsRequired();
        }
    }
}
