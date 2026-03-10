using AppSenAgriculture.Helpers;
using AppSenAgriculture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreateAdmin();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConnexion());
        }


        //summary>
        /// Créer un compte super admin par défaut si aucun n'existe
        /// </summary>

        private static void CreateAdmin()
        {
            BdSenAgricultureContext db = new BdSenAgricultureContext();
            var leAdmin = db.admins.ToList();
            if (leAdmin.Count == 0)
            {
                Admin admin = new Admin();

                admin.NomCompletUtilisateur = "Drame Mamadou";
                admin.EmailUtilisateur = "admin@gmail.com";
                admin.IdentifiantUtilisateur = "admin";
                admin.TelUtilisateur = "774000000";
                admin.AdresseUtilisateur = "Dakar";
                using (MD5 md5Hash = MD5.Create())
                {

                    admin.MotDePasseUtilisateur = Crypto.GetMd5Hash(md5Hash, "drame");
                }

                db.admins.Add(admin);   // ajouter dans la table
                db.SaveChanges();       // enregistrer dans la base

            }
        }
    }
}
