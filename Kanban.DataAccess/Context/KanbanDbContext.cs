using Kanban.DataAccess.Mapping;
using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Kanban.Entities.Concrete.Task;

namespace Kanban.DataAccess.Context
{
    public class KanbanDbContext : DbContext
    {
        

        public KanbanDbContext() : base("Server=DESKTOP-ORUQO20;Database=NRM1_Kanban;Trusted_Connection=True;")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new TaskMapping());
        }
    }
}
