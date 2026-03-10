using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class MoyenDePaiement
    {
        [Key]
        public int IdMoyenDePaiement { get; set; }
        [Required, MaxLength(10)]
        public string CodeMoyenDePaiement { get; set; }
        [Required, MaxLength(100)]
        public string LibelleMoyenDePaiement { get; set; }
    }
}
