using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.EMFServerMessageFactory;
using CrystalDecisions.CrystalReports.Engine;

namespace Accounting
{
    public partial class MainFRM : Form
    {
        private string _name = "";
        public MainFRM(string name)
        {
            InitializeComponent();
            _name = name;
          
        }

        private void MenuUser_Click(object sender, EventArgs e)
        {
            UserListFRM FRM = UserListFRM.CreateInstance();
            FRM.Show();
        }

        private void AccountMenu_Click(object sender, EventArgs e)
        {
            AccountListFRM FRM = AccountListFRM.CreateInstance();
            FRM.Show();
        }

        private void MainFRM_Load(object sender, EventArgs e)
        {
            if (_name == "")
            {
                lblUser.Text = "";
            }
            lbllogin.Text = _name;
            //LoginFRM FRM = new LoginFRM();
            //FRM.Close();
        }

        private void DocumentMenu_Click(object sender, EventArgs e)
        {
            DocumentListFRM FRM =DocumentListFRM.CreateInstance();
            FRM.Show();
        }

        private void TarazMenu_Click(object sender, EventArgs e)
        {
            TarazListFRM FRM = TarazListFRM.CreateInstance();
            FRM.Show();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFRM FRM = new LoginFRM();
            FRM.Show();
        }

        private void GozareshMenu_Click(object sender, EventArgs e)
        {
            GozareshFRM gozareshFRM = new GozareshFRM();
            gozareshFRM.Show();
            
           
        }
    }
}
