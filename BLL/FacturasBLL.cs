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
                    if (Buscar(factura.FacturaId) == null)
                        db.Factura.Add(factura);
                    else
                        db.Entry(factura).State = System.Data.Entity.EntityState.Modified;
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

        public static List<Facturas> GetListId(int facturaId)
        {
            List<Facturas> lista = new List<Facturas>();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    lista = db.Factura.Where(f => f.FacturaId == facturaId).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Facturas> GetListClienteId(int clienteId)
        {
            List<Facturas> lista = new List<Facturas>();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    lista = db.Factura.Where(f => f.ClienteId == clienteId).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Facturas> GetListFecha(DateTime desde, DateTime hasta)
        {
            List<Facturas> lista = new List<Facturas>();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    lista = db.Factura.Where(f => f.Fecha >= desde && f.Fecha <= hasta).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Facturas> GetList()
        {
            List<Facturas> lista = new List<Facturas>();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    lista = db.Factura.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }
    }
}
