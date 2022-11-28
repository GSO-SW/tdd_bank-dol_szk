using Bank;

namespace BankTest
{
    [TestClass]
    public class KontoTests
    {
        [TestMethod]
        public void Einzahlen_und_Guthaben_Hinzufuegen()
        {
            // Arrange
            Konto k1 = new Konto(100);

            // Act
            k1.Einzahlen(100);

            // Assert
            Assert.AreEqual(200, k1.Guthaben);
        }

        [TestMethod]
        public void Auszahlen_und_Guthaben_abziehen()
        {
            // Arrange
            Konto k1 = new Konto(100);

            // Act 
            k1.Auszahlen(100);

            // Assert
            Assert.AreEqual(k1.Guthaben, 0);
        }

        [TestMethod]
        public void Guthaben_Ausgeben()
        {
            // Arrange
            Konto k1 = new Konto(100);

            // Act
            int temp = k1.Guthaben;

            // Assert
            Assert.AreEqual(temp, 100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Konto_KannNichtMitNegativemBetragErstelltWerden()
        {
            // Arrange
            int guthaben = -1;
            // Act
            Konto k = new Konto(guthaben);
        }

        [TestMethod]
        public void KontoNr_KannAbgefragtWerden()
        {
            // Arrange
            Konto k = new Konto(0);
            int nummer_soll = 1;
            // Act
            int nummer_ist = k.KontoNr;
            //Arrange
            Assert.AreEqual(nummer_soll, nummer_ist);
        }

        [TestMethod]
        public void KontoNr_WirdAutomatischVergeben()
        {
            // Arrange
            Konto k1 = new Konto(0);
            Konto k2 = new Konto(0);
            Konto k3 = new Konto(0);
            int kontoNummer_soll = 3;
            // Act
            int kontoNummer_ist = k3.KontoNr;
            // Assert
            Assert.AreEqual(kontoNummer_soll, kontoNummer_ist);
        }

    }
}