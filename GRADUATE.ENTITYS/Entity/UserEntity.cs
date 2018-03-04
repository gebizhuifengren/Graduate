using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADUATE.ENTITYS.Entity
{
    public class UserEntity:BaseEntity
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
