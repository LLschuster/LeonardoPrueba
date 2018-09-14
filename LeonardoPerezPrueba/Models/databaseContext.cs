using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LeonardoPerezPrueba.Models
{
    public class databaseContext: DbContext
    {
        public DbSet<persona> personas { get; set; }
        public DbSet<sexo> sexos { get; set; }
    }
}