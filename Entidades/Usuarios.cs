using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }

        public Usuarios(int usuarioId, string nombreUsuario, string nombre, string clave)
        {
            this.UsuarioId = usuarioId;
            this.NombreUsuario = nombreUsuario;
            this.Nombre = nombre;
            this.Clave = clave;
        }

        public Usuarios()
        {

        }
    }
}
