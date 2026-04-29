using System.Globalization;

using Mat = System.Math;

namespace Script;

class Program
{
    static void Main()
    {
        Console.WriteLine("hello there");
        var p = new Person { Name = "smpl", age = 30 };
        p.Greet();
        Mat.Max(10, 20);
    }
}

class Person
{
    public string? Name { get; set; }
    public int age;

    public void Greet()
    {
        var culture = CultureInfo.CurrentCulture;
        var greeting = $"Hello, {Name}! Culture: {culture.Name}";
        Console.WriteLine(greeting);
    }
}

