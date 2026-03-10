using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Client:Utilisateur
    {
        public string ProfessionClient {  get; set; }
    }



    //creation d 'un autre classe pour la liste des clients

    public class ReportListeClient : Utilisateur
    {
        public string ProfessionClient { get; set; }

        public string NomCompletUtilisateur { get; set; }
      
        public string AdresseUtilisateur { get; set; }
       
        public string EmailUtilisateur { get; set; }
      
        public string TelUtilisateur { get; set; }
    }
}
