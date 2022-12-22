using Kanban.DataAccess.Context;
using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.DataAccess.Concrete
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(KanbanDbContext kanbanDbContext) : base(kanbanDbContext)
        {

        }
    }
}
