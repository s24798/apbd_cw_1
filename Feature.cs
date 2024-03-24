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

    public static double Max(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Tablica liczb nie może być pusta ani null.");

        int max = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > max)
                max = number;
        }
            
        return max;
    }
}

