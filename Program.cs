using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMoins
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random rand = new System.Random();
            int Intrandom = rand.Next(1, 100);
            Console.WriteLine("Let's start");
            int NumberChoosen = 0;
            Console.WriteLine("Guess the fired number");
            bool Over = false;
            int i = 0;
            do
            {
                i++; 
                string ChooseNumber = Console.ReadLine();
                if (int.TryParse(ChooseNumber, out NumberChoosen))
                {
                    if (NumberChoosen < Intrandom)
                    {
                        Console.WriteLine("You are too low");
                        Console.WriteLine("Please choose another one");
                    }
                    else if (NumberChoosen > Intrandom && NumberChoosen <100)
                    {
                        Console.WriteLine("You are too High");
                        Console.WriteLine("Please choose another one");
                    }
                    else if (NumberChoosen == Intrandom)
                    {
                        Console.WriteLine("Congraturations, you win !!, You used {0} times to get the good result", i);
                        Over = true;
                    }

                    else if (NumberChoosen >= 100)
                    {
                        Console.WriteLine("Please enter the number between 1 and 100");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter the number between 1 and 100");
                }
            } while (!Over);
            Console.ReadLine();
        }

    }
}
