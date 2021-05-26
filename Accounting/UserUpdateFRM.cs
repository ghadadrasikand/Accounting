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
    public partial class UserUpdateFRM : Form
    {
        private readonly IUserRepository repository;
        private static UserUpdateFRM FormInstance = null;
        private int _Id = 0;
        public UserUpdateFRM(int id)
        {
            InitializeComponent();
            repository = new UserRepository();
            _Id = id;
        }
        public static UserUpdateFRM CreateInstance(int id)
        {
            if (FormInstance == null)
            {
                FormInstance = new UserUpdateFRM(id);
            }
            return FormInstance;
        }
        private void UserUpdateFRM_Load(object sender, EventArgs e)
        {
            User user = repository.GetById(_Id);
            txtUName.Text = user.Name;
            txtUserName.Text = user.UserName;
            txtPassword.Text = user.Password;
            txtType.Text = user.Type;
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Id = _Id,
                Name = txtUName.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                Type = txtType.Text
            };
            int result=repository.Update(user);
            if (result > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("عملیات ویرایش ناموفق");
            }
        }

        private void UserUpdateFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInstance = null;
            UserListFRM userListFRM = (UserListFRM)Application.OpenForms["UserListFRM"];
            userListFRM.LoadGrideView();
            
        }
    }
}
