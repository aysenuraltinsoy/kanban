﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kanban.Entities.Enums;

namespace Kanban.Entities.Abstract
{
    public interface IBaseEntity
    {
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        DateTime? DeletedDate { get; set; }
        string CreatedBy { get; set; }
        string DeletedBy { get; set; }
        string ModifiedBy { get; set; }
        Status Status { get; set; }
        
    }
}
