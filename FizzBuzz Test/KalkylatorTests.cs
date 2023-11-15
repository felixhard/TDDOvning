using FizzBuzz;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

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

        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "Fizz")]
        [DataRow(4, "4")]
        [DataRow(5, "Buzz")]
        [DataRow(6, "Fizz")]
        [DataRow(10, "Buzz")]
        [DataRow(11, "11")]
        [DataRow(15, "FizzBuzz")]
        public void FizzBuzzKalkylKonsol_Kollar_Att_Resultat_Skrivs_Ut_I_Konsol(int randomNummer, string expectedResult)
        {

            //Arrange
            

            //Act
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            Kalkylator.FizzBuzzKalkylKonsol(randomNummer);
            var actual = stringWriter.ToString().Trim();

            // Assert
            Assert.AreEqual(expectedResult, actual);

        }

        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "Fizz")]
        [DataRow(4, "4")]
        [DataRow(5, "Buzz")]
        [DataRow(6, "Fizz")]
        [DataRow(10, "Buzz")]
        [DataRow(11, "11")]
        [DataRow(15, "FizzBuzz")]
        public void FizzBuzzKalkylInput_Ska_Skriva_Nummer(int inputNummer, string expectedOutput)
        {
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                // Act
                Kalkylator.FizzBuzzInput(inputNummer.ToString());
                var actualOutput = stringWriter.ToString().Trim();

                // Assert
                Assert.AreEqual(expectedOutput, actualOutput);
            }
        }
    }
}