using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Departement
    {
        [Key]
        public int IdDepartement { get; set; }
        [Required, MaxLength(10)]
        public string CodeDepartement { get; set; }
        [Required, MaxLength(100)]
        public string LibelleDepartement { get; set; }
        public int RegionId { get; set; }
        [ForeignKey("RegionId")]
        public virtual Region Region { get; set; }
    }
}
