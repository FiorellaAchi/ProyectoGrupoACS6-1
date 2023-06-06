using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasCrud
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Datos datos = new Datos();
            int info = datos.ListarConductores().Rows.Count;
            Assert.IsTrue(info > 0);
        }
    }
}
