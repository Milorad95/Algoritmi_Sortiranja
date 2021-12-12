using System;

namespace Algoritmi_Sortiranja
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] niz = new int[10];

            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = rnd.Next(1, 50);
            }

            var selectionSort = new Algoritam();

            Console.WriteLine("---------- Selection sort ----------");
            Console.WriteLine();
            Console.WriteLine("Clanovi niza pre sortiranja:");
            Console.WriteLine();
            selectionSort.stampajNiz(niz);

            Console.WriteLine();
            
            Console.WriteLine("Clanovi niza nakon sortiranja:");
            Console.WriteLine();
            selectionSort.SelectionSort(niz);
            selectionSort.stampajNiz(niz);
            
            Console.WriteLine();

            int[] niz1 = new int[10];

            for (int i = 0; i < niz1.Length; i++)
            {
                niz1[i] = rnd.Next(1, 50);
            }

            Console.WriteLine("---------- Bublle sort ----------");
            Console.WriteLine();
            Console.WriteLine("Clanovi niza pre sortiranja:");
            Console.WriteLine();
            selectionSort.stampajNiz(niz1);

            Console.WriteLine();

            Console.WriteLine("Clanovi niza nakon sortiranja:");
            Console.WriteLine();
            selectionSort.BublleSort(niz1);
            selectionSort.stampajNiz(niz1);

            Console.ReadLine();
        }
    }
}
