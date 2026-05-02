namespace Script;

class Program
{
    static void Main()
    {
        var p1 = new PersonRecord("smpl", 30);
        Console.WriteLine(p1);

        // var p2 = new PersonClass() { Name = "smpl", Age = 30 };
        // var p3 = new PersonClass();
        var p4 = new PersonClass("smpl", 30);
        Console.WriteLine(p4);
    }
}

public record class PersonRecord(string Name, int Age);
public class PersonClass
{
    public string Name;
    public int Age;
    public PersonClass(string name, int age) { Name = name; Age = age; }
}
