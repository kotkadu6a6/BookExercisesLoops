using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of numbers in the sequnce: ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int currentNumber = new int();
            int previosNumber = 1;
            int beforePreviosNumber = 0;
            if (amount==1)
            {
                Console.WriteLine("0");
            }
            else if (amount==2)
            {
                Console.WriteLine("0, 1");
            }
            else if (amount>2)
            {
                Console.Write("0, 1 ");
                for (int i = 2; i < amount; i++)
                {
                    currentNumber = previosNumber + beforePreviosNumber;
                    Console.Write(", {0}",currentNumber);
                    beforePreviosNumber = previosNumber;
                    previosNumber = currentNumber;
                }
            }
            Console.ReadLine();
        }
    }
}
