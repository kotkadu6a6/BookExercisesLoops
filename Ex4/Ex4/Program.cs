using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                switch (i)
                {
                    case 1:                     
                        for (int card = 1; card <= 13; card++)
                        {
                            Console.Write("spades of ");
                            if (card == 11)
                            {
                                Console.WriteLine("Jack");
                            }
                            else if (card == 12)
                            {
                                Console.WriteLine("Queen");
                            }
                            else if (card == 13)
                            {
                                Console.WriteLine("King");
                            }
                            else if (card == 1)
                            {
                                Console.WriteLine("Ace");
                            }
                            else
                            {
                                Console.WriteLine(card);
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        
                        for (int card = 1; card <= 13; card++)
                        {
                            Console.Write("hearts of ");
                            if (card == 11)
                            {
                                Console.WriteLine("Jack");
                            }
                            else if (card == 12)
                            {
                                Console.WriteLine("Queen");
                            }
                            else if (card == 13)
                            {
                                Console.WriteLine("King");
                            }
                            else if (card == 1)
                            {
                                Console.WriteLine("Ace");
                            }
                            else
                            {
                                Console.WriteLine(card);
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                       
                        for (int card = 1; card <= 13; card++)
                        {
                            Console.Write("diamonds of  of ");
                            if (card == 11)
                            {
                                Console.WriteLine("Jack");
                            }
                            else if (card == 12)
                            {
                                Console.WriteLine("Queen");
                            }
                            else if (card == 13)
                            {
                                Console.WriteLine("King");
                            }
                            else if (card == 1)
                            {
                                Console.WriteLine("Ace");
                            }
                            else
                            {
                                Console.WriteLine(card);
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                       
                        for (int card = 1; card <= 13; card++)
                        {
                            Console.Write("clubs of ");
                            if (card == 11)
                            {
                                Console.WriteLine("Jack");
                            }
                            else if (card == 12)
                            {
                                Console.WriteLine("Queen");
                            }
                            else if (card == 13)
                            {
                                Console.WriteLine("King");
                            }
                            else if (card == 1)
                            {
                                Console.WriteLine("Ace");
                            }
                            else
                            {
                                Console.WriteLine(card);
                            }
                        }
                        break;

                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
