using FizzBuzz;
using System.Security.Cryptography.X509Certificates;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {
        [DataRow(15, "FizzBuzz")]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(1, "1")]
        [TestMethod]
        //public void När_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException(int randomNummer, string expectedResult)
        //{
        //    // Arrange

        //    // Act
        //    string actualResult = Kalkylator.FizzBuzzKalkyl(randomNummer);

        //    // Assert
        //    Assert.AreEqual(actualResult, expectedResult);
        //}
        public void När_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException2(int randomNummer, string expectedResult)
        {
            // Arrange

            // Act
            Kalkylator.FizzBuzzKalkylKonsol(randomNummer);
            string actualResult = Console.ReadLine();

            // Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}