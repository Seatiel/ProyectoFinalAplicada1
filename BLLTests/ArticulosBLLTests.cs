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
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Assert.IsTrue(ArticulosBLL.Insertar(new Articulos(4, "Pantalon")));
        }

        [TestMethod()]
        public void EliminarTest()
        {
     
            Assert.IsTrue(ArticulosBLL.Eliminar(new Articulos(2, "Pantalon")));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int a = 1;
            Assert.IsNull(ArticulosBLL.Buscar(a));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(ArticulosBLL.GetList());
        }
    }
}