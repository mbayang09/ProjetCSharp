using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Champ
    {

        [Key]
        public int IdChamp { get; set; }
        [Required]
        public double Superficie{ get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        public int CommuneId { get; set; }
        [ForeignKey("CommuneId")]
        public virtual Commune Commune{ get; set; }
    }
}
