using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Region
    {
        [Key]
        public int IdRegion { get; set; }
        [Required,MaxLength(10)]
        [Index(IsUnique = true)]
        public string CodeRegion { get; set; }
        [Required, MaxLength(100)]
        public string LibelleRegion { get; set; }

    }
}
