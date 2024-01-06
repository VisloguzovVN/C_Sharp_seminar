int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a % b == 0)
Console.WriteLine("Yes");
else
{
    Console.WriteLine("No " + a % b);
    }