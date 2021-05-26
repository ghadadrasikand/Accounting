using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.EMFServerMessageFactory;
using CrystalDecisions.CrystalReports.Engine;

namespace Accounting
{
    public partial class GozareshFRM : Form
    {
        public GozareshFRM()
        {
            InitializeComponent();
        }

        

        private void GozareshFRM_Load(object sender, EventArgs e)
        {
            
            ReportDocument cryRpt = new ReportDocument();
            string reportPath = Path.Combine(Environment.CurrentDirectory, "CrystalReport4.rpt");
            //string reportPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //reportPath = Path.Combine(reportPath, "CrystalReport4.rpt");
            //cryRpt.Load(reportPath);

            //cryRpt.Load(Application.UserAppDataPath + "CrystalReport4.rpt");
            // cryRpt.Load("D:/Torfehnegar/Accounting/Accounting/CrystalReport4.rpt");
            //cryRpt.Load(Path.GetFullPath("CrystalReport4.rpt"));
            reportPath=reportPath.Replace("bin","");
            reportPath = reportPath.Replace("Debug", "");
            reportPath = reportPath.Replace("\\\\", "");
            cryRpt.Load(reportPath);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.RefreshReport();
            //crystalReportViewer1.Refresh();
        }
    }
}
