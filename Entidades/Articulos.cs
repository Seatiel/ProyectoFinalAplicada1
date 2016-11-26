using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public string Nombre { get; set; }

        private string v;

        public Articulos(string v)
        {
            this.v = v;
        }
    }
}
