using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    public class ServiciosBLL
    {
        public static bool Insertar(Servicios servicio)
        {
            bool retorno = false;
            using (var db = new LavanderiaDb())
            {
                try
                {
                    db.Servicio.Add(servicio);
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    //throw;
                }
                return retorno;
            }
        }

        public static bool Eliminar(int id)
        {
            bool retorno = false;
            var servicio = new Servicios();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    servicio = db.Servicio.Find(id);
                    db.Servicio.Remove(servicio);
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

        public static Servicios Buscar(int id)
        {
            var servicio = new Servicios();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    servicio = db.Servicio.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return servicio;
            }
        }

        public static List<Servicios> GetList()
        {
            List<Servicios> lista = new List<Servicios>();
            var db = new LavanderiaDb();
            lista = db.Servicio.ToList();
            return lista;
        }

    }
}
