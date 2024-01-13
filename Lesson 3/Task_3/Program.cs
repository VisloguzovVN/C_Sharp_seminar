// 3. Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.


using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 3, 2, 4, 2, 3 };
        int[] result = new int[arr.Length / 2 + arr.Length % 2]; // создаем новый массив для записи результатов
        int j = 0;
        for (int i = 0; i < arr.Length - 1; i += 2) // проходим по исходному массиву с шагом 2
        {
            result[j] = arr[i] * arr[i + 1]; // вычисляем произведение текущего элемента и следующего элемента
            j++; // увеличиваем индекс нового массива
        }
        if (arr.Length % 2 != 0) // если длина исходного массива нечетная, то последний элемент не имеет пары
        {
            result[j] = arr[arr.Length - 1]; // записываем последний элемент в новый массив
        }
        Console.WriteLine(string.Join(" ", result)); // выводим результат в консоль
    }
}

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

int[] PairsNum(int[] arr)
{
    int size = arr.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_arr = new int[flex_size];

    for (int i = 0; i < size / 2; i++)
        new_arr[i] = arr[i] * arr[size - i - 1];

    if (size % 2 == 1)
        new_arr[flex_size - 1] = arr[size / 2];
    return new_arr;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
int[] arr_new = PairsNum(mass);
Print(arr_new);
int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};