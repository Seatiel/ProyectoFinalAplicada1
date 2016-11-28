using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    public class ArticulosBLL
    {
        public static bool Insertar(Articulos articulo)
        {
            bool retorno = false;

            using (var db = new LavanderiaDb())
            {
                try
                {
                    db.Articulo.Add(articulo);
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
            var articulo = new Articulos();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    articulo = db.Articulo.Find(id);
                    db.Articulo.Remove(articulo);
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

        public static Articulos Buscar(int id)
        {
            var articulos = new Articulos();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    articulos = db.Articulo.Find(id);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    //throw;
                }
                return articulos;
            }
        }

        public static List<Articulos> GetList()
        {
            List<Articulos> lista = new List<Articulos>();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    lista = db.Articulo.ToList();
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
