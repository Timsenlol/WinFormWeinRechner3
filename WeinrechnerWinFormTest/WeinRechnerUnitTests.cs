using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeinRechnerWinForm.Business;

namespace WeinrechnerWinFormTest
{
    [TestClass]
    public class WeinRechnerUnitTests
    {
        [TestMethod]
        public void testVerschnittGenerell()
        {
            var rechner = new BerechnungsService();
            var ergebnis = rechner.BerechneVerschnittGenerellService(1000.0);
            Assert.AreEqual(176,ergebnis.max_vw);
            Assert.AreEqual(176, ergebnis.max_vw1);
            Assert.AreEqual(333, ergebnis.max_sr1);

            //Test


        }
    }
}
