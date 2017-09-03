using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary.Tests
{
    [TestClass()]
    public class MCØresundTests
    {
        [TestMethod()]
        public void KøreTøjTypeTest()
        {
            var mc = new MCØresund();

            Assert.AreEqual("Øresund MC",mc.KøreTøjType());
        }

        [TestMethod()]
        public void PrisTest()
        {
            var mc = new MCØresund();
            mc.BroBizz = false;
            Assert.AreEqual(210,mc.Pris());
        }


        [TestMethod()]
        public void PrisBroBizzTest()
        {
            var mc = new MCØresund();
            mc.BroBizz = true;

            Assert.AreEqual(73, mc.Pris());
        }

    }
}