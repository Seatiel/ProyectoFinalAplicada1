using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Servicios
    {
        [Key]
        public int ServicioId { get; set; }
        public string Nombre { get; set; }
               

        public Servicios(string v)
        {
            this.Nombre = v;
        }

        public Servicios()
        {

        }

        
    }
}
