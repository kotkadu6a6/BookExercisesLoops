using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N (N<20)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int a = i; counter< n-1; a++)
                {
                    Console.Write("{0,3}",a);
                    counter++;
                }
                Console.WriteLine();
                counter = 0;
            }
            Console.ReadLine();
           
        }
    }
}
