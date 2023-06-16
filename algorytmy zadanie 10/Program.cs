using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę naturalną o co najmniej 3 cyfrach:");
        int liczba = Convert.ToInt32(Console.ReadLine());

        if (liczba < 100)
        {
            Console.WriteLine("Podana liczba ma mniej niż 3 cyfry.");
            return;
        }

        Console.WriteLine("Poszczególne cyfry liczby:");

        WypiszCyfry(liczba);
    }

    static void WypiszCyfry(int liczba)
    {
        string liczbaJakoTekst = liczba.ToString();

        foreach (char cyfra in liczbaJakoTekst)
        {
            Console.WriteLine(cyfra);
        }
    }
}
