using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of x");
            int x = int.Parse(Console.ReadLine());
            double factResult = 1;
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int a = i; a<=i; a++)
                {
                    factResult *= a;
                }
                result = result + (factResult / (Math.Pow(x, i)));
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
