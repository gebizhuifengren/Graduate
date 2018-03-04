﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADUATE.ENTITYS.Entity
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
    }
}
