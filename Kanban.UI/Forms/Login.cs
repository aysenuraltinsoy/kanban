using Kanban.DataAccess.Context;
using Kanban.DataAccess.Concrete;
using Kanban.Entities.Concrete;
using Kanban.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kanban.UI.Froms
{
    public partial class Login : Form
    {
        private readonly KanbanDbContext db;
        private readonly UserRepository _userRepository;
        public Login()
        {
            db=new KanbanDbContext();
            _userRepository = new UserRepository(db);
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userNameControl = db.Users.Where(x => x.Username == tbUsername.Text.Trim()).FirstOrDefault();
            LoginCheck(userNameControl);
            if (LoginCheck(userNameControl) ==true)
            {
                MessageBox.Show("Login Succesful");
                Main main= new Main();
                main.Show();
                Hide();
            }
        }

        public static User userNameControl;

        public bool LoginCheck(User userNameControl)
        {
           
            if (userNameControl == null)
            {
                MessageBox.Show("User Not Found !!");
                return false;
            }
            else
            {
                var passwordControl = db.Users.Where(x => x.Password == userNameControl.Password).FirstOrDefault();
                if (passwordControl==null)
                {
                    MessageBox.Show("User Not Found !!");
                    return false;
                    
                }
                else
                {
                    return true;
                }
                
            }
            
        }

        private void newAccount_DoubleClick(object sender, EventArgs e)
        {
            Register register= new Register();
            register.Show();
            Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
