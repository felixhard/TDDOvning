using FizzBuzz;
using System.Security.Cryptography.X509Certificates;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {
        [DataRow(15)]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(1)]
        [TestMethod]
        public void När_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException(int randomNummer)
        {
            // Arrange


            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
            Assert.AreEqual("Fizz", result);
            Assert.AreEqual("Buzz", result);
            Assert.AreEqual(randomNummer.ToString(), result);

            // Testet kommer att bli grönt då ett NotImplementedException kastas
        }
    }
}