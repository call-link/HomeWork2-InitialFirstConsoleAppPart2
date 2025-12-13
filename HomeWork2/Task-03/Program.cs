using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        // enter numbers
        Console.Write("[ Wellcome to Task 03 - ref&out] \n");
        Console.Write("Enter first number: ");
        int intNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int refNumber = int.Parse(Console.ReadLine());
        int outNumber;

        // show before numbers 
        showBefore(intNumber, refNumber);

        // instance of Statistics
        Statistics stats = new Statistics();
        stats.AnalyzeNumbers(intNumber, ref refNumber, out outNumber);

        // show after numbers
        showAfter(intNumber, refNumber, outNumber);

    }

    static void showBefore(int intNumber, int refNumber)
    {
        Console.Clear();
        Console.WriteLine("--- Before ---");
        Console.WriteLine($"(a) - First number  : {intNumber}");
        Console.WriteLine($"(b) - Second number : {refNumber}");
        Console.WriteLine($"(c) - End number : null");
    }
    static void showAfter(int intNumber, int refNumber, int outNumber)
    {
        Console.WriteLine("\n --- After ---");
        Console.WriteLine($"(a) - First number : {intNumber} (Call by value)");
        Console.WriteLine($"(b) - Second number : {refNumber} (Call by refrence)");
        Console.WriteLine($"(c) - End number : {outNumber} (Call by refrence)");
    }
}



class Statistics
{
    public void AnalyzeNumbers(int a, ref int b, out int c)
    {
        c = a + b;
        b = b * b;
    }
}


