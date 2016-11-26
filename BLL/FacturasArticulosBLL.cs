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
        public static bool Insertar(List<FacturasArticulos> facturaArticulos)
        {
            bool retorno = false;
            using (var db = new LavanderiaDb())
            {
                try
                {
                    db.FacturaArticulo.AddRange(facturaArticulos);
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

        public static bool Eliminar(int facturaId)
        {
            bool retorno = false;
           
            using (var db = new LavanderiaDb())
            {
                try
                {
                    db.FacturaArticulo.RemoveRange(db.FacturaArticulo.Where(fa => fa.FacturaId == facturaId));
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

        public static List<FacturasArticulos> Buscar(int facturaId)
        {
            var facturaArticulos = new List<FacturasArticulos>();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    facturaArticulos = db.FacturaArticulo.Where(fa => fa.FacturaId == facturaId).ToList();
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
