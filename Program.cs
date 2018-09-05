using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirageLoto
{
    class Program
    {
        /// <summary>
        ///  Tirage de 7 chiffres aléatoires
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine(" ***************** Bienvenu dans jeu de tirage Loto ************** \n \n");
            Console.WriteLine("***** Les 7 chiffres tirés sont les suivants *** :\n");
            int[] SevenPulledNumber = new int[7];
            // SevenPulledNumber[0] = PulledNumber;
            for (int i = 0; i < SevenPulledNumber.Length; i++)
            {
                Random rand = new Random();
                int PulledNumber = rand.Next(1, 50);
                if (!SevenPulledNumber.Contains(PulledNumber))
                {
                    SevenPulledNumber[i] = PulledNumber;
                }
                else
                {
                    //PulledNumber = rand.Next(1, 50);
                    i--;
                }
            }
            AfficherTableau(SevenPulledNumber);
            Console.ReadLine();
        }
        static void AfficherTableau(int[] tab)

        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
    }
}