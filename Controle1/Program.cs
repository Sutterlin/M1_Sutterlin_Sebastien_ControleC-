using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle1
{
    class Program
    {
        static void Main(string[] args)
        {
            float nbr;
            double resultat;
            bool succes = false;
            while (succes == false)
            {
                Console.WriteLine("Entrez un réèl");
                if (float.TryParse(Console.ReadLine(), out nbr))
                {
                    succes = true;
                    resultat = (nbr > 0) ? nbr : (Math.Sqrt(nbr * nbr));
                    
                    
                    Console.WriteLine(resultat);
                }

                else
                {
                    Console.WriteLine("Donnez moi un réèl !!");
                }

            }

        }
    }
}
