using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ServiciosArticulos
    {
        [Key]
        public int ServicioArticuloId { get; set; }
        public int ArticuloId { get; set; }
        public int ServicioId { get; set; }
        public Double Precio { get; set; }

        public ServiciosArticulos(int sevicioId, double precio)
        {
            this.ServicioId = sevicioId;
            this.Precio = precio;
        }

        public ServiciosArticulos()
        {

        }        
    }
}
