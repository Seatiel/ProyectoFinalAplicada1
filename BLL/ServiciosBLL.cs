using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                    if (Buscar(servicio.ServicioId) == null)
                        db.Servicio.Add(servicio);
                    else
                        db.Entry(servicio).State = System.Data.Entity.EntityState.Modified;
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

        public static bool Eliminar(Servicios servicio)
        {
            bool retorno = false;           
            using (var db = new LavanderiaDb())
            {
                try
                {
                    db.Entry(servicio).State = EntityState.Deleted;
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

            using (var db = new LavanderiaDb())
            {
                try
                {
                    if (db.Servicio.ToList().Count() > 0)
                        lista = db.Servicio.ToList();
                    else
                        lista = null;

                    //lista = db.Servicio.ToList();
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
