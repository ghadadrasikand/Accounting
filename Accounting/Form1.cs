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
    public partial class LoginFRM : Form
    {
        private readonly IUserRepository repository;
        private User user;
        public LoginFRM()
        {
            InitializeComponent();
            repository = new UserRepository();
            user = new User();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string username = txtusername.Text;
            string password = txtpassword.Text;
            user=repository.Login(username,password);
            if (user != null)
            {
                string name = user.Name;
                MainFRM FRM = new MainFRM(name);
                FRM.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.");
            }
        }

        private void LoginFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string name = "";
           
            UserInsertFRM FRM =UserInsertFRM.CreateInstance(name);
            FRM.Show();
           
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
