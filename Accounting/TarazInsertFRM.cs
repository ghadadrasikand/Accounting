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
    public partial class TarazInsertFRM : Form
    {
        private readonly ITarazRepository repository;
        private static TarazInsertFRM FormInstance = null;

        public TarazInsertFRM()
        {
            InitializeComponent();
            repository = new TarazRepository();
        }
        public static TarazInsertFRM CreateInstance()
        {
            if (FormInstance == null)
            {
                FormInstance = new TarazInsertFRM();
            }
            return FormInstance;
        }
        private void TarazInsertFRM_Load(object sender, EventArgs e)
        {

            comboNameAccount.DataSource = repository.GetAllNameAccount();
            comboNameAccount.DisplayMember = "AccountName";
            comboNameAccount.ValueMember = "Id";

        }

        private void btnSaveTaraz_Click(object sender, EventArgs e)
        {
            
            Taraz taraz = new Taraz()
            {
                
                GardeshBedehkar =Convert.ToInt32(txtGardeshBedehkar.Text),
                GardeshBestankar =Convert.ToInt32(txtGardeshBestankar.Text),
                MandeBedehkar = Convert.ToInt32(txtMandeBedehkar.Text),
                MandeBestankar = Convert.ToInt32(txtMandeBestankar.Text),
                TotalGardeshBedehkar = Convert.ToInt32(txtTotalGarBedehkar.Text),
                TotalGardeshBestankar = Convert.ToInt32(txtTotalGarBestankar.Text),
                TotalMandeBedehkar = Convert.ToInt32(txtTotalMandeBedehkar.Text),
                TotalMandeBestankar = Convert.ToInt32(txtTotalMandeBestankar.Text),
                AccountId = Convert.ToInt32(comboNameAccount.SelectedValue)
            };
           
            int result = repository.Insert(taraz);
            

            if (result > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("تراز ثبت نگردید");
            }
        }

        private void TarazInsertFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInstance = null;
            TarazListFRM tarazListFRM = (TarazListFRM)Application.OpenForms["TarazListFRM"];
            tarazListFRM.LoadGrideView();
        }
    }
}
