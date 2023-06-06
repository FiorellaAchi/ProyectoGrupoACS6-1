using Conductor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace PruebaConductor
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            FrmMenuCond menu = new FrmMenuCond();
            Button bt = menu.Button2;
            bt.PerformClick();
            Assert.IsTrue(bt.Enabled);
        }
    }
}
