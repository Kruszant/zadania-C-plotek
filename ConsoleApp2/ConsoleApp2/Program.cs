﻿using System;

public class GeometricMean
{
    public static double CalculateGeometricMean(int[] array)
    {
        double product = 1.0;
        int n = array.Length;

        foreach (int value in array)
        {
            product *= value;
        }

        return Math.Pow(product, 1.0 / n);
    }

    public static void Main()
    {
        int size = 5;
        int[] array = new int[size];
        Random rand = new Random();

        // Wypełnianie tablicy losowymi liczbami
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(1, 100); // Losowe liczby od 1 do 99
        }

        // Wyświetlanie tablicy
        Console.WriteLine("Tablica:");
        foreach (int value in array)
        {
            Console.Write(value + "\t");
        }
        Console.WriteLine();

        double geometricMean = CalculateGeometricMean(array);
        Console.WriteLine("Średnia geometryczna: " + geometricMean);
    }
}