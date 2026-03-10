using AppSenAgriculture.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture.Views.Account
{
    public partial class frmPrintClient : Form
    {
        public frmPrintClient()
        {
            InitializeComponent();
        }




        private void frmPrintClient_Load(object sender, EventArgs e)
        {
            using (BdSenAgricultureContext db = new BdSenAgricultureContext())
            {
                // Récupérer la liste des clients depuis la base
                var clients = db.clients.ToList(); // List<Client> compatible IEnumerable

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = "Report\\rptListeClient.rdlc";

                // Créer la source de données avec la liste des clients
                ReportDataSource rds = new ReportDataSource("DataSet1", clients);

                // Ajouter au report
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                // Rafraîchir le report
                reportViewer1.RefreshReport();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
