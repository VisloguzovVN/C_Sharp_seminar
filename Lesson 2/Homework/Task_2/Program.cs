Console.Write("Write X  ");
Console.Write("Write Y  ");
int X = int.Parse(Console.ReadLine()!);
int Y = int.Parse(Console.ReadLine()!);
if(X > 0 & Y > 0)
{
   Console.WriteLine("First sector"); 
}
else if(X < 0 & Y > 0)
{
    Console.WriteLine("Second sector");
}
else if(X < 0  & Y < 0)
{
    Console.WriteLine("Third sector");
}
else if(X > 0 & Y < 0)
{
    Console.WriteLine("Fourth sector");
}
else
{
    Console.WriteLine("A point on the coordinate axis");
}