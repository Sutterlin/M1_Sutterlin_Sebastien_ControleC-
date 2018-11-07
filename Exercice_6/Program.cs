using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr;
            Console.WriteLine("Donnez moi un nombre entier");
            nbr = int.Parse(Console.ReadLine());
            // Console.WriteLine(EstPremier(nbr));
            generercouple(nbr);

           


        }

        




        static bool EstPremier(int nbr)
        {
            int i;
            
            bool premier = true;
            for(i = 2;i < nbr; i++)
            {

                if (nbr % i == 0)
                {
                    return false;
                }

                if (nbr == i)
                {
                    return true;
                }



            }

            return premier;








        }

        static void generercouple(int nbr)
        {
            int i, j;
            j = nbr;
            for (i = 1; i < nbr/2; i++)
            {
                j--;
                
                if ((EstPremier(i)) && (EstPremier(j))){
                    Console.WriteLine("{0} {1}", i, j);
                }

                

            }

        }








    }
}
