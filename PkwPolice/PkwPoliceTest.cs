using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PkwPolice
{
    [TestClass]
    public class PkwPoliceTest
    {
        private PkwPolice _policeFuerGolf;

        [TestInitialize]
        public void InitPolice()
        {
            _policeFuerGolf = new PkwPolice(100);
        }

        [TestMethod]
        public void BerechnetGrundbeitragInAbhaengigkeitVonLeistung()
        {
            Assert.AreEqual(130, _policeFuerGolf.BerechneGrundbeitrag());
        }

        [TestMethod]
        public void BerechnetEndbeitragAusGrundbeitragUndVersicherungssteuer()
        {
            Assert.AreEqual(154.7, _policeFuerGolf.BerechneEndbeitrag());
        }

        [TestMethod]
        public void BerechnetAufpreisFuerFrauen()
        {
            Assert.AreEqual(167.7, _policeFuerGolf.BerechneEndbeitragFuerFrau());
        }
    }
}
