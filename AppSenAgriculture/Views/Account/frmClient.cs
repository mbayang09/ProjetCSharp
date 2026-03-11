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
		// Variable pour stocker l'ID du client sélectionné
		private int? clientSelectionneId = null;

		BdSenAgricultureContext db = new BdSenAgricultureContext();

		public frmClient()
		{
			InitializeComponent();
		}

		// ============================================================
		//  RÉINITIALISATION DU FORMULAIRE
		// ============================================================
		private void ResetForm()
		{
			txtEmail.Text = String.Empty;
			txtNomComplet.Text = String.Empty;
			txtProfession.Text = String.Empty;
			txtIdentifiiant.Text = String.Empty;
			txtAdresse.Text = String.Empty;
			txtTela.Text = String.Empty;
			clientSelectionneId = null;

			// Recharger la liste des clients dans le DataGridView
			dgClient.DataSource = db.clients.Select(a => new
			{
				a.ID,
				a.NomCompletUtilisateur,
				a.EmailUtilisateur,
				a.IdentifiantUtilisateur,
				a.TelUtilisateur,
				a.AdresseUtilisateur,
				a.ProfessionClient,
				Statut = a.EstBloque ? "Bloqué" : "Actif"
			}).ToList();

			txtNomComplet.Focus();
		}

		// ============================================================
		//  VALIDATION DU FORMULAIRE
		// ============================================================
		private bool ValiderFormulaire()
		{
			// Vérifier les champs obligatoires
			if (!Utils.ValiderChampObligatoire(txtNomComplet, "Nom complet")) return false;
			if (!Utils.ValiderChampObligatoire(txtEmail, "Email")) return false;
			if (!Utils.ValiderChampObligatoire(txtTela, "Téléphone")) return false;
			if (!Utils.ValiderChampObligatoire(txtIdentifiiant, "Identifiant")) return false;

			// Valider le format de l'email
			if (!Utils.ValiderEmail(txtEmail.Text))
			{
				MessageBox.Show(
					"L'adresse email n'est pas valide.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				txtEmail.Focus();
				return false;
			}

			// Valider le téléphone
			if (!Utils.ValiderTelephone(txtTela.Text))
			{
				MessageBox.Show(
					"Le numéro de téléphone n'est pas valide.\n" +
					"Format attendu : 7XXXXXXXX (9 chiffres)",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				txtTela.Focus();
				return false;
			}

			return true;
		}

		// ============================================================
		//  AJOUTER UN CLIENT
		// ============================================================
		private void btnAjouter_Click(object sender, EventArgs e)
		{
			try
			{
				if (!ValiderFormulaire()) return;

				// Vérifier si l'identifiant existe déjà
				var existe = db.utilisateurs
					.Where(u => u.IdentifiantUtilisateur.ToLower() == txtIdentifiiant.Text.ToLower())
					.FirstOrDefault();

				if (existe != null)
				{
					MessageBox.Show(
						"Cet identifiant est déjà utilisé. Veuillez en choisir un autre.",
						"Doublon",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
					);
					txtIdentifiiant.Focus();
					return;
				}

				Client ut = new Client();

				// Mot de passe par défaut = "drame" haché en MD5
				using (MD5 md5Hash = MD5.Create())
				{
					ut.MotDePasseUtilisateur = Crypto.GetMd5Hash(md5Hash, "drame");
				}

				ut.EmailUtilisateur = txtEmail.Text.Trim();
				ut.NomCompletUtilisateur = txtNomComplet.Text.Trim();
				ut.IdentifiantUtilisateur = txtIdentifiiant.Text.Trim();
				ut.TelUtilisateur = txtTela.Text.Trim();
				ut.AdresseUtilisateur = txtAdresse.Text.Trim();
				ut.ProfessionClient = txtProfession.Text.Trim();
				ut.EstBloque = false;

				db.clients.Add(ut);
				db.SaveChanges();

				// Envoyer un email de bienvenue au nouveau client
				EnvoyerEmailBienvenue(ut);

				MessageBox.Show("Client ajouté avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ResetForm();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Ajout client", ex);
			}
		}

		// ============================================================
		//  SÉLECTIONNER UN CLIENT (charger dans le formulaire)
		// ============================================================
		private void btnSelectionner_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgClient.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner un client dans la liste.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				int id = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
				Client client = db.clients.Find(id);

				if (client == null)
				{
					MessageBox.Show("Client introuvable.",
						"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Remplir les champs du formulaire
				clientSelectionneId = client.ID;
				txtNomComplet.Text = client.NomCompletUtilisateur;
				txtEmail.Text = client.EmailUtilisateur;
				txtTela.Text = client.TelUtilisateur;
				txtAdresse.Text = client.AdresseUtilisateur;
				txtIdentifiiant.Text = client.IdentifiantUtilisateur;
				txtProfession.Text = client.ProfessionClient;
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Sélection client", ex);
			}
		}

		// ============================================================
		//  MODIFIER UN CLIENT
		// ============================================================
		private void btnModifier_Click(object sender, EventArgs e)
		{
			try
			{
				if (clientSelectionneId == null)
				{
					MessageBox.Show(
						"Veuillez d'abord sélectionner un client à modifier.",
						"Information",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);
					return;
				}

				if (!ValiderFormulaire()) return;

				Client client = db.clients.Find(clientSelectionneId);
				if (client == null)
				{
					MessageBox.Show("Client introuvable.",
						"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Mettre à jour les champs
				client.NomCompletUtilisateur = txtNomComplet.Text.Trim();
				client.EmailUtilisateur = txtEmail.Text.Trim();
				client.TelUtilisateur = txtTela.Text.Trim();
				client.AdresseUtilisateur = txtAdresse.Text.Trim();
				client.IdentifiantUtilisateur = txtIdentifiiant.Text.Trim();
				client.ProfessionClient = txtProfession.Text.Trim();

				db.SaveChanges();

				MessageBox.Show("Client modifié avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ResetForm();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Modification client", ex);
			}
		}

		// ============================================================
		//  SUPPRIMER UN CLIENT
		// ============================================================
		private void btnSupprimer_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgClient.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner un client à supprimer.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				// Demander confirmation
				DialogResult confirmation = MessageBox.Show(
					"Êtes-vous sûr de vouloir supprimer ce client ?",
					"Confirmation de suppression",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);

				if (confirmation == DialogResult.No) return;

				int id = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
				Client client = db.clients.Find(id);

				if (client == null)
				{
					MessageBox.Show("Client introuvable.",
						"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				db.clients.Remove(client);
				db.SaveChanges();

				MessageBox.Show("Client supprimé avec succès !", "Succès",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				ResetForm();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Suppression client", ex);
			}
		}

		// ============================================================
		//  BLOQUER UN CLIENT
		// ============================================================
		private void btnBloquer_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgClient.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner un client à bloquer.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				int id = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
				Client client = db.clients.Find(id);

				if (client == null)
				{
					MessageBox.Show("Client introuvable.",
						"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (client.EstBloque)
				{
					MessageBox.Show("Ce client est déjà bloqué.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				DialogResult confirmation = MessageBox.Show(
					"Voulez-vous bloquer le client : " + client.NomCompletUtilisateur + " ?",
					"Confirmation",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);

				if (confirmation == DialogResult.No) return;

				client.EstBloque = true;
				db.SaveChanges();

				// Notifier le client par email
				string sujet = "Compte Sen Agriculture - Suspension";
				string corps = "<h2>Bonjour " + client.NomCompletUtilisateur + ",</h2>"
					+ "<p>Votre compte Sen Agriculture a été <strong>temporairement suspendu</strong>.</p>"
					+ "<p>Si vous pensez qu'il s'agit d'une erreur, veuillez contacter l'administrateur.</p>"
					+ "<p>Cordialement,<br/>L'équipe Sen Agriculture</p>";
				GMailer.SendMail(client.EmailUtilisateur, sujet, corps);

				MessageBox.Show(
					"Le client " + client.NomCompletUtilisateur + " a été bloqué.",
					"Client bloqué",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				ResetForm();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Blocage client", ex);
			}
		}

		// ============================================================
		//  DÉBLOQUER UN CLIENT
		// ============================================================
		private void btnDebloquer_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgClient.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner un client à débloquer.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				int id = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
				Client client = db.clients.Find(id);

				if (client == null)
				{
					MessageBox.Show("Client introuvable.",
						"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!client.EstBloque)
				{
					MessageBox.Show("Ce client n'est pas bloqué.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				client.EstBloque = false;
				db.SaveChanges();

				// Notifier le client par email
				string sujet = "Compte Sen Agriculture - Réactivation";
				string corps = "<h2>Bonjour " + client.NomCompletUtilisateur + ",</h2>"
					+ "<p>Votre compte Sen Agriculture a été <strong>réactivé</strong>.</p>"
					+ "<p>Vous pouvez désormais vous connecter normalement.</p>"
					+ "<p>Cordialement,<br/>L'équipe Sen Agriculture</p>";
				GMailer.SendMail(client.EmailUtilisateur, sujet, corps);

				MessageBox.Show(
					"Le client " + client.NomCompletUtilisateur + " a été débloqué.",
					"Client débloqué",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				ResetForm();
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Déblocage client", ex);
			}
		}

		// ============================================================
		//  RÉINITIALISER LE MOT DE PASSE D'UN CLIENT
		// ============================================================
		private void btnReInitialise_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgClient.CurrentRow == null)
				{
					MessageBox.Show("Veuillez sélectionner un client.",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				int id = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
				Client client = db.clients.Find(id);

				if (client == null)
				{
					MessageBox.Show("Client introuvable.",
						"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				DialogResult confirmation = MessageBox.Show(
					"Réinitialiser le mot de passe de " + client.NomCompletUtilisateur + " ?\n"
					+ "Le nouveau mot de passe sera : drame",
					"Confirmation",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);

				if (confirmation == DialogResult.No) return;

				// Remettre le mot de passe par défaut
				using (MD5 md5Hash = MD5.Create())
				{
					client.MotDePasseUtilisateur = Crypto.GetMd5Hash(md5Hash, "drame");
				}
				db.SaveChanges();

				// Envoyer un email avec le nouveau mot de passe
				string sujet = "Compte Sen Agriculture - Mot de passe réinitialisé";
				string corps = "<h2>Bonjour " + client.NomCompletUtilisateur + ",</h2>"
					+ "<p>Votre mot de passe a été réinitialisé.</p>"
					+ "<p>Votre nouveau mot de passe est : <strong>drame</strong></p>"
					+ "<p>Veuillez le changer dès votre prochaine connexion.</p>"
					+ "<p>Cordialement,<br/>L'équipe Sen Agriculture</p>";
				GMailer.SendMail(client.EmailUtilisateur, sujet, corps);

				MessageBox.Show(
					"Mot de passe de " + client.NomCompletUtilisateur + " réinitialisé.\n"
					+ "Un email a été envoyé au client.",
					"Succès",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
			}
			catch (Exception ex)
			{
				Utils.GererErreur("Réinitialisation mot de passe", ex);
			}
		}

		// ============================================================
		//  ENVOYER UN EMAIL DE BIENVENUE
		// ============================================================
		private void EnvoyerEmailBienvenue(Client client)
		{
			try
			{
				string sujet = "Bienvenue sur Sen Agriculture !";
				string corps = "<h2>Bienvenue " + client.NomCompletUtilisateur + " !</h2>"
					+ "<p>Votre compte a été créé avec succès sur la plateforme <strong>Sen Agriculture</strong>.</p>"
					+ "<p>Voici vos identifiants de connexion :</p>"
					+ "<ul>"
					+ "<li><strong>Identifiant</strong> : " + client.IdentifiantUtilisateur + "</li>"
					+ "<li><strong>Mot de passe</strong> : drame</li>"
					+ "</ul>"
					+ "<p><em>Veuillez changer votre mot de passe dès votre première connexion.</em></p>"
					+ "<p>Cordialement,<br/>L'équipe Sen Agriculture</p>";

				GMailer.SendMail(client.EmailUtilisateur, sujet, corps);
			}
			catch (Exception ex)
			{
				// L'email est secondaire, ne pas bloquer l'ajout du client
				Utils.GererErreur("Envoi email bienvenue", ex, false);
			}
		}

		// ============================================================
		//  IMPRIMER LA LISTE DES CLIENTS
		// ============================================================
		private void btnImprimer_Click(object sender, EventArgs e)
		{
			frmPrintClient frm = new frmPrintClient();
			frm.ShowDialog();
		}

		private void frmClient_Load(object sender, EventArgs e)
		{
			ResetForm();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			// Non utilisé
		}
	}
}