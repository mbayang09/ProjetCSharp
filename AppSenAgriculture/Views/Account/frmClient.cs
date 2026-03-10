using AppSenAgriculture.Helpers;
using AppSenAgriculture.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AppSenAgriculture.Views.Account
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
            ResetForm();
        }



        BdSenAgricultureContext db = new BdSenAgricultureContext(); 

        private void ResetForm()
        {
            txtEmail.Text = String.Empty;
            txtNomComplet.Text = String.Empty;
            txtProfession.Text = String.Empty;
            txtIdentifiiant.Text = String.Empty;
            txtAdresse.Text = String.Empty;
            txtTela.Text = String.Empty;
            txtNomComplet.Focus();
            dgClient.DataSource = db.clients.Select(a=>new
            {
                a.ID,
                a.NomCompletUtilisateur,
                a.EmailUtilisateur,
                a.IdentifiantUtilisateur,
                a.TelUtilisateur,
                a.AdresseUtilisateur,
                a.ProfessionClient
            }).ToList();
            txtNomComplet.Focus();
        }   


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            Client ut = new Client();


            using (MD5 md5Hash = MD5.Create())
            {
               
                ut.MotDePasseUtilisateur = Crypto.GetMd5Hash(md5Hash, "drame");
            }

                ut.EmailUtilisateur = txtEmail.Text;
                ut.NomCompletUtilisateur = txtNomComplet.Text;
                ut.IdentifiantUtilisateur = txtIdentifiiant.Text;
                ut.TelUtilisateur = txtTela.Text;
                ut.AdresseUtilisateur = txtAdresse.Text;
                ut.NomCompletUtilisateur= txtNomComplet.Text;
                ut.ProfessionClient = txtProfession.Text;
                db.clients.Add(ut);
                db.SaveChanges();


                MessageBox.Show("Client ajouté avec succès");
                ResetForm();
            }



        private void frmClient_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            frmPrintClient frm = new frmPrintClient();
            frm.ShowDialog();


        }
    }
}
