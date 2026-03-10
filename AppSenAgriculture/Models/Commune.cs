using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
   public class Commune
    {

        [Key]
        public int IdCommune { get; set; }
        [Required, MaxLength(10)]
        public string CodeCommune { get; set; }
        [Required, MaxLength(100)]
        public string LibelleCommune { get; set; }
        public int DepartementId { get; set; }
        [ForeignKey("DepartementId")]
        public virtual Departement Departement { get; set; }
    }
}
