using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeonardoPerezPrueba.Models
{
    public class persona
    {
        public int id { get; set; }

        [StringLength(20)]
        public String nombre { get; set; }

        public int edad { get; set; }

        [Display(Name = "Sexo")]
        public int sexoId { get; set; }

        public sexo Sexo { get; set; }
    }
}