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
    public partial class DocumentListFRM : Form
    {
        private readonly IDocumentRepository repository;
        private static DocumentListFRM FormInstance = null;
        public DocumentListFRM()
        {
            InitializeComponent();
            repository = new DocumentRepository();
        }
        public static DocumentListFRM CreateInstance()
        {
            if (FormInstance == null)
            {
                FormInstance = new DocumentListFRM();
            }
            return FormInstance;
        }
        public void LoadGrideView()
        {
            DocumentListGv.DataSource = repository.GetAllByProcedure();
            DocumentListGv.Columns[2].HeaderText = "شناسه سند";
            DocumentListGv.Columns[3].HeaderText = "شرح سند";
            DocumentListGv.Columns[4].HeaderText = "تاریخ سند";
            DocumentListGv.Columns[5].HeaderText = "صفحه سند";
            DocumentListGv.Columns[6].HeaderText = "وضعیت موجودی";
            DocumentListGv.Columns[7].HeaderText = "بدهکار";
            DocumentListGv.Columns[8].HeaderText = "بستانکار";
            DocumentListGv.Columns[9].HeaderText = "جمع بدهکار";
            DocumentListGv.Columns[10].HeaderText = "جمع بستانکار";
            DocumentListGv.Columns[11].HeaderText = "مانده حساب";
            DocumentListGv.Columns[12].HeaderText = "شناسه حساب";

        }
        private void btnInsertDocument_Click(object sender, EventArgs e)
        {
            DocumentInsertFRM FRM = DocumentInsertFRM.CreateInstance();
            FRM.Show();
        }

        private void DocumentListFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInstance = null;
        }

        private void DocumentListFRM_Load(object sender, EventArgs e)
        {
            LoadGrideView();
        }

        private void DocumentListGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int Id = (int)DocumentListGv.Rows[e.RowIndex].Cells["Id"].Value;
                DocumentUpdateFRM FRM = DocumentUpdateFRM.CreateInstance(Id);
                FRM.Show();
                //MessageBox.Show("index0");
            }
            if (e.ColumnIndex == 1)
            {
                int Id = (int)DocumentListGv.Rows[e.RowIndex].Cells["Id"].Value;
                repository.Delete(Id);
                LoadGrideView();
                //MessageBox.Show("index0");
            }
        }

        private void DocumentListGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
