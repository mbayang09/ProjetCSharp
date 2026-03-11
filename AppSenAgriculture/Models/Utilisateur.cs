using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Utilisateur
    {
        [Key]
        public int ID { get; set; }
        [Required ,MaxLength(100)]
        public string NomCompletUtilisateur { get; set; }
        [MaxLength(300)]
        public string AdresseUtilisateur { get;set; }
        [Required,MaxLength(80)]
        public string EmailUtilisateur { get; set; }
        [Required, MaxLength(20)]
        public string TelUtilisateur { get; set; }
        [Required, MaxLength(20)]
        public string IdentifiantUtilisateur { get; set; }
        [Required, MaxLength(300)]
        public string MotDePasseUtilisateur { get; set; }


		public bool EstBloque { get; set; } = false;

	}
}
