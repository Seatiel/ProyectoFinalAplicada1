using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ServiciosArticulos
    {
        public int ServicioArticuloId { get; set; }
        public int ArticuloId { get; set; }
        public int ServicioId { get; set; }
        public double Precio { get; set; }
    }
}
