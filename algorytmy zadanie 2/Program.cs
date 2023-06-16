using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę wyrazów ciągu Fibonacciego do wygenerowania:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ciąg Fibonacciego:");

        for (int i = 0; i < n; i++)
        {
            int wynik = Fibonacci(i);
            Console.Write(wynik + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
