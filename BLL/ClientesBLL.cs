using Entidades;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public static Clientes Eliminar(int id)
        {
            var cliente = new Clientes();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    cliente = db.Cliente.Find(id);
                    db.Cliente.Remove(cliente);
                    db.SaveChanges();                    
                }
                catch (Exception)
                {
                    throw;
                }
                return cliente;
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

        public static Clientes Modificar(int id)
        {
            var cliente = new Clientes();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    cliente = db.Cliente.Find(id);
                    db.Cliente.Add(cliente);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                return cliente;
            }
        }

    }
}
