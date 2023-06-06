using Conductor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace PruebaConductor
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FrmMenuCond menu = new FrmMenuCond();
            Button bt = menu.Button1;
            bt.PerformClick();
            Assert.IsTrue(bt.Enabled);
        }
    }
}
