//Задача 2.2: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N
// с помощью рекурсии.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value of the number M:");
        int M = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Enter value of the number N:");
        int N = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Even numbers from {0} to {1}: ", M, N);
        PrintEvenNumbers(M, N);

        Console.WriteLine();
    }
    
    static void PrintEvenNumbers(int currentNumber, int N)
    {
        if(currentNumber > N)
            return;
        
        if(currentNumber % 2 == 0)
            Console.WriteLine(currentNumber);
        
        PrintEvenNumbers(currentNumber + 1, N);
    }
}

