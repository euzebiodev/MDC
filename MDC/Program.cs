using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            Char delimiter = ' ';
            long numeroDeLinhas = 0;
            long a = 0, b = 0;

            if ((line = Console.ReadLine()) != null)
            {
                numeroDeLinhas = Convert.ToInt64(line);
            }

            while ((line = Console.ReadLine()) != null)
            {
                String[] substrings = line.Split(delimiter);
                a = Convert.ToInt64(substrings[0]);
                b = Convert.ToInt64(substrings[1]);
                Console.WriteLine(Program.MDC(a, b));
                numeroDeLinhas--;

                if (numeroDeLinhas == 0)
                {
                    break;
                }

            }

            Console.WriteLine("Fim da entrada");
            Console.ReadKey();
        }

        static long MDC(long a, long b)
        {
            while (b != 0)
            {
                long r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}
