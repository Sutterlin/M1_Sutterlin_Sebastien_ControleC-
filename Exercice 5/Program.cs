using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,j,k,l;
            int[] tab_premier = new int[10];
            bool premier = true;
            i = 2;
            j = 1;
            k = 0;
            l = 0;
            Console.WriteLine("Combien de nombres entiers voulez vous voir ?");
            n = int.Parse(Console.ReadLine());

            while(l < n)
            {

                i++;
                while((j-1) != i)
                {
                    
                    if ((i % j == 0) && (j!=1)  && (j!=i))
                    {
                        Console.WriteLine("Ce n'est pas un nombre premier");
                        premier = false;
                        break;
                    }
                    j++;  

                };
                if (premier == true)
                {
                    Console.WriteLine("c'est un nombre premier !!");
                    tab_premier[k] = i;
                    k++;
                    l++;

                }
                premier = true;
                j = 1;

                
            }

            for (k = 0; k < tab_premier.GetLength(0); k++)
            {
                Console.WriteLine(tab_premier[k]); //on affiche les nombres premiers dans un tableau.
            }

        }

       
    }
}
