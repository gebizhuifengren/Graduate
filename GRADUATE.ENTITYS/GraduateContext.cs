using GRADUATE.ENTITYS.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADUATE.ENTITYS
{
    public class GraduateContext : DbContext
    {
        public GraduateContext() : base("name=sqlserver")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<DataEntity> Datas { get; set; }
        public DbSet<FrequencyEntity> Frequencys { get; set; }
        public DbSet<ParameterEntity> Parameters { get; set; }
        public DbSet<TissuseEntity> Tissuses { get; set; }
    }
}
