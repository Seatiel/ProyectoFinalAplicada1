using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Articulos
    {
        private string v;

        [Key]
        public int ArticuloId { get; set; }
        public string Nombre { get; set; }


        public Articulos(int id, string nombre)
        {
            this.ArticuloId = id;
            this.Nombre = nombre;
        }

        public Articulos()
        {

        }

        public Articulos(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
