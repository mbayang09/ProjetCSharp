using System;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace AppSenAgriculture.Helpers
{
	public class GMailer
	{
		/// <summary>
		/// Envoie un email via Gmail SMTP
		/// </summary>
		/// <param name="toEmail">Adresse email du destinataire</param>
		/// <param name="subject">Sujet de l'email</param>
		/// <param name="body">Corps de l'email (HTML autorisé)</param>
		/// <returns>true si l'envoi a réussi, false sinon</returns>
		public static bool SendMail(string toEmail, string subject, string body)
		{
			try
			{
				string email = ConfigurationManager.AppSettings["Email"];
				string password = ConfigurationManager.AppSettings["PasswordEmail"];

				if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
				{
					Utils.WriteFileError("Configuration email manquante dans App.config");
					return false;
				}

				using (MailMessage message = new MailMessage())
				{
					message.From = new MailAddress(email, "Sen Agriculture");
					message.To.Add(toEmail);
					message.Subject = subject;
					message.Body = body;
					message.IsBodyHtml = true;

					using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
					{
						smtp.EnableSsl = true;
						smtp.Credentials = new NetworkCredential(email, password);
						smtp.Timeout = 10000; // 10 secondes max

						smtp.Send(message);
					}
				}

				return true;
			}
			catch (Exception ex)
			{
				Utils.WriteFileError("Erreur envoi email à " + toEmail + " : " + ex.Message);
				Utils.WriteDataError("Envoi email", ex.Message);
				return false;
			}
		}

		/// <summary>
		/// Envoie un email avec une pièce jointe
		/// </summary>
		public static bool SendMailAvecPieceJointe(string toEmail, string subject,
			string body, string cheminFichier)
		{
			try
			{
				string email = ConfigurationManager.AppSettings["Email"];
				string password = ConfigurationManager.AppSettings["PasswordEmail"];

				using (MailMessage message = new MailMessage())
				{
					message.From = new MailAddress(email, "Sen Agriculture");
					message.To.Add(toEmail);
					message.Subject = subject;
					message.Body = body;
					message.IsBodyHtml = true;

					// Ajouter la pièce jointe
					if (!string.IsNullOrEmpty(cheminFichier)
						&& System.IO.File.Exists(cheminFichier))
					{
						message.Attachments.Add(new Attachment(cheminFichier));
					}

					using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
					{
						smtp.EnableSsl = true;
						smtp.Credentials = new NetworkCredential(email, password);
						smtp.Timeout = 15000;
						smtp.Send(message);
					}
				}

				return true;
			}
			catch (Exception ex)
			{
				Utils.WriteFileError("Erreur envoi email (pièce jointe) : " + ex.Message);
				return false;
			}
		}
	}
}