using System;

namespace Growth_of_a_Population
{
    class Program
    {
        static void Main(string[] args)
        {

            var totalAños = Arge.NbYear(1000, 2, 50, 1214);

            Console.WriteLine(totalAños);


        }
    }


    public class Arge
    {

        public static int NbYear(int p0, double percent, int aug, int p)
        {

            // Almacenar en variable dpuble el total del comienzo del año (double para calculo)
            double totalPoblacion = p0;
            // Almacenar en variable el numero de año (es el output)
            int output = 0;
            // Almacenar porcentaje convertido
            percent /= 100;

            // Hacer un for loop =>
            for (; totalPoblacion < p; ++output)
            {
                if (percent > 0)
                {
                    // Try some examples to see if there is a difference between "Convert.ToInt32" and a cast to int.
                    totalPoblacion += totalPoblacion * percent + aug;
                }
                else
                {
                    totalPoblacion += aug;
                }
            }

            return output;
        }
    }
}
