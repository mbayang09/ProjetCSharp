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
                a.ProfessionClient,
                EstBloque = (bool?)a.EstBloque
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
                ut.EstBloque = false;
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

        private void btnBloquer_Click(object sender, EventArgs e)
        {
            if (dgClient.CurrentRow != null)
            {
                int id = (int)dgClient.CurrentRow.Cells["ID"].Value;
                Client cl = db.clients.Find(id);

                if (cl == null)
                {
                    MessageBox.Show("Client introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!cl.EstBloque) // si le client n'est pas déjà bloqué
                {
                    cl.EstBloque = true; // on bloque
                    db.SaveChanges();

                    btnBloquer.Enabled = false;
                    btnDebloquer.Enabled = true;

                    MessageBox.Show("Le client a été bloqué avec succès.", "Bloqué", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Ce client est déjà bloqué.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDebloquer_Click(object sender, EventArgs e)
        {
            int id = (int)dgClient.CurrentRow.Cells["ID"].Value;
            Client cl = db.clients.Find(id);

            if (cl == null)
            {
                MessageBox.Show("Client introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cl.EstBloque) // si le client est bloqué
            {
                cl.EstBloque = false; // on le débloque
                db.SaveChanges();

                btnBloquer.Enabled = true;
                btnDebloquer.Enabled = false;

                MessageBox.Show("Le client a été débloqué avec succès.", "Débloqué", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            else
            {
                MessageBox.Show("Ce client est déjà débloqué.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReInitialise_Click(object sender, EventArgs e)
        {
            try
            {
                // Vide tous les TextBox
                txtEmail.Text = string.Empty;
                txtNomComplet.Text = string.Empty;
                txtProfession.Text = string.Empty;
                txtIdentifiiant.Text = string.Empty;
                txtAdresse.Text = string.Empty;
                txtTela.Text = string.Empty;

                // Remet le focus sur le premier champ
                txtNomComplet.Focus();

                // Réinitialise les boutons Bloquer / Débloquer
                btnBloquer.Enabled = true;
                btnDebloquer.Enabled = true;

                // Recharge le DataGridView en gérant les valeurs null
                dgClient.DataSource = db.clients.Select(a => new
                {
                    a.ID,
                    a.NomCompletUtilisateur,
                    a.EmailUtilisateur,
                    a.IdentifiantUtilisateur,
                    a.TelUtilisateur,
                    a.AdresseUtilisateur,
                    a.ProfessionClient,
                    EstBloque = a.EstBloque // ← gère les null
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la réinitialisation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgClient.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupère l'ID du client sélectionné
            int id = (int)dgClient.CurrentRow.Cells["ID"].Value;
            Client cl = db.clients.Find(id);

            if (cl == null)
            {
                MessageBox.Show("Client introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Demande confirmation avant suppression
            DialogResult result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer le client '{cl.NomCompletUtilisateur}' ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    db.clients.Remove(cl);
                    db.SaveChanges();

                    MessageBox.Show("Client supprimé avec succès.", "Supprimé", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Rafraîchit le DataGridView
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
    }
}
