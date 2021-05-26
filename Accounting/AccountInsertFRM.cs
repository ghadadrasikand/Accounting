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
    public partial class AccountInsertFRM : Form
    {
        private readonly IAccountRepository repository;
        private static AccountInsertFRM FormInstance = null;
        public AccountInsertFRM()
        {
            InitializeComponent();
            repository = new AccountRepository();
        }

        public static AccountInsertFRM CreateInstance()
        {
            if (FormInstance == null)
            {
                FormInstance = new AccountInsertFRM();
            }
            return FormInstance;
        }

        private void btnaccountinsert_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                TarafHesab = txtTarafHesab.Text,
                AccountName = txtAccountName.Text
            };
            int result = repository.Insert(account);
            if (result > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("حساب ثبت نگردید");
            }
        }

        private void AccountInsertFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInstance = null;
            AccountListFRM accountListFRM = (AccountListFRM)Application.OpenForms["AccountListFRM"];
            accountListFRM.LoadGrideView();
        }

        private void AccountInsertFRM_Load(object sender, EventArgs e)
        {

        }
    }
}
