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

        public Servicios(int servicioId, string nombre)
        {
            this.ServicioId = servicioId;
            this.Nombre = nombre;
        }

        public Servicios(string nombre)
        {
            this.Nombre = nombre;
        }

        public Servicios()
        {

        }        
    }
}
