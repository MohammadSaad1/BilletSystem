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
    public class BilTests
    {
        [TestMethod()]
        public void KøreTøjTypeTest()
        {
            var bil = new Bil();
            Assert.AreEqual("Bil", bil.KøreTøjType());
        }

        [TestMethod()]
        public void PrisTest()
        {
            var bil = new Bil();
            Assert.AreEqual(240, bil.Pris());
        }
    }
}