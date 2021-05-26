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
    public partial class TarazUpdateFRM : Form
    {
        private readonly ITarazRepository repository;
        private static TarazUpdateFRM FormInstance = null;

        private int _Id = 0;

        Dictionary<bool, string> States = new Dictionary<bool, string>()
            {
                {true,"موجود" },
                {false,"ناموجود" },

            };

        public TarazUpdateFRM(int id)
        {
            InitializeComponent();
            repository = new TarazRepository();
            _Id = id;
        }

        public static TarazUpdateFRM CreateInstance(int id)
        {
            if (FormInstance == null)
            {
                FormInstance = new TarazUpdateFRM(id);
            }
            return FormInstance;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveTaraz_Click(object sender, EventArgs e)
        {
            Taraz  taraz = new Taraz()
            {
                Id = _Id,
                AccountId = Convert.ToInt32(comboNameAccount.SelectedValue),
                Flag = Convert.ToBoolean(comboFlag.SelectedValue),
                GardeshBedehkar = Convert.ToInt32(txtTotalGarBedehkar.Text),
                GardeshBestankar = Convert.ToInt32(txtTotalGarBestankar.Text),
                MandeBedehkar = Convert.ToInt32(txtMandeBedehkar.Text),
                MandeBestankar = Convert.ToInt32(txtMandeBestankar.Text),
                TotalGardeshBedehkar = Convert.ToInt32(txtTotalGarBedehkar.Text),
                TotalGardeshBestankar = Convert.ToInt32(txtTotalGarBestankar.Text),
                TotalMandeBedehkar=Convert.ToInt32(txtTotalMandeBedehkar.Text),
                TotalMandeBestankar=Convert.ToInt32(txtTotalMandeBestankar.Text)
                
            };
            int result = repository.Update(taraz);
            if (result > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("عملیات ویرایش ناموفق");
            }
        }

        private void TarazUpdateFRM_Load(object sender, EventArgs e)
        {
            comboFlag.DataSource = new BindingSource(States, null);
            comboFlag.DisplayMember = "Value";
            comboFlag.ValueMember = "Key";

            comboNameAccount.DataSource = repository.GetAllNameAccount();
            comboNameAccount.DisplayMember = "AccountName";
            comboNameAccount.ValueMember = "Id";

            Taraz taraz = repository.GetById(_Id);
            txtGardeshBedehkar.Text = taraz.GardeshBedehkar.ToString();
            txtGardeshBestankar.Text = taraz.GardeshBestankar.ToString();
            txtMandeBedehkar.Text = taraz.MandeBedehkar.ToString();
            txtMandeBestankar.Text = taraz.MandeBestankar.ToString();
            comboFlag.SelectedValue = taraz.Flag;
            txtTotalGarBedehkar.Text = taraz.TotalGardeshBedehkar.ToString();
            txtTotalGarBestankar.Text = taraz.TotalGardeshBestankar.ToString();
            txtTotalMandeBedehkar.Text = taraz.TotalMandeBedehkar.ToString();
            txtTotalMandeBestankar.Text = taraz.TotalMandeBestankar.ToString();
            comboNameAccount.SelectedValue = taraz.AccountId;
        }

        private void TarazUpdateFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInstance = null;
            TarazListFRM tarazListFRM = (TarazListFRM)Application.OpenForms["TarazListFRM"];
            tarazListFRM.LoadGrideView();
        }

        private void comboFlag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
