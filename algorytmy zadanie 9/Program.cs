using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę:");
        int liczba = Convert.ToInt32(Console.ReadLine());

        int odwrocona = OdwrocLiczbe(liczba);

        Console.WriteLine("Liczba po odwróceniu: " + odwrocona);
    }

    static int OdwrocLiczbe(int liczba)
    {
        int odwrocona = 0;

        while (liczba > 0)
        {
            int cyfra = liczba % 10;
            odwrocona = (odwrocona * 10) + cyfra;
            liczba /= 10;
        }

        return odwrocona;
    }
}
