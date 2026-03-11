using AppSenAgriculture.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture.Helpers
{
	public static class Utils
	{
		/// <summary>
		/// Enregistre une erreur dans la base de données (table Td_Erreur)
		/// </summary>
		/// <param name="TitreErreur">Le titre décrivant le contexte de l'erreur</param>
		/// <param name="erreur">Le message d'erreur détaillé</param>
		public static void WriteDataError(string TitreErreur, string erreur)
		{
			try
			{
				using (BdSenAgricultureContext db = new BdSenAgricultureContext())
				{
					Td_Erreur log = new Td_Erreur();
					log.DateErreur = DateTime.Now;
					log.DescriptionErreur = erreur.Length > 1000
						? erreur.Substring(0, 1000)
						: erreur;
					log.TitreErreur = TitreErreur.Length > 200
						? TitreErreur.Substring(0, 200)
						: TitreErreur;

					db.tdErreurs.Add(log);
					db.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				// Si la BDD est inaccessible, on écrit dans le fichier
				WriteFileError("WriteDataError a échoué : " + ex.Message);
				WriteLogSystem(ex.ToString(), "WriteDataError");
			}
		}

		/// <summary>
		/// Écrit une erreur dans un fichier texte local (dossier Error/)
		/// </summary>
		/// <param name="message">Le message d'erreur à enregistrer</param>
		public static void WriteFileError(string message)
		{
			try
			{
				// CORRECTION 1 : Créer le dossier s'il n'existe pas
				string dossierError = Path.Combine(Application.StartupPath, "Error");
				if (!Directory.Exists(dossierError))
				{
					Directory.CreateDirectory(dossierError);
				}

				// Nom du fichier avec la date du jour pour organiser les logs
				string nomFichier = "Erreur_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
				string path = Path.Combine(dossierError, nomFichier);

				// CORRECTION 2 : Utiliser using pour garantir la fermeture du fichier
				using (StreamWriter writeFile = new StreamWriter(path, true))
				{
					// CORRECTION 3 : Afficher la date correctement avec {0}
					writeFile.WriteLine(string.Format("[{0}]", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
					writeFile.WriteLine(message);
					writeFile.WriteLine("--------------------------------------------------");
				}
			}
			catch (Exception ex)
			{
				// En dernier recours, on affiche à l'utilisateur
				MessageBox.Show(
					"Erreur lors de l'écriture du log : " + ex.Message,
					"Erreur",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		/// <summary>
		/// Écrit une erreur dans le journal d'événements Windows
		/// </summary>
		/// <param name="erreur">Le message d'erreur</param>
		/// <param name="libelle">Le libellé/contexte de l'erreur</param>
		public static void WriteLogSystem(string erreur, string libelle)
		{
			try
			{
				using (EventLog eventLog = new EventLog("Application"))
				{
					eventLog.Source = "SenAgriculture";
					// CORRECTION 4 : {2) remplacé par {2}
					eventLog.WriteEntry(
						string.Format("date : {0}, libelle : {1}, description : {2}",
							DateTime.Now, libelle, erreur),
						EventLogEntryType.Error,
						101
					);
				}
			}
			catch (Exception)
			{
				// Si le journal Windows est inaccessible, on ne fait rien
				// pour éviter une boucle infinie d'erreurs
			}
		}

		/// <summary>
		/// Méthode centralisée pour gérer toutes les erreurs.
		/// Enregistre dans la BDD + fichier + journal Windows.
		/// Appelez cette méthode dans tous vos catch.
		/// </summary>
		/// <param name="titre">Contexte de l'erreur (ex: "Ajout client")</param>
		/// <param name="ex">L'exception capturée</param>
		/// <param name="afficherMessage">Afficher un MessageBox à l'utilisateur ?</param>
		public static void GererErreur(string titre, Exception ex, bool afficherMessage = true)
		{
			// 1. Enregistrer dans la base de données
			WriteDataError(titre, ex.Message);

			// 2. Enregistrer dans le fichier texte
			WriteFileError(titre + " : " + ex.ToString());

			// 3. Enregistrer dans le journal Windows
			WriteLogSystem(ex.Message, titre);

			// 4. Afficher un message à l'utilisateur si demandé
			if (afficherMessage)
			{
				MessageBox.Show(
					"Une erreur est survenue : " + ex.Message,
					"Erreur - " + titre,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		/// <summary>
		/// Valide qu'un champ texte n'est pas vide
		/// </summary>
		/// <param name="champ">Le TextBox à vérifier</param>
		/// <param name="nomChamp">Le nom du champ pour le message d'erreur</param>
		/// <returns>true si le champ est valide, false sinon</returns>
		public static bool ValiderChampObligatoire(TextBox champ, string nomChamp)
		{
			if (string.IsNullOrWhiteSpace(champ.Text))
			{
				MessageBox.Show(
					"Le champ '" + nomChamp + "' est obligatoire.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				champ.Focus();
				return false;
			}
			return true;
		}

		/// <summary>
		/// Valide le format d'une adresse email
		/// </summary>
		/// <param name="email">L'email à vérifier</param>
		/// <returns>true si l'email est valide</returns>
		public static bool ValiderEmail(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// Valide le format d'un numéro de téléphone sénégalais
		/// (commence par 7, 9 chiffres au total)
		/// </summary>
		/// <param name="telephone">Le numéro à vérifier</param>
		/// <returns>true si le numéro est valide</returns>
		public static bool ValiderTelephone(string telephone)
		{
			// Supprimer les espaces
			string tel = telephone.Replace(" ", "").Replace("-", "");

			// Vérifier : 9 chiffres, commence par 7
			if (tel.Length == 9 && tel.StartsWith("7") && tel.All(char.IsDigit))
				return true;

			// Accepter aussi le format avec indicatif +221
			if (tel.StartsWith("+221") && tel.Length == 13 && tel.Substring(4).All(char.IsDigit))
				return true;

			return false;
		}
	}
}