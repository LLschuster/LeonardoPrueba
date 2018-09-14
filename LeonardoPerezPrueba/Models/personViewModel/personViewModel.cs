using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeonardoPerezPrueba.Models.personViewModel
{
    public class personViewModel
    {
        public persona persona { get; set; }
        public IEnumerable<sexo> sexos { get; set; }
    }
}