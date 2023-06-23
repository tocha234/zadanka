public class InsertionSort
{
    public static void Sort(int[] array)
    {
        int n = array.Length;

        for (int i = 1; i < n; i++)
        {
            int currentValue = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > currentValue)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = currentValue;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 2, 4, 6, 1, 3 };

        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(array);

        InsertionSort.Sort(array);

        Console.WriteLine("Tablica po sortowaniu:");
        PrintArray(array);
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }
}
