using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8
{
    class Program
    {
        static void Main(string[] args)
        {
            string romain;
            
            Console.WriteLine("Donnez moi un nombre en chiffre romain");
            romain = Console.ReadLine();
            char[] arr = romain.ToCharArray();
            Console.WriteLine("Conversion en nombre: {0} ", Conversion(arr));
           
        }

        static int Conversion(char[] arr)
        {
            int nombre = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 'M':
                        nombre += 1000;
                        break;

                    case 'D':
                        nombre += 500;
                        break;

                    case 'C':
                        nombre += 100;
                        break;

                    case 'L':
                        nombre += 50;
                        break;

                    case 'X':
                        if (i != arr.Length-1)
                        {
                            if (arr[i + 1] == 'C')
                            {
                                nombre -= 10;
                            }
                            else
                            {
                                nombre += 10;
                            }
                        }
                        else
                        {
                            nombre += 10;
                        }
                        break;

                    case 'V':
                        nombre += 5;
                        break;

                    case 'I':
                        if (i != arr.Length-1)
                        {
                            if (arr[i + 1] == 'V')
                            {
                                nombre -= 1;
                            }

                            else if (arr[i + 1] == 'X')
                            {
                                nombre -= 1;
                            }


                            else
                            {
                                nombre += 1;
                            }
                        }
                        else
                        {
                            nombre += 1;
                        }
                        break;








                }
            }



            return nombre;
        }
    }
}
