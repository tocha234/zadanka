using System;

class Program
{
    static void Main(string[] args)
    {
        int[] tablica = GenerujTablice(10); // generowanie tablicy o rozmiarze 10
        WypiszTabliceOdTylu(tablica);
    }

    static int[] GenerujTablice(int rozmiar)
    {
        int[] tablica = new int[rozmiar];
        Random random = new Random();

        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = random.Next(100); // generowanie losowej wartości od 0 do 99
        }

        return tablica;
    }

    static void WypiszTabliceOdTylu(int[] tablica)
    {
        for (int i = tablica.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(tablica[i]);
        }
    }
}
