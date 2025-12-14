using System;
using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int max = 0;
        double average;

        ArrayAnalyzer analyzer = new ArrayAnalyzer();
        analyzer.AnalyzeArray(numbers, ref max, out average);

        Console.WriteLine("\n--- Result ---");
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Average: {average}");
    }
}


class ArrayAnalyzer
{
    public void AnalyzeArray(int[] array, ref int max, out double average)
    {
        // اگر آرایه خالی باشد
        if (array.Length == 0)
        {
            max = 0;
            average = 0.0;
            return;
        }

        int sum = 0;
        max = array[0]; // مقدار اولیه max

        foreach (int number in array)
        {
            if (number > max)
                max = number;

            sum += number;
        }

        average = (double)sum / array.Length;
    }
}
