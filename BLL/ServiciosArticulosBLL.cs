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
        public static bool Insertar(List<ServiciosArticulos> servicioArticulo)
        {
            bool retorno = false;
            using (var db = new LavanderiaDb())
            {
                try
                {
                    db.ServicioArticulo.AddRange(servicioArticulo);                                       
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

        public static bool Eliminar(int articuloId)
        {
            bool retorno = false;
            var servicioArticulo = new ServiciosArticulos();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    db.ServicioArticulo.RemoveRange(db.ServicioArticulo.Where(sa => sa.ArticuloId == articuloId));
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

        public static List<ServiciosArticulos> Buscar(int articuloId)
        {
            var servicioArticulo = new List<ServiciosArticulos>();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    servicioArticulo = db.ServicioArticulo.Where(sa => sa.ArticuloId == articuloId).ToList();
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
