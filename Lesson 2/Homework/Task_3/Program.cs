Console.Write("Write number from the segment [10, 99]  ");
int X = int.Parse(Console.ReadLine()!);
int a = X / 10;
int b = X % 10;
if(a >= b)
{
    Console.WriteLine(a);
}
else 
{
    Console.WriteLine(b);
}