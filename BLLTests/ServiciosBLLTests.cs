using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Runtime.Remoting.Contexts;

namespace BLL.Tests
{
    [TestClass()]
    public class ServiciosBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Assert.IsTrue(ServiciosBLL.Insertar(new Servicios(1, "Lavado")));
        }

        [TestMethod()]
        public void EliminarTest()
        {                
            Assert.IsTrue(ServiciosBLL.Eliminar(new Servicios(1,"Lavado")));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int s = 1;
            Assert.IsNull(ServiciosBLL.Buscar(s));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(ServiciosBLL.GetList());
        }
    }
}