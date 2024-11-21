using System;

public class ArrayRange
{
    public static int CalculateRange(int[,] array)
    {
        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (int value in array)
        {
            if (value < min)
            {
                min = value;
            }
            if (value > max)
            {
                max = value;
            }
        }

        return max - min;
    }

    public static void Main()
    {
        int rows = 3;
        int cols = 3;
        int[,] array = new int[rows, cols];
        Random rand = new Random();

        // Wypełnianie tablicy losowymi liczbami
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rand.Next(1, 100); // Losowe liczby od 1 do 99
            }
        }

        // Wyświetlanie tablicy
        Console.WriteLine("Tablica:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int range = CalculateRange(array);
        Console.WriteLine("Zakres tablicy: " + range);
    }
}