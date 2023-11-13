using FizzBuzz;
using System.Security.Cryptography.X509Certificates;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {
        [TestMethod]
        public void N�r_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException()
        {
            // Arrange
            int randomNummer = 3;

            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual("fizz", result);
            Assert.AreEqual("buzz", result);

            // Testet kommer att bli gr�nt d� ett NotImplementedException kastas
        }
    }
}