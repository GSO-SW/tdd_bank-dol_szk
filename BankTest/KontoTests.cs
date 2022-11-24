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

        }

        [TestMethod]
        public void Guthaben_Ausgeben()
        {

        }
    }
}