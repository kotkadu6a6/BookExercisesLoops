using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of the second number");
            int b = int.Parse(Console.ReadLine());
            while (a!=b)
            {
                if (a>b)
                {
                    a = a - b;
                }
                else if (b>a)
                {
                    b = b - a;
                }
            }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
