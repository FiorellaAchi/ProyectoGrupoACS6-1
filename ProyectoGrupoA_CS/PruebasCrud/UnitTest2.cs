using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasCrud
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Datos datos = new Datos();
            int info = datos.ListarAmbulancias(.Rows.Count;
            Assert.IsTrue(info > 0);
        }
    }
}
