using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeonardoPerezPrueba.Models
{
    public class persona
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public int edad { get; set; }
        public int sexoId { get; set; }
        public sexo Sexo { get; set; }
    }
}