using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = 0;
            BigInteger factorialDividend = 1;
            BigInteger factorialDivisor = 1;

            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 2 * n; i > n + 1; i--)
                {
                    factorialDividend = factorialDividend * i;
                }
                for (int i = n; i > 0; i--)
                {
                    factorialDivisor = factorialDivisor * i;
                }

                result = factorialDividend / factorialDivisor;
                Console.WriteLine(result);


            }
            Console.ReadLine();
        }
    }
}
