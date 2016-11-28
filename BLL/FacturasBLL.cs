using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class FacturasBLL
    {
        public static bool Insertar(Facturas factura)
        {
            bool retorno = false;
            using (var db = new LavanderiaDb())
            {
                try
                {
                    db.Factura.Add(factura);
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
            var factura = new Facturas();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    factura = db.Factura.Find(id);
                    db.Factura.Remove(factura);
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

        public static Facturas Buscar(int id)
        {
            var factura = new Facturas();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    factura = db.Factura.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return factura;
            }
        }

        public static Facturas Modificar(int id)
        {
            var factura = new Facturas();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    factura = db.Factura.Where(c => c.FacturaId.Equals(id)).FirstOrDefault();                
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                return factura;
            }
        }

        public static List<Facturas> GetList()
        {
            List<Facturas> lista = new List<Facturas>();
            var db = new LavanderiaDb();
            lista = db.Factura.ToList();
            return lista;
        }
    }
}
