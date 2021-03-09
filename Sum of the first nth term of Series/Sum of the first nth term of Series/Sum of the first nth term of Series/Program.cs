using System;

namespace Sum_of_the_first_nth_term_of_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = NthSeries.seriesSum(0);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

    public class NthSeries
    {

        public static string seriesSum(int n)
        {

                decimal result = 0.00m;
                // Etinerar en nth
                for (var i = 1; i <= n; i++)
                {
                    result += 1.00m / (3.00m * i - 2.00m);
                    
                }

                string output = result.ToString("F");
                return output;


            // BEST SOLUTION
            //double ret = 0;
            //for (var i = 1; i <= n; i++)
            //{
            //    ret += 1f / (3 * i - 2);
            //}
            //return ret.ToString("0.00");

        }
    }
}
