using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class FacturasArticulos
    {
        [Key]
        public int FacturaArticuloId { get; set; }
        public int ArticuloId { get; set; }
        public int CantidadArticulos { get; set; }
        public int ServicioId { get; set; }
        public double SubTotal { get; set; }
        public int FacturaId { get; set; }

        public FacturasArticulos()
        {

        }
    }
}
