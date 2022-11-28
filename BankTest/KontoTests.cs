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
        public void Konto_Konstruktor()
        {
            // Arrange
            int guthaben = 100;

            // Act
            Konto k1 = new Konto(guthaben);
            
            // Assert
            Assert.AreEqual(guthaben, k1.Guthaben);
        }
    }
}