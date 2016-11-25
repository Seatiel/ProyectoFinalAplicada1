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
                catch (Exception e)
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
                    db.Cliente.Find(id);
                    db.Cliente.Remove(cliente);
                    db.SaveChanges();
                    retorno = true;                   
                }
                catch (Exception e)
                {
                    //throw;
                    MessageBox.Show(e.ToString());
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

        public static bool Modificar(int id)
        {
            bool retornno = false;
            var cliente = new Clientes();
            using (var db = new LavanderiaDb())
            {
                try
                {
                    db.Cliente.Find(id);
                    db.Cliente.Add(cliente);
                    db.SaveChanges();
                    retornno = true;
                }
                catch (Exception)
                {
                    throw;
                }
                return retornno;
            }
        }

        public static List<Clientes> GetList()
        {
            List<Clientes> lista = new List<Clientes>();
            var db = new LavanderiaDb();
            lista = db.Cliente.ToList();
            return lista;
        }


    }
}
