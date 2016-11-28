using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class FacturasArticulos
    {
        private int selectedValue1;
        private int v;
        private int selectedValue2;

        [Key]
        public int FacturaArticuloId { get; set; }
        public int ArticuloId { get; set; }
        public int CantidadArticulos { get; set; }
        public int ServicioId { get; set; }
        public Double SubTotal { get; set; }
        public int FacturaId { get; set; }

        public FacturasArticulos(int articuloId, int cantidadArticulos, int servicioId, Double subTotal)
        {
            this.ArticuloId = articuloId;
            this.CantidadArticulos = cantidadArticulos;
            this.ServicioId = servicioId;
            this.SubTotal = subTotal;
        }

        public FacturasArticulos()
        {

        }

        public FacturasArticulos(int articulo, int cantidad, int servicio)
        {
            this.ArticuloId = articulo;
            this.CantidadArticulos = cantidad;
            this.ServicioId = servicio;
        }
    }
}
