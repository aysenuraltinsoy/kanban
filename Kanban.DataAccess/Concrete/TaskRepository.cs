using Kanban.DataAccess.Context;
using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Kanban.Entities.Concrete.Task;

namespace Kanban.DataAccess.Concrete
{
    public class TaskRepository : BaseRepository<Task>
    {
        public TaskRepository(KanbanDbContext kanbanDbContext) : base(kanbanDbContext)
        {
        }
    }
}
