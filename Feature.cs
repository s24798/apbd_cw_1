using System;

public class Feature
{
    public static double Average(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Tablica liczb nie może być pusta ani null.");

        int sum = 0;
        foreach (int number in numbers)
            sum += number;

        return (double)sum / numbers.Length;
    }
}

