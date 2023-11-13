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
        public void FizzBuzzKalkylator_Kollar_Att_Expected_Är_Lika_Med_Actual(int randomNummer, string expectedResult)
        {
            // Arrange

            // Act
            string actualResult = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [DataRow(15, "FizzBuzz")]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(1, "1")]
        [TestMethod]
        public void FizzBuzzKalkylKonsol_Kollar_Att_Resultat_Skrivs_Ut_I_Konsol(int randomNummer, string expectedResult)
        {

            //Arrange
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var expected = expectedResult;

            //Act
            Kalkylator.FizzBuzzKalkylKonsol(randomNummer);
            var actual = stringWriter.ToString().Trim();

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }           
}