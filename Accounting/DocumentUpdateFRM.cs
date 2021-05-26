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
    public partial class DocumentUpdateFRM : Form
    {
        private readonly IDocumentRepository repository;
        private static DocumentUpdateFRM FormInstance = null;
        private int _Id = 0;

        Dictionary<bool, string> States = new Dictionary<bool, string>()
            {
                {true,"موجود" },
                {false,"ناموجود" },

            };


        
        public DocumentUpdateFRM(int id)
        {
            InitializeComponent();
            repository = new DocumentRepository();
            _Id = id;

            
        }

        public static DocumentUpdateFRM CreateInstance(int id)
        {
            if (FormInstance == null)
            {
                FormInstance = new DocumentUpdateFRM(id);
            }
            return FormInstance;
        }

        private void btnUpdateDocument_Click(object sender, EventArgs e)
        {
            

            Document document = new Document()
            {
                Id = _Id,
                DocumentDetail = DocumentDetailtxt.Text,
                DocumentDate = DocumentDate.Value,
                DocumentPage = Convert.ToInt32(Pagetxt.Text),
                Flag=Convert.ToBoolean(DocumentFlagCombo.SelectedValue),
                Bedehkar = Convert.ToInt32(Bedehkartxt.Text),
                Bestankar = Convert.ToInt32(bestankartxt.Text),
                TotalBedehkar = Convert.ToInt32(TotalBedehkartxt.Text),
                TotalBestankar = Convert.ToInt32(TotalBestankartxt.Text),
                MandehHesab = Convert.ToInt32(MandeHesabtxt.Text),
                AccountId = Convert.ToInt32(NameHesabCombo.SelectedValue)
            };
            int result = repository.Update(document);
            if (result > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("عملیات ویرایش ناموفق");
            }
        }

        private void DocumentUpdateFRM_Load(object sender, EventArgs e)
        {
            DocumentFlagCombo.DataSource = new BindingSource(States, null);
            DocumentFlagCombo.DisplayMember = "Value";
            DocumentFlagCombo.ValueMember = "Key";

            NameHesabCombo.DataSource = repository.GetAllNameAccount();
            NameHesabCombo.DisplayMember = "AccountName";
            NameHesabCombo.ValueMember = "Id";

            Document document = repository.GetById(_Id);
             DocumentDetailtxt.Text = document.DocumentDetail;
             DocumentDate.Value = document.DocumentDate;
             Pagetxt.Text = document.DocumentPage.ToString();
            DocumentFlagCombo.SelectedValue = document.Flag;
            Bedehkartxt.Text = document.Bedehkar.ToString();
            bestankartxt.Text = document.Bestankar.ToString();
            TotalBedehkartxt.Text = document.TotalBedehkar.ToString();
            TotalBestankartxt.Text = document.TotalBestankar.ToString();
            MandeHesabtxt.Text = document.MandehHesab.ToString();
            NameHesabCombo.SelectedValue = document.AccountId;

            //txtType.Text = user.Type;
        }

        private void DocumentUpdateFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInstance = null;
            DocumentListFRM documentListFRM = (DocumentListFRM)Application.OpenForms["DocumentListFRM"];
            documentListFRM.LoadGrideView();
        }
    }
}
