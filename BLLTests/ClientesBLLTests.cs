using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class ClientesBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Assert.IsTrue(ClientesBLL.Insertar(new Clientes(1,"sada", "asdd", "22131321131")));            
        }

        [TestMethod()]
        public void EliminarTest()
        {            
            Assert.IsTrue(ClientesBLL.Eliminar(new Clientes(1, "sada", "asdd", "g13s21f")));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int c = 1;
            Assert.IsNull(ClientesBLL.Buscar(c));
        }

        [TestMethod()]
        public void GetListClienteIdTest()
        {
            Assert.IsNull(ClientesBLL.GetListClienteId(1));
        }

        [TestMethod()]
        public void GetListNombresTest()
        {
           
            Assert.IsNull(ClientesBLL.GetListNombres("fgfgfdg"));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(ClientesBLL.GetList());
        }
    }
}