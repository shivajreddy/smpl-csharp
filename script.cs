namespace Script;


class Program
{
    static void Main()
    {
        Console.WriteLine("Hello wow");
        var p = new Person { Name = "shiva", age = 30 };
        Console.WriteLine($"{p.Name} {p.age}");
        string? s1 = "s1";
        Foo(s1);
        Foo(null);
        Foo(null);
        Foo(s1);
    }

    static void Foo(string? s)
    {
        Console.WriteLine($"{s} length: {s?.Length}");
    }
}

class Person
{
    public string? Name { get; set; }
    public int age;
}

