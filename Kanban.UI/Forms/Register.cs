using Kanban.DataAccess.Concrete;
using Kanban.DataAccess.Context;
using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban.UI.Froms
{
    public partial class Register : Form
    {
        private readonly KanbanDbContext db;
        private readonly UserRepository _userRepository;
        public Register()
        {
            db = new KanbanDbContext();
            _userRepository = new UserRepository(db);
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(!cbKvk.Checked)
            {
                MessageBox.Show("Please accept the terms and conditions.\r\n");
                return;
            }
            if (tbPassword.Text != tbRepeatPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            try
            {
                User newUser = new User()
                {
                    Username= tbUsername.Text,
                    Password= tbPassword.Text,    
                };
                if (tbPassword.Text==tbRepeatPassword.Text && cbKvk.Checked)
                {
                    _userRepository.Add(newUser);
                    Login login= new Login();
                    login.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
