// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
using System;
class Program
{
static void Main()
    {
        int size = 100;
        int[] numbers = new int[size]; 
        Random random = new Random(); 
        int evenCount = 0; 
        
        for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(100, 1000); 
                Console.Write(numbers[i] + ", "); 
                
                if (numbers[i] % 2 == 0)
                    {
                        evenCount++;
                    }
            }
            
            Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");
    }
}
