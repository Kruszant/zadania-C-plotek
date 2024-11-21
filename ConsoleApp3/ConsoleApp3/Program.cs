using System;

public class CustomArray
{
    public static int[,] GenerateArray(int rows, int cols)
    {
        int[,] array = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == j)
                {
                    array[i, j] = 1; // Główna przekątna
                }
                else if (i > j)
                {
                    array[i, j] = 0; // Pod główną przekątną
                }
                else
                {
                    // Powyżej głównej przekątnej - szachownica
                    array[i, j] = (i + j+1) % 2;
                }
            }
        }

        return array;
    }

    public static void Main()
    {
        Console.WriteLine("Podaj liczbę wierszy:");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj liczbę kolumn:");
        int cols = int.Parse(Console.ReadLine());

        int[,] array = GenerateArray(rows, cols);

        // Wyświetlanie tablicy
        Console.WriteLine("Wygenerowana tablica:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}