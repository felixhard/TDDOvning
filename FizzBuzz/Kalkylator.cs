using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace FizzBuzz
{
    public class Kalkylator
    {
        //KRAV 1
        public static string FizzBuzzKalkyl(int nummer)
        {
            switch (nummer)
            {
                case var n when n % 3 == 0 && n % 5 == 0:
                    return "FizzBuzz";
                case var n when n % 3 == 0:
                    return "Fizz";
                case var n when n % 5 == 0:
                    return "Buzz";
                default:
                    return nummer.ToString();
            }
        }

        //KRAV 2
        public static void FizzBuzzKalkylKonsol(int nummer)
        {
            Console.WriteLine(FizzBuzzKalkyl(nummer));
        }

        //KRAV 3
        public static void FizzBuzzInput(string inputNummer)
        {
            if (int.TryParse(inputNummer, out int nummer))
                {
                FizzBuzzKalkylKonsol(nummer);
            }
            else
            {
                throw new ArgumentException($"{inputNummer} är inte ett nummer");
            }
        }
    }
}