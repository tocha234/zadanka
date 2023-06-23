using System;

class Program
{
    static void Main(string[] args)
    {
        int[] tablica = { 8, 3, 9, 9, 9, 1, 7, 4, 6 }; 

        int najmniejszy = ZnajdzNajmniejszyElement(tablica);
        int najwiekszy = ZnajdzNajwiekszyElement(tablica);

        Console.WriteLine("Najmniejszy element: " + najmniejszy);
        Console.WriteLine("Największy element: " + najwiekszy);
    }

    static int ZnajdzNajmniejszyElement(int[] tablica)
    {
        int najmniejszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszy)
            {
                najmniejszy = tablica[i];
            }
        }

        return najmniejszy;
    }

    static int ZnajdzNajwiekszyElement(int[] tablica)
    {
        int najwiekszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] > najwiekszy)
            {
                najwiekszy = tablica[i];
            }
        }

        return najwiekszy;
    }
}
