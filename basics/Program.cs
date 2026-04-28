/* Learning C# Basics*/

int[] nums = [10, 20, 30, 40];
IEnumerable<int> new_nums = [.. nums, 50, 60];
Console.WriteLine($"{new_nums}");

struct Person
{
    String Name;
    int Age;
}

/*
var p = new Person { "smpl", 30 };
Console.WriteLine($"{p}");
*/

