
using AppSenAgriculture.Helpers;
using AppSenAgriculture.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {

            try
            {
                BdSenAgricultureContext db = new BdSenAgricultureContext();

                var leUser = db.utilisateurs
                    .Where(u => u.IdentifiantUtilisateur.ToLower() == txtIdentifiant.Text.ToLower())
                    .FirstOrDefault();

                if (leUser != null)
                {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        if (Crypto.VerifyMd5Hash(md5Hash, txtMotDePasse.Text, leUser.MotDePasseUtilisateur))
                        {
                            frmMDI f = new frmMDI();

                            if (db.admins.Where(a => a.ID == leUser.ID).FirstOrDefault() != null)
                            {

                                f.profil = "Admin";
                            }
                            else if (db.clients.Where(a => a.ID == leUser.ID).FirstOrDefault() != null)
                            {

                                f.profil = "Client";
                            }


                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Mot de passe ou Identifiant  incorrect");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mot de passe ou Identifiant introuvable");
                }

            }
            catch (Exception ex)
            {
                Utils.WriteLogSystem(ex.Message, "erreur de connexion");
                MessageBox.Show("Une erreur est survenue lors de la connexion. Veuillez réessayer plus tard.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmConnexion_Load(object sender, EventArgs e) {

            Utils.WriteFileError("test des erreurs ");
        }
    }
}
