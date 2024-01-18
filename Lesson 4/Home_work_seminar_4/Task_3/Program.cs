// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

using System;
class Program
{
    static void Main()
    {
        int[] numbers = {7, 1, 3, 2, 6, 4, 8, 5, 9}; 
        int temp;
        
        Console.Write("Одномерный массив для реверса: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            temp = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = temp;
        }
        Console.Write("\nПеревернутый массив: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
         }
    }
}