namespace Script;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Foo.Host);

        string text = "-x123";
        if (int.TryParse(text, out int x)) Console.WriteLine(x + 100);

        int y;
        if (int.TryParse("10x", out y))
            Console.WriteLine(y);
        Console.WriteLine(y);
    }
}

static class Foo
{
    public static string Host { get; } = "woaw";
}
