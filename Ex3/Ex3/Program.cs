using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter the amount of numbers");
            int amount = int.Parse(Console.ReadLine());
            int large = Int32.MinValue;
            int small = Int32.MaxValue;
            for (int i = 1; i <= amount; i++)
            {
                Console.WriteLine("Enter a number:");
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum>large)
                {
                    large = currentNum;
                }
                else if (currentNum<small)
                {
                    small = currentNum;
                }
            }
            Console.WriteLine("The smallest number is {0} na the largest is {1}",small,large);
            Console.ReadLine();
        }
    }
}
