using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,resultat,resultat2;
            Console.WriteLine("Soit l'équation Ax² + bx + c. Donnez moi une valeur pour...");
            Console.WriteLine("a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("c");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Votre équation: {0} X² + {1} X + {2}", a, b, c);
            Console.WriteLine("Votre delta: {0}",Delta(a,b,c));
            double delta = Delta(a, b, c);
            resultat = Calcul_x(delta, a, b, c, out resultat2);
            if (resultat2 != 0){
                Console.WriteLine("La solution 1 est: {0}", resultat);
                Console.WriteLine("La solution 2 est {0}", resultat2);
            }
            else if (resultat == 0)
            {
                
                Console.WriteLine("Pas de solution");



            }
            else
            {
                Console.WriteLine("La solution est: {0}", resultat);
            }
            
       













        }

        static double Delta(double a,double b, double c)
        {
            double delta;
            delta = b * b - (4 * a * c);
            return delta;
            




        }

        static double Calcul_x(double Delta, double a, double b, double c,out double resultat2)
        {

            double resultat;
            
            if (Delta > 0){
                Console.WriteLine("Il y a deux solutions");
                resultat2 = (-b - Math.Sqrt(Delta)) /( 2 * a);
                resultat = (-b + Math.Sqrt(Delta)) / (2 * a);
                return resultat;

            }

            else if (Delta ==0)
            {
                resultat = -b / (2 * a);
                resultat2 = 0;
                return resultat;



            }

            else
            {
                resultat2 = 0;
                resultat = 0;
                return resultat;





            }














        }














    }
}
