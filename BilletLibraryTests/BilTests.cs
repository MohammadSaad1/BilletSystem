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

        /// <summary>
        /// tester at der bliver kasten en exception hvis nummerpladen er otte tegn
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void NummerPlade8tegnTest()
        {
            var bil = new Bil();

            bil.NummerPlade = "AB123456";

        }

        /// <summary>
        /// tester at det ikke fejler hvis nummerpladen er 7 tegn
        /// </summary>
        [TestMethod()]
        public void NummerPlade7tegnTest()
        {
            //Arrange
            var bil = new Bil();
            //Act
            bil.NummerPlade = "AB12345";
            //Assert
            Assert.AreEqual("AB12345", bil.NummerPlade);
        }

        [TestMethod()]
        public void PrisBroBizzTest()
        {
            var bil = new Bil();
            bil.BroBizz = true;
            bil.Dato = new DateTime(2017, 8, 28);
            Assert.AreEqual(228, bil.Pris());
        }

        [TestMethod()]
        public void PrisLørdagTest()
        {
            var bil = new Bil();
            bil.BroBizz = false;
            bil.Dato = new DateTime(2017, 8, 26);
            Assert.AreEqual(192, bil.Pris());
        }

        [TestMethod()]
        public void PrisSøndagTest()
        {
            var bil = new Bil();
            bil.BroBizz = false;
            bil.Dato = new DateTime(2017, 8, 27);
            Assert.AreEqual(192, bil.Pris());
        }

        [TestMethod()]
        public void PrisMandagTest()
        {
            var bil = new Bil();
            bil.BroBizz = false;
            bil.Dato = new DateTime(2017, 8, 28);
            Assert.AreEqual(240, bil.Pris());
        }


    }
}