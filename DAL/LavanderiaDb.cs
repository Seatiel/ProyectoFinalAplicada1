using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class LavanderiaDb : DbContext
    {
        public LavanderiaDb() : base("name=ConStr")
        {
        }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Facturas> Factura { get; set; }
        public DbSet<Servicios> Servicio { get; set; }
        public DbSet<Articulos> Articulo { get; set; }
        public DbSet<FacturasArticulos> FacturaArticulo { get; set; }
        public DbSet<ServiciosArticulos> ServicioArticulo { get; set; }



    }    
}
