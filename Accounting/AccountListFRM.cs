using Accounting.IRepositories;
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
    public partial class AccountListFRM : Form
    {
        private readonly IAccountRepository repository;
        private static AccountListFRM FormInstance = null;
        public AccountListFRM()
        {
            InitializeComponent();
            repository = new AccountRepository();
        }
        public static AccountListFRM CreateInstance()
        {
            if (FormInstance == null)
            {
                FormInstance = new AccountListFRM();
            }
            return FormInstance;
        }
        public void LoadGrideView()
        {
            AccountListGv.DataSource = repository.GetAllByProcedure();
            AccountListGv.Columns[1].HeaderText = "شناسه حساب";
            AccountListGv.Columns[2].HeaderText = "نام طرف حساب";
            AccountListGv.Columns[3].HeaderText = "نام حساب";
        }
        private void AccountInsertbtn_Click(object sender, EventArgs e)
        {
            AccountInsertFRM FRM = AccountInsertFRM.CreateInstance();
            FRM.Show();

        }

        private void AccountListFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            //AccountListFRM FRM = AccountListFRM.CreateInstance();
            FormInstance = null;
        }

        private void AccountListFRM_Load(object sender, EventArgs e)
        {
            LoadGrideView();
        }

        private void AccountListGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AccountListGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int Id = (int)AccountListGv.Rows[e.RowIndex].Cells["Id"].Value;
                AccountUpdateFRM FRM = AccountUpdateFRM.CreateInstance(Id);
                FRM.Show();
                //MessageBox.Show("index0");
            }
        }
    }
}
