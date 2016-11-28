using Entidades;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Data.Entity;

namespace BLL
{
    public class ClientesBLL
    {
        public static bool Insertar(Clientes cliente)
        {
            bool retorno = false;

            using (var db = new LavanderiaDb())
            {
                try
                {
                    if (Buscar(cliente.ClienteId) == null)
                        db.Cliente.Add(cliente);
                    else
                        db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
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

        public static bool Eliminar(Clientes cliente)
        {
            bool retorno = false;            
            using (var db = new LavanderiaDb())
            {
                try
                {
                    db.Entry(cliente).State = EntityState.Deleted;
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

        public static Clientes Buscar(int id)
        {
            var cliente = new Clientes();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    cliente = db.Cliente.Find(id);                    
                }
                catch (Exception)
                {
                    throw;
                }
                return cliente;
            }
        }

        //public static Clientes Modificar(int id, string nombre, string direccion, string telefono)
        //{            
        //    var cliente = new Clientes();
        //    using (var db = new LavanderiaDb())
        //    {
        //        try
        //        {
        //            cliente = db.Cliente.Where(c => c.ClienteId.Equals(id)).FirstOrDefault();
        //            cliente.Nombres = nombre;
        //            cliente.Direccion = direccion;
        //            cliente.Telefono = telefono;
        //            db.SaveChanges();                
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //        return cliente;
        //    }
        //}

        public static List<Clientes> GetListClienteId(int clienteId)
        {
            List<Clientes> lista = new List<Clientes>();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    if (db.Cliente.Where(c => c.ClienteId == clienteId).Count() > 0)
                        lista = db.Cliente.Where(c => c.ClienteId == clienteId).ToList();
                    else
                        lista = null;
                    //lista = db.Cliente.Where(c => c.ClienteId == clienteId).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Clientes> GetListNombres(string nombre)
        {
            List<Clientes> lista = new List<Clientes>();
            using (var db = new LavanderiaDb())
            {
                try
                {

                    if (db.Cliente.Where(c => c.Nombres == nombre).Count() > 0)
                        lista = db.Cliente.Where(c => c.Nombres == nombre).ToList();
                    else
                        lista = null;
                    //lista = db.Cliente.Where(c => c.Nombres == nombre).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Clientes> GetList()
        {
            List<Clientes> lista = new List<Clientes>();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    if (db.Cliente.ToList().Count() > 0)
                        lista = db.Cliente.ToList();
                    else
                        lista = null;
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
