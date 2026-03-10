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
        /// rédiger les erreurs au niveau de la base de données
        /// </summary>
        /// <param name="titre">le titre provoquant l'erreur</param>
        /// <param name="erreur">le message d'erreur</param>
        public static void WriteDataError(string TitreErreur, string erreur)
        {
            BdSenAgricultureContext db = new BdSenAgricultureContext();
            try
            {
                Td_Erreur log = new Td_Erreur();

                log.DateErreur = DateTime.Now;
                log.DescriptionErreur = erreur.Length > 1000 ? erreur.Substring(0, 1000) : erreur;
                log.TitreErreur = TitreErreur;

                db.tdErreurs.Add(log);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }
        }




        //<summary>
        /// logger des erreur sur une fichier txt 
        ///</summary>
        public static void WriteFileError(string message)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "Error","Erreur ");
                System.IO.TextWriter writeFile = new StreamWriter(path , true);
                writeFile.WriteLine(string.Format(" ", DateTime.Now));
                writeFile.WriteLine(message);
                writeFile.WriteLine("--------------------------------------------------");
                writeFile.Flush();
                writeFile.Close();
                writeFile = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de l'écriture du fichier de log. Veuillez vérifier les permissions d'écriture.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   


        }




        //<summary>
                /// permet de loger les erreurs dans le systeme de log de windows 
                ///</summary>
        public static void WriteLogSystem(string erreur ,string libelle)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "SenAgriculture";
                eventLog.WriteEntry(string.Format("date : {0}, libelle :{1} , description :{2)" ,DateTime.Now ,libelle , erreur ), EventLogEntryType.Information , 101);
            }
        }
    }
}
