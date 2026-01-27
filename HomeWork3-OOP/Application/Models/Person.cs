namespace Application;

public class Person
{
    public string Name { get; set; }

    public void sayHello()
    {
        WriteLine($"Hello {Name}");
    }
}
