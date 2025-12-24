using System;

class Program
{
    static void Main()
    {
        // string[] args
        // RunArgs(args);
        Person p = new();
        p.Name = "hadi";
        p.SetAge(12);
        p.sayHello();

    }

    class Car
    {
        public string Brand;

        private int Speed;

        public void Accelerate(int amount)
        {
            if (true)
            {
                
            }
        }

        public void SetSpeed(int value)
        {
            if (value < 0)
            {
                WrietLine("invalid speed values");
                return;
            }
            Speed = value ;
        }
        public int GetSpeed()
        {
            return Speed;
        }

    }






    static void RunArgs(string[] args)
    {
        string? name = null;
        int age = 0;

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "--helps")
            {
                WriteLine("Usage:");
                WriteLine("  --name <value>    User name");
                WriteLine("  --age <value>     User age\n");
                WriteLine("Example:");
                WriteLine("  dotnet run --name Ali --age 30");
                return;
            }

            if (args[i] == "--name" && i + 1 < args.Length)
            {
                name = args[i + 1];
                i++;
            }
            else if (args[i] == "--age" && i + 1 < args.Length)
            {
                age = int.Parse(args[i + 1]);
                i++;
            }
        }

        if (name == null || age == 0)
        {
            WriteLine("Error: name and age are required.");
            return;
        }

        WriteLine($"Hello {name}, you are {age} years old.");
    }

}
