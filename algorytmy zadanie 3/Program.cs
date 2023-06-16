using System;

class Program
{
    static void Main()
    {
        int n, k;
        do
        {
            Console.WriteLine("Podaj liczbę n (większą lub równą 5):");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n < 5);

        do
        {
            Console.WriteLine("Podaj liczbę k (większą lub równą 5):");
            k = Convert.ToInt32(Console.ReadLine());
        } while (k < 5);

        int m = ObliczM(n, k);
        Console.WriteLine("Wartość m = " + m);
    }

    static int ObliczM(int n, int k)
    {
        int faktorialN = ObliczFaktorial(n);
        int faktorialK = ObliczFaktorial(k);

        int m = (faktorialN - faktorialK) / faktorialK;
        return m;
    }

    static int ObliczFaktorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            int faktorial = 1;
            for (int i = 2; i <= number; i++)
            {
                faktorial *= i;
            }
            return faktorial;
        }
    }
}
