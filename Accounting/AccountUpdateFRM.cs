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
    public partial class AccountUpdateFRM : Form
    {
        private readonly IAccountRepository repository;
        private static AccountUpdateFRM FormInstance = null;

        private int _Id = 0;
        public AccountUpdateFRM(int id)
        {
            InitializeComponent();
            repository = new AccountRepository();
            _Id = id;
        }

        public static AccountUpdateFRM CreateInstance(int id)
        {
            if (FormInstance == null)
            {
                FormInstance = new AccountUpdateFRM(id);
            }
            return FormInstance;
        }

        private void btnaccountUpdate_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                Id = _Id,
                TarafHesab = txtTarafHesab.Text,
                AccountName = txtAccountName.Text
            };
            int result = repository.Update(account);
            if (result > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("عملیات ویرایش ناموفق");
            }
        }

        private void AccountUpdateFRM_Load(object sender, EventArgs e)
        {
            Account account = repository.GetById(_Id);
            txtTarafHesab.Text = account.TarafHesab;
            txtAccountName.Text=account.AccountName;
            
        }

        private void AccountUpdateFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInstance = null;
            AccountListFRM accountListFRM = (AccountListFRM)Application.OpenForms["AccountListFRM"];
            accountListFRM.LoadGrideView();
        }
    }
}
