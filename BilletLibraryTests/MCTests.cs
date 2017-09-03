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
    public class MCTests
    {

        [TestMethod()]
        public void KøreTøjTypeTest()
        {
            var mc = new MC();
            Assert.AreEqual("MC", mc.KøreTøjType());

        }

        [TestMethod()]
        public void PrisTest()
        {
            var mc = new MC();
            Assert.AreEqual(125,mc.Pris());
        }
    }
}