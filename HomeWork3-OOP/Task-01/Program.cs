
class Program
{
    static void Main()
    {
        Engine engine = new Engine(250);
        Car car = new Car("BMW", engine);

        car.Start();
        car.Accelerate(60);
        car.ShowInfo();

    }
    class Engine
    {
        public int HorsePower { get; }

        public Engine(int horsePower)
        {
            HorsePower = horsePower;
        }

        public void Start()
        {
            WriteLine($"Engine with {HorsePower} HP started.");
        }
    }


    class Car
    {
        public string Brand { get; }
        private int Speed;
        private Engine engine;

        public Car(string brand, Engine engine)
        {
            Brand = brand;
            this.engine = engine;
        }
        public void Accelerate(int amount)
        {
            if (amount < 0)
            {
                WriteLine("Invalid acceleration!");
                return;
            }

            Speed += amount;
        }
        public void Start()
        {
            engine.Start();
            WriteLine($"{Brand} car started.");
        }
        public void ShowInfo()
        {
            WriteLine($"Car: {Brand}, Speed: {Speed}, HP: {engine.HorsePower}");
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
