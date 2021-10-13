using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky_SergioSanchez.Models
{
    public class Lucky
    {
        [Key]
        public int SuerteID { get; set; }
        [StringLength(100, MinimumLength = 5, ErrorMessage ="detalle entre 5 a 100 caracteres")]
        public string Detalle { get; set; }
        [Url]
        [Required(ErrorMessage ="imagen requerida")]
        public string Imagen { get; set; }

    }
}
