using Kanban.DataAccess.Concrete;
using Kanban.DataAccess.Context;
using Kanban.Entities.Concrete;
using Kanban.UI.Forms;
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

namespace Kanban.UI.Froms
{
    public partial class Main : Form
    {
        private readonly KanbanDbContext db;
        private readonly UserRepository _userRepository;
        private readonly TaskRepository _taskRepository;
        public Main()
        {
            db = new KanbanDbContext();
            _userRepository = new UserRepository(db);
            _taskRepository = new TaskRepository(db);
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            User userNameControl = Login.userNameControl;

            ListTasks(userNameControl);


            btnDoing.Enabled= false;
            btnDone.Enabled= false;
        }
        int selectedToDoID;
        int selectedDoingID;
        private void dgwToDo_SelectionChanged(object sender, EventArgs e)
        {
            selectedToDoID = Convert.ToInt32(dgwToDo.CurrentRow.Cells["TaskID"].Value);
            btnDoing.Enabled = true;
        }

        private void dgwDoing_SelectionChanged(object sender, EventArgs e)
        {
            selectedDoingID = Convert.ToInt32(dgwDoing.CurrentRow.Cells["TaskID"].Value);
            btnDoing.Enabled = false;
            btnDone.Enabled = true;
        }
        public static List<Task> taskList;
        private void btnDoing_Click(object sender, EventArgs e)
        {

            var doingTask = _taskRepository.GetById(selectedToDoID);
            doingTask.TaskStates= Entities.Enums.TaskStates.Doing;
            _taskRepository.Update(doingTask);
            ListTasks(Login.userNameControl);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TaskAdd taskadd=new TaskAdd();
            taskadd.Show();
            this.Hide();
        }

        private void ListTasks(User userNameControl)
        {
            dgwToDo.DataSource = db.Tasks.Where(x => (x.UserID == userNameControl.UserID) && (x.TaskStates == Entities.Enums.TaskStates.ToDo)).Select(x => new
            {
                x.TaskID,
                Who = x.NameSurname,
                x.Description,

            }).ToList();
            dgwDoing.DataSource = db.Tasks.Where(x => (x.UserID == userNameControl.UserID) && (x.TaskStates == Entities.Enums.TaskStates.Doing)).Select(x => new
            {
                x.TaskID,
                Who = x.NameSurname,
                x.Description,

            }).ToList();
            dgwDone.DataSource = db.Tasks.Where(x => (x.UserID == userNameControl.UserID) && (x.TaskStates == Entities.Enums.TaskStates.Done)).Select(x => new
            {
                x.TaskID,
                Who = x.NameSurname,
                x.Description,

            }).ToList();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            var doneTask = _taskRepository.GetById(selectedDoingID);
            doneTask.TaskStates = Entities.Enums.TaskStates.Done;
            _taskRepository.Update(doneTask);
            ListTasks(Login.userNameControl);
        }
    }
}
