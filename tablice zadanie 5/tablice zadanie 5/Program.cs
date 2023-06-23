public class SelectionSort
{
    public static void Sort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
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

        SelectionSort.Sort(array);

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
