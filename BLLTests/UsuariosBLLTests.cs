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
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Assert.IsTrue(UsuariosBLL.Insertar(new Usuarios(12, "sada", "asdd", "22131321131")));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(UsuariosBLL.Eliminar(new Usuarios(454, "sada", "asdd", "2312323")));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int c = 1;
            Assert.IsNull(UsuariosBLL.Buscar(c));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void GetListNombreUsuariosTest()
        {
            Assert.IsNotNull(UsuariosBLL.GetListNombreUsuarios("dsgsgsgd"));
        }

        [TestMethod()]
        public void GetListClaveTest()
        {
            Assert.IsNotNull(UsuariosBLL.GetListClave("1231sfds"));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(UsuariosBLL.GetList());
        }
    }
}