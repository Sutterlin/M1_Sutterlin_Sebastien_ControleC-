using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr1, nbr2;
            Console.WriteLine("Ecrivez 2 entiers");
            nbr1 = int.Parse(Console.ReadLine());
            nbr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Le PGCD est {0}", PGCD(nbr1, nbr2));




        }

        static int PGCD(int nbr1, int nbr2)
        {
            while (nbr1 != nbr2)
            {
                if (nbr1 > nbr2)
                {
                    nbr1 = nbr1 - nbr2;
                }
                else
                {
                    nbr2 = nbr2 - nbr1;
                }
            }
            return nbr1;
        }
    }
}
