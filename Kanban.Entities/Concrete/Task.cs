using Kanban.Entities.Abstract;
using Kanban.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Entities.Concrete
{
    public class Task : ITask, IBaseEntity
    {
        [Key]
        public int TaskID { get ; set; }
        public string Description { get; set; }
        public string NameSurname { get; set; }
        public TaskStates TaskStates { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
        public User User { get; set; }
        public int UserID { get; set; }
    }
}
