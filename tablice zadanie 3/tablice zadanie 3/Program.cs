using System;

class Program
{
    static void Main(string[] args)
    {
        int[] tablica = { 5, 2, 8, 1, 9, 3, 7, 4, 6 }; 

        SortowanieBabelkowe(tablica);

        Console.WriteLine("Posortowana tablica:");
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }
    }

    static void SortowanieBabelkowe(int[] tablica)
    {
        int n = tablica.Length;
        bool zamiana;

        for (int i = 0; i < n - 1; i++)
        {
            zamiana = false;

            for (int j = 0; j < n - 1 - i; j++)
            {
                if (tablica[j] > tablica[j + 1])
                {
                    ZamienElementy(tablica, j, j + 1);
                    zamiana = true;
                }
            }

            if (!zamiana)
            {
                break;
            }
        }
    }

    static void ZamienElementy(int[] tablica, int indeks1, int indeks2)
    {
        int temp = tablica[indeks1];
        tablica[indeks1] = tablica[indeks2];
        tablica[indeks2] = temp;
    }
}
