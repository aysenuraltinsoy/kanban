using Kanban.DataAccess.Concrete;
using Kanban.DataAccess.Context;
using Kanban.Entities.Concrete;
using Kanban.Entities.Enums;
using Kanban.UI.Froms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = Kanban.Entities.Concrete.Task;

namespace Kanban.UI.Forms
{
    public partial class TaskAdd : Form
    {
        private readonly KanbanDbContext db;
        private readonly UserRepository _userRepository;
        private readonly TaskRepository _taskRepository;
        public TaskAdd()
        {
            db = new KanbanDbContext();
            _userRepository = new UserRepository(db);
            _taskRepository = new TaskRepository(db);
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Main main=new Main();
            main.Show();
            this.Hide();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            int userID = Login.userNameControl.UserID;
            Task newTask = new Task()
            {
                NameSurname=tbWhoDo.Text,
                Description=rtbDescp.Text,
                TaskStates= (Entities.Enums.TaskStates)cbState.SelectedValue,
                UserID= userID,
                
            };
            _taskRepository.Add(newTask);
        }

        private void TaskAdd_Load(object sender, EventArgs e)
        {
            cbState.DataSource=Enum.GetValues(typeof(TaskStates));
        }
    }
}
