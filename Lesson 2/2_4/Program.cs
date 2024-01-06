int a = int.Parse(Console.ReadLine()!);
if (a < 100)
Console.WriteLine("No");
else
{
    Console.WriteLine("Yes " + a / 100 % 10);
    }