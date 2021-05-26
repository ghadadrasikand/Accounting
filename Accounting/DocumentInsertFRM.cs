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
    public partial class DocumentInsertFRM : Form
    {
        private readonly IDocumentRepository repository;
        private static DocumentInsertFRM FormInstance = null;
        public DocumentInsertFRM()
        {
            InitializeComponent();
            repository = new DocumentRepository();
        }

        public static DocumentInsertFRM CreateInstance()
        {
            if (FormInstance == null)
            {
                FormInstance = new DocumentInsertFRM();
            }
            return FormInstance;
        }
        private void btnSaveDocument_Click(object sender, EventArgs e)
        {
            Document document = new Document()
            {
                DocumentDetail = DocumentDetailtxt.Text,
                DocumentDate = DocumentDatepicker.Value,
                DocumentPage = Convert.ToInt32(Pagetxt.Text),
                Bedehkar = Convert.ToInt32(Bedehkartxt.Text),
                Bestankar = Convert.ToInt32(bestankartxt.Text),
                TotalBedehkar = Convert.ToInt32(TotalBedehkartxt.Text),
                TotalBestankar = Convert.ToInt32(TotalBestankartxt.Text),
                MandehHesab = Convert.ToInt32(MandeHesabtxt.Text),
                AccountId=Convert.ToInt32(NameHesabCombo.SelectedValue)
            };
            int result = 0;
            if (TotalBedehkartxt.Text != TotalBestankartxt.Text)
            {
                MessageBox.Show("باید جمع سند بدهکار و بستانکار مساوی باشد");
            }
            else
            {
                 result= repository.Insert(document);
            }
            
            if (result > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("سند ثبت نگردید");
            }

        }

        private void DocumentInsertFRM_Load(object sender, EventArgs e)
        {
            NameHesabCombo.DataSource= repository.GetAllNameAccount();
            NameHesabCombo.DisplayMember = "AccountName";
            NameHesabCombo.ValueMember = "Id";
        }

        private void DocumentInsertFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInstance = null;
            DocumentListFRM documentListFRM = (DocumentListFRM)Application.OpenForms["DocumentListFRM"];
            documentListFRM.LoadGrideView();
        }
    }
}
