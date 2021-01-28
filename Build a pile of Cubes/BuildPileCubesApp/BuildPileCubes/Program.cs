using System;

namespace BuildPileCubes
{
    class Program
    {
        static void Main(string[] args)
        {

            long result = ASum.findNb(1071225);

            Console.WriteLine(result);


            Console.ReadLine();
        }
    }

    public class ASum
    {
        public static long findNb(long m)
        {
            long finalN = 0;
            long result = sumPowerUp(0, 0, ref finalN, m);

            if (result > m)
            {
                return -1;
            }

            return finalN;

        }

        public static long sumPowerUp(long n, long output, ref long count, long m)
        {
            double power = 3;

            if (output >= m) return output;

            count += 1;

            output += Convert.ToInt64(Math.Pow(n + 1, power));
            output = sumPowerUp(n + 1, output, ref count, m);

            return output;
        }
    }
}
