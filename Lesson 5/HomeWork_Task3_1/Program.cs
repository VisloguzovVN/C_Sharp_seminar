using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем прямоугольный двумерный массив
        int[,] array = new int[,]
        {
            {2, 7, 8},
            {3, 1, 5},
            {9, 6, 4}
        };

        // Инициализируем переменные для хранения индекса строки с наименьшей суммой и самой маленькой суммы
        int minSumIndex = 0;
        int minSum = int.MaxValue;

        // Проходим по каждой строке массива и считаем сумму элементов
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            
            // Если текущая сумма меньше минимальной, обновляем значения минимальной суммы и индекса
            if (sum < minSum)
            {
                minSum = sum;
                minSumIndex = i;
            }
        }

        // Выводим результаты
        Console.WriteLine("Строка с наименьшей суммой элементов: " + minSumIndex);
        Console.WriteLine("Сумма элементов этой строки: " + minSum);
    }
}
