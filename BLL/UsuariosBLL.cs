using DAL;
using Entidades;
using System;
using System.Collections.Generic;
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
                    db.Usuario.Add(usuario);
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

        public static Usuarios Eliminar(int id)
        {
            var usuario = new Usuarios();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    usuario = db.Usuario.Find(id);
                    db.Usuario.Remove(usuario);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                return usuario;
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

        public static Usuarios Modificar(int id)
        {
            var usuario = new Usuarios();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    usuario = db.Usuario.Find(id);
                    db.Usuario.Add(usuario);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                return usuario;
            }
        }

        public static List<Usuarios> GetListUsuarios(string usuario)
        {
            List<Usuarios> lista = new List<Usuarios>();
            LavanderiaDb db = new LavanderiaDb();
            lista = db.Usuario.Where(p => p.Nombre == usuario).ToList();
            return lista;
        }

        public static List<Usuarios> GetListClave(string clave)
        {
            List<Usuarios> lista = new List<Usuarios>();
            LavanderiaDb db = new LavanderiaDb();
            lista = db.Usuario.Where(p => p.Clave == clave).ToList();
            return lista;
        }


    }
}
