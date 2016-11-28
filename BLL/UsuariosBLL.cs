using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BLL
{
    public class UsuariosBLL
    {
        public static bool Insertar(Usuarios usuario)
        {
            bool retorno = false;
            using (var db = new LavanderiaDb())
            {
                try
                {
                    if (Buscar(usuario.UsuarioId) == null)
                        db.Usuario.Add(usuario);
                    else
                        db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
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

        public static bool Eliminar(Usuarios usuario)
        {            
            bool retorno = false;
            using (var db = new LavanderiaDb())
            {
                try
                {
                    db.Entry(usuario).State = EntityState.Deleted;
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

        public static Usuarios Buscar(int id)
        {
            var usuario = new Usuarios();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    usuario = db.Usuario.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return usuario;
            }
        }

        //public static Usuarios Modificar(int id)
        //{
        //    var usuario = new Usuarios();
        //    using (var db = new LavanderiaDb())
        //    {
        //        try
        //        {
        //            usuario = db.Usuario.Find(id);
        //            db.Usuario.Add(usuario);
        //            db.SaveChanges();
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //        return usuario;
        //    }
        //}

        public static List<Usuarios> GetListNombreUsuarios(string nombreUsuario)
        {
            List<Usuarios> lista = new List<Usuarios>();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    //if (db.Usuario.Where(u => u.NombreUsuario == nombreUsuario).Count() > 0)
                    //    lista = db.Usuario.Where(u => u.NombreUsuario == nombreUsuario).ToList();
                    //else
                    //    lista = null;
                    lista = db.Usuario.Where(u => u.NombreUsuario == nombreUsuario).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }


        }

        public static List<Usuarios> GetListClave(string clave)
        {
            List<Usuarios> lista = new List<Usuarios>();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    //if (db.Usuario.Where(u => u.Clave == clave).Count() > 0)
                    //    lista = db.Usuario.Where(u => u.Clave == clave).ToList();
                    //else
                    //    lista = null;
                    lista = db.Usuario.Where(c => c.Clave == clave).ToList();
                }
                catch (Exception)
                {
                    throw;
                }
                return lista;
            }


        }

        public static List<Usuarios> GetList()
        {
            List<Usuarios> lista = new List<Usuarios>();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    if (db.Usuario.ToList().Count() > 0)
                        lista = db.Usuario.ToList();
                    else
                        lista = null;
                    //lista = db.Usuario.ToList();
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
