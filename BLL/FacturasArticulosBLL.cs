using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class FacturasArticulosBLL
    {
        public static bool Insertar(FacturasArticulos facturaArticulos)
        {
            bool retorno = false;
            using (var db = new LavanderiaDb())
            {
                try
                {
                    db.FacturaArticulo.Add(facturaArticulos);
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {
                    throw;
                }
                return retorno;
            }
        }

        public static bool Eliminar(int id)
        {
            bool retorno = false;
            var facturaArticulos = new FacturasArticulos();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    facturaArticulos = db.FacturaArticulo.Find(id);
                    db.FacturaArticulo.Remove(facturaArticulos);
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {
                    throw;
                }
                return retorno;
            }
        }

        public static FacturasArticulos Buscar(int id)
        {
            var facturaArticulos = new FacturasArticulos();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    facturaArticulos = db.FacturaArticulo.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return facturaArticulos;
            }
        }

        public List<FacturasArticulos> GetList()
        {
            List<FacturasArticulos> lista = new List<FacturasArticulos>();
            var db = new LavanderiaDb();
            lista = db.FacturaArticulo.ToList();
            return lista;
        }
    }
}
