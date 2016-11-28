using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public Double Total { get; set; }

        public Facturas(int facturaId, int clienteId, DateTime fecha, Double total)
        {
            this.FacturaId = facturaId;
            this.ClienteId = clienteId;
            this.Fecha = fecha;
            this.Total = total;
        }

        public Facturas()
        {

        }
    }
}
