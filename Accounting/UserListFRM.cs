using Accounting.IRepositories;
using Accounting.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class UserListFRM : Form
    {
        private readonly IUserRepository repository;
        private static UserListFRM FormInstance = null;
        public UserListFRM()
        {
            InitializeComponent();
            repository = new UserRepository();
            //GetAll();
        }
        public static UserListFRM CreateInstance()
        {
            if (FormInstance == null)
            {
                FormInstance = new UserListFRM();
            }
            return FormInstance;
        }


        public void LoadGrideView()
        {
            UserListGv.DataSource = repository.GetAllByProcedure();
            UserListGv.Columns[2].HeaderText = "شناسه کاربر";
            UserListGv.Columns[3].HeaderText = "نام کارمند";

            UserListGv.Columns[4].HeaderText = "نام کاربری";

            UserListGv.Columns[5].HeaderText = "رمز عبور";

            UserListGv.Columns[6].HeaderText = "نوع کاربری";


        }
        private void UserListFRM_Load(object sender, EventArgs e)
        {
            //GetAll();
            LoadGrideView();


        }

        private void UserListGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserInsertbtn_Click(object sender, EventArgs e)
        {
            string name = "a";
            UserInsertFRM FRM = UserInsertFRM.CreateInstance(name);
            FRM.Show();
        }

        private void UserListGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int Id = (int)UserListGv.Rows[e.RowIndex].Cells["Id"].Value;
                UserUpdateFRM FRM =UserUpdateFRM.CreateInstance(Id);
                FRM.Show();
                //MessageBox.Show("index0");
            }
            if (e.ColumnIndex == 1)
            {
                int Id = (int)UserListGv.Rows[e.RowIndex].Cells["Id"].Value;
                repository.Delete(Id);
                LoadGrideView();
                //MessageBox.Show("index0");
            }
        }

        private void UserListFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInstance = null;
        }
    }
}
