using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kanban.Entities.Concrete;
using Task = Kanban.Entities.Concrete.Task;

namespace Kanban.Entities.Abstract
{
    public interface IUser
    {
        int UserID { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        List<Task> Tasks { get; set; }
    }
}
