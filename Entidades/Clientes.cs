using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Clientes(string nombre)
        {
            this.Nombres = nombre;            
        }

        public Clientes(int clienteId)
        {
            this.ClienteId = clienteId;
        }

        public Clientes()
        {

        }

        public Clientes(int clienteId, string nombre, string direccion, string telefono)
        {
            this.ClienteId = clienteId;
            this.Nombres = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
    }
}
