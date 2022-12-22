using Kanban.Entities.Concrete;
using Kanban.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Entities.Abstract
{
    public interface ITask
    {
        int TaskID { get; set; }
        string Description { get; set; }
        string NameSurname { get; set; }
        TaskStates TaskStates { get; set; }
        User User { get; set; }
        int UserID { get; set; }
    }
}
