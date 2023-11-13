using System.Text.RegularExpressions;

namespace FizzBuzz
{
    public class Kalkylator
    {
        public static string FizzBuzzKalkyl(int nummer)
        {
            if (nummer % 3 == 0 && nummer % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (nummer % 3 == 0)
            {
                return "Fizz";
            }
            else if (nummer % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return nummer.ToString();
            }
        }
        public static void Konsollogg(string message)
        {
            Console.WriteLine(message);
        }
        public static void FizzBuzzKalkylKonsol(int nummer)
        {
            if (nummer % 3 == 0 && nummer % 5 == 0)
            {
                Konsollogg("FizzBuzz");
            }
            else if (nummer % 3 == 0)
            {
                Konsollogg("Fizz");
            }
            else if (nummer % 5 == 0)
            {
                Konsollogg("Buzz");
            }
            else
            {
                Konsollogg(nummer.ToString());
            }
        }
    }
}