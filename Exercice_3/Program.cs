using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nbrs = "placeholder";
            int i, nbr,resultat;
            resultat = 0;
            char[] tableau_char = new char[3];
            while (nbrs.Length != 3)
            {
                Console.WriteLine("Entrez un nombre");
           
                nbrs = Console.ReadLine();
            }
            tableau_char = nbrs.ToCharArray();
            for (i = 0; i < 3; i++)
            {
                nbr = (int)char.GetNumericValue(tableau_char[i]);
               resultat = resultat + (int)Math.Pow(nbr, 3);
               

            }

            if (resultat == int.Parse(nbrs))
            {
                Console.WriteLine("C'est un nombre d'armstrong !");
            }
            else
            {
                Console.WriteLine("Ce n'est pas un nombre d'armstrong");
            }
        }
    }
}
