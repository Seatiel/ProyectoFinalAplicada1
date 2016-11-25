using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class ServiciosArticulosBLL
    {
        public static bool Insertar(ServiciosArticulos servicioArticulo)
        {
            bool retorno = false;
            using (var db = new LavanderiaDb())
            {
                try
                {
                    db.ServicioArticulo.Add(servicioArticulo);
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
            var servicioArticulo = new ServiciosArticulos();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    servicioArticulo = db.ServicioArticulo.Find(id);
                    db.ServicioArticulo.Remove(servicioArticulo);
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

        public static ServiciosArticulos Buscar(int id)
        {
            var servicioArticulo = new ServiciosArticulos();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    servicioArticulo = db.ServicioArticulo.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return servicioArticulo;
            }
        }

        public List<ServiciosArticulos> GetList()
        {
            List<ServiciosArticulos> lista = new List<ServiciosArticulos>();
            var db = new LavanderiaDb();
            lista = db.ServicioArticulo.ToList();
            return lista;
        }
    }
}
