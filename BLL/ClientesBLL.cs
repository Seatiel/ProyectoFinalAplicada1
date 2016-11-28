using Entidades;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

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
                    db.Cliente.Add(cliente);
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
            var cliente = new Clientes();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    cliente = db.Cliente.Find(id);
                    db.Cliente.Remove(cliente);
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

        public static Clientes Modificar(int id, string nombre, string direccion, string telefono)
        {            
            var cliente = new Clientes();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    cliente = db.Cliente.Where(c => c.ClienteId.Equals(id)).FirstOrDefault();
                    cliente.Nombres = nombre;
                    cliente.Direccion = direccion;
                    cliente.Telefono = telefono;
                    db.SaveChanges();                
                }
                catch (Exception)
                {
                    throw;
                }
                return cliente;
            }
        }

        public static List<Clientes> GetList()
        {
            List<Clientes> lista = new List<Clientes>();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    lista = db.Cliente.ToList();
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
