using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] numbers = new int[,] {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        int x = 2;
        int y = 2;

        int numRows = numbers.GetLength(0);
        int numColumns = numbers.GetLength(1);

        if (x < 1 || x > numRows)
        {
            Console.WriteLine("Позиция по рядам выходит за пределы массива");
        }
        else if (y < 1 || y > numColumns)
        {
            Console.WriteLine("Позиция по колонкам выходит за пределы массива");
        }
        else
        {
            int value = numbers[x - 1, y - 1];
            Console.WriteLine("Значение элемента: " + value);
        }
    }
}
