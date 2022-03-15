using System;
using System.Collections.Generic;

namespace Spoj
{
    class Program
    {

        static void Main(string[] args)
        {
            //Polowa();
            //LiczbyPierwsze();
            //DwieCyfrySilni();
            //ParzysteNieparzyste();
            //Suma();

            Console.ReadKey();
        }

        private static void Suma()
        {
            int a;
            string b;
            List<int> lista = new List<int>();
            do
            {

                b = Console.ReadLine();
                if (b != string.Empty)
                {
                    a = int.Parse(b);
                    lista.Add(a);
                }


            } while (b != string.Empty);


            for (int i = 0; i < lista.Count; i++)
            {
                int c = lista.Count;
                int wynik = 0;
                int j = 0;
                do
                {

                    wynik += lista[j];

                    j++; ;
                } while (j <= i);
                Console.WriteLine(wynik);
            }
        }

        private static void ParzysteNieparzyste()
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                int[] tab = new int[b];
                int[] tab1 = new int[b];
                int c = 0;
                for (int j = 0; j < b; j++)
                {
                    tab[j] = int.Parse(Console.ReadLine());


                }
                for (int l = 0; l < b; l++)
                {

                    if (tab[l] % 2 == 0)
                    {
                        tab1[c] = tab[l];
                        c++;
                    }

                }
                for (int m = 0; m < b; m++)
                {

                    if (tab[m] % 2 != 0)
                    {
                        tab1[c] = tab[m];
                        c++;
                    }

                }

                for (int k = 0; k < b - 1; k++)
                {
                    Console.Write(tab1[k] + " ");


                }
                Console.WriteLine(tab1[b - 1]);


            }
        }

        public static int Silnia(int n)
        {
            int silnia;
            if (n < 2)
            {
                return silnia = 1;
            }

            silnia = n * Silnia(n - 1);

            return silnia;

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


                silnia = Silnia(a);
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
