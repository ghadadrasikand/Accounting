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
    public partial class TarazListFRM : Form
    {
        private readonly ITarazRepository repository;
        private static TarazListFRM FormInstance = null;
        public TarazListFRM()
        {
            InitializeComponent();
            repository = new TarazRepository();
        }
        public static TarazListFRM CreateInstance()
        {
            if (FormInstance == null)
            {
                FormInstance = new TarazListFRM();
            }
            return FormInstance;
        }


        public void LoadGrideView()
        {
            TarazListGv.DataSource = repository.GetAllByProcedure();
            TarazListGv.Columns[2].HeaderText = "شناسه تراز";
            TarazListGv.Columns[3].HeaderText = "شناسه حساب";
            TarazListGv.Columns[4].HeaderText = "گردش بدهکار";
            TarazListGv.Columns[5].HeaderText = "گردش بستانکار";
            TarazListGv.Columns[6].HeaderText = "مانده بدهکار";
            TarazListGv.Columns[7].HeaderText = "مانده بستانکار";
            TarazListGv.Columns[8].HeaderText = "جمع گردش بدهکار";
            TarazListGv.Columns[9].HeaderText = "جمع گردش بستانکار";
            TarazListGv.Columns[10].HeaderText = "جمع مانده بدهکار";
            TarazListGv.Columns[11].HeaderText = "جمع مانده بستانکار";
            TarazListGv.Columns[12].HeaderText = "وضعیت موجودی";

        }

        private void btnInsertTaraz_Click(object sender, EventArgs e)
        {
            TarazInsertFRM FRM = TarazInsertFRM.CreateInstance();
            FRM.Show();
        }

        private void TarazListFRM_Load(object sender, EventArgs e)
        {
            LoadGrideView();
        }

        private void TarazListFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInstance = null;
        }

        private void TarazListGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TarazListGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int Id = (int)TarazListGv.Rows[e.RowIndex].Cells["Id"].Value;
                TarazUpdateFRM FRM = TarazUpdateFRM.CreateInstance(Id);
                FRM.Show();
                //MessageBox.Show("index0");
            }
            if (e.ColumnIndex == 1)
            {
                int Id = (int)TarazListGv.Rows[e.RowIndex].Cells["Id"].Value;
                repository.Delete(Id);
                LoadGrideView();
                //MessageBox.Show("index0");
            }
        }
    }
}
