using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Donnez moi une phrase");
            string phrase = Console.ReadLine();
            int taille = phrase.Length;
            string phrase_se = Compresser(phrase);
            Console.WriteLine(Inverser1(phrase_se));
            Console.WriteLine(Inverser2(phrase_se));






        }

        static string Compresser(string phrase)
        {
            string phrase_se = "";
            foreach (char c in phrase){
                if (c != ' ')
                {
                    phrase_se += c;
                }

            }
            
            





            return phrase_se;
        }


        static char[] Inverser1(string phrase)
        {
            
            int taille = phrase.Length;
            int j = taille-1;
            
            char[] arr;
            char[] phrase_i = new char[taille];
            arr = phrase.ToCharArray();

            for (int i = 0; i < phrase.Length; i++)
            {
                
                    
                    phrase_i[j] = arr[i];
                    j--;
                
            }

            return phrase_i;
        }

        static string Inverser2(string phrase)
        {
            string phrase_i = "";
            char[] arr;
            arr = phrase.ToCharArray();
            for(int i=0; i < phrase.Length; i++)
            {
                phrase_i += arr[(phrase.Length-1) - i];
            }



            







            return phrase_i;
        }









    }
}
