namespace Task_01;

public class Utilities
{
    // Utilities is a Hellper Class for do all work ke tekrari hastan and clean code
    public string text;

    // Hellper method for print text in console and custom color and console clear
    public static void printTextAndSetCustomColor(string text)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{text}");
        Console.ResetColor();
    }

    // Hellper method for print in console and wait with continiu and clear all console
    public static void printAndReadKyeClear(string text)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{text} \n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.ResetColor();
        Console.Clear();
    }
}
