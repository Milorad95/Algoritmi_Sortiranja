using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmi_Sortiranja
{
    class Algoritam
    {
        public void SelectionSort(int[] niz)
        {
            // promeljiva koja ce cuvati vrednost clana niza
            int temp = 0;

            // promenjiva koja ce privremeno cuvati poziciju elementa
            int minIndex = 0;

            for (int i = 0; i < niz.Length; i++) // prolazak kroz niz
            {
                minIndex = i;

                for (int j = i + 1; j < niz.Length; j++) // 'j' dobija vrednost indeksa 'i' uvecan za 1
                {
                    if (niz[j] < niz[minIndex]) // proveravamo da li je clan sa indeksom 'j' manji od clana sa indeksom minIndex
                    {
                        minIndex = j; // minIndex dobija vrednost 'j', time cuvamo indeks manjeg clana niza 
                    }
                }

                if (i != minIndex) // proveravamo da li se vrednost minIndex promenila, ako jeste znaci da postoji manji clan u nizu
                {
                    temp = niz[i]; // promenjivoj temp je dodeljena vrednost sa indeksom 'i'
                    niz[i] = niz[minIndex]; // na poziciju 'i' upisujemo vrednost sa indeksom minIndex
                    niz[minIndex] = temp; // na pozicijiu minIndex postavljamo vrednost iz temp 
                }
            }
        }

        public void BublleSort(int[] niz)
        {
            int temp; // promenjiva za cuvanje vrednosti clana niza

            for (int i = 0; i < niz.Length; i++)    // prolazak kroz niz
            {
                for (int j = i + 1; j < niz.Length; j++)    // 'j' dobija vrednost 'i' uvecana za 1
                {
                    if (niz[i] > niz[j])    // proveravamo da li clan sa indeksom 'i' veci od clana sa indeksom 'j'
                    {
                        temp = niz[i];  // temp dobija vrednost clana niza sa indekom i 
                        niz[i] = niz[j];    // clan sa indekom 'j' upisujemo na mesto sa indeksom 'i'
                        niz[j] = temp;  // na poziciju sa indekom 'j' upisujemo vrednost iz promeljive temp
                    }
                }
            }
        }

        public void stampajNiz(int[] niz)
        {
            foreach (var clan in niz)
            {
                Console.Write(clan + " ");
            }
            Console.WriteLine();
        }
    }
}
