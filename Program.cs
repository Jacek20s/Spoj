using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polowa();
            //LiczbyPierwsze();
            Console.ReadKey();
        }

        private static void LiczbyPierwsze()
        {
            int a = int.Parse(Console.ReadLine());
            int[] lista = new int[a];
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                lista[i] = b;
            }

            for (int j = 0; j < a; j++)
            {
                int m = 0;



                if (lista[j] < 2)
                {
                    Console.WriteLine("NIE");

                }
                else
                {
                    for (int k = 2; k * k <= lista[j]; k++)
                    {
                        if (lista[j] % k == 0)
                        {
                            Console.WriteLine("NIE");
                            m = 1;
                            break;

                        }
                    }

                    if (m == 0)
                    {
                        Console.WriteLine("TAK");
                    }

                }

            }
        }

        private static void Polowa()
        {
            int a = int.Parse(Console.ReadLine());
            string b;
            int c;
            string[] tablica = new string[a];

            for (int i = 0; i < a; i++)
            {
                b = Console.ReadLine();
                c = b.Length / 2;
                tablica[i] = b.Substring(0, c);
            }
            for (int j = 0; j < tablica.Length; j++)
            {
                Console.WriteLine(tablica[j]);
            }
        }
    }
}
