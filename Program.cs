using System;

namespace Spoj
{
    class Program
    {

        static void Main(string[] args)
        {
            //Polowa();
            //LiczbyPierwsze();
            //DwieCyfrySilni();

            Console.ReadKey();
        }

        private static void DwieCyfrySilni()
        {
            int b = int.Parse(Console.ReadLine());

            int a;
            int silnia = 1;
            string zsilnia;
            char[] jednostki = new char[b];
            char[] dziesiatki = new char[b];

            for (int i = 0; i < b; i++)
            {
                a = int.Parse(Console.ReadLine());

                for (int k = a; k > 1; k--)
                {
                    silnia *= k;
                }

                zsilnia = silnia.ToString();
                jednostki[i] = zsilnia[zsilnia.Length - 1];
                if (silnia > 10)
                {
                    dziesiatki[i] = zsilnia[zsilnia.Length - 2];
                }
                else
                {
                    dziesiatki[i] = '0';
                }

            }
            for (int j = 0; j < b; j++)
            {
                Console.WriteLine(dziesiatki[j] + " " + jednostki[j]);
            }
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
