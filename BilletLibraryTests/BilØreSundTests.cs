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
    public class BilØreSundTests
    {

        [TestMethod()]
        public void KøreTøjTypeTest()
        {
            var bil = new BilØreSund();
            Assert.AreEqual("Øresund Bil", bil.KøreTøjType());

        }

        [TestMethod()]
        public void PrisTest()
        {
            var bil = new BilØreSund();
            bil.BroBizz = false;

            Assert.AreEqual(410, bil.Pris());
        }


        [TestMethod()]
        public void PrisBroBizzTest()
        {
            var bil = new BilØreSund();
            bil.BroBizz = true;

            Assert.AreEqual(161, bil.Pris());
        }


    }
}