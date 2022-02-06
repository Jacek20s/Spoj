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
            Console.ReadKey();
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
