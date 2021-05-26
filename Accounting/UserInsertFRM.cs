using Accounting.IRepositories;
using Accounting.Models;
using Accounting.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class UserInsertFRM : Form
    {
        private readonly IUserRepository repository;
        private static UserInsertFRM FormInstance = null;
        string _name = "";
        public UserInsertFRM(string name)
        {
            InitializeComponent();
            repository = new UserRepository();
            _name = name;
        }

        public static UserInsertFRM CreateInstance(string name)
        {
            if (FormInstance == null)
            {
                FormInstance = new UserInsertFRM(name);
            }
            return FormInstance;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            User user = new User() {
                Name = txtUName.Text,
                UserName=txtUserName.Text,
                Password=txtPassword.Text,
                Type=txtType.Text
            };
            int result=repository.Insert(user);
            if (result > 0)
            {
                this.Close();
                if (_name == "")
                {
                    LoginFRM FRM = new LoginFRM();
                    FRM.Show();
                }
            }
            else
            {
                MessageBox.Show("کاربر ثبت نگردید");
            }
            
        }

        private void UserInsertFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInstance = null;
            if (_name != "")
            {
                UserListFRM userListFRM = (UserListFRM)Application.OpenForms["UserListFRM"];
                userListFRM.LoadGrideView();
            }
            else
            {
                LoginFRM FRM = new LoginFRM();
                FRM.Show();
            }
           
            
        }

        private void UserInsertFRM_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
