using System;

namespace SquareEveryDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Kata.SquareDigits(9119);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

    public class Kata
    {
        public static int SquareDigits(int n)
        {
            string outputString = "";

            foreach (char ch in n.ToString())
            {
                var number = int.Parse(ch.ToString());
                number = (int)Math.Pow(number, 2);

                outputString += number.ToString();
            }

            var output = int.Parse(outputString);

            return output;
        }
    }
}
