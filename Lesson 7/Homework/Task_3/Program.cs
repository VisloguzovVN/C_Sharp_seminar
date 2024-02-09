//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 10, 13, 4, 145, 34, 100, 78 };
        PrintArrayReverse(array, array.Length - 1);
    }

    public static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayReverse(array, index - 1);
        }
    }
}
