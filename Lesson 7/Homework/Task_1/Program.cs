using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number M:");
        int M = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter number N:");
        int N = int.Parse(Console.ReadLine()!);

        PrintNumbers(M, N);

        Console.ReadLine();
    }

    static void PrintNumbers(int start, int end)
    {
        if (start > end)
        {
            return;
        }

        Console.WriteLine(start);
        PrintNumbers(start + 1, end);
    }
}
