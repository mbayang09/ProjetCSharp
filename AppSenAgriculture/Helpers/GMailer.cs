using System;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace AppSenAgriculture.Helpers
{
    public class GMailer
    {
        public static void SendMail(string toEmail, string subject, string body)
        {
            try
            {
                string email = ConfigurationManager.AppSettings["Email"];
                string password = ConfigurationManager.AppSettings["PasswordEmail"];

                MailMessage message = new MailMessage();
                message.From = new MailAddress(email);
                message.To.Add(toEmail);
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(email, password);

                smtp.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}