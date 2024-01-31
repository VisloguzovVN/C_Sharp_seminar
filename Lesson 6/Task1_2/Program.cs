using System;

class MainClass {
public static void Main (string[] args) {
// Запрос элементов массива на ввод от пользователя
Console.WriteLine("Введите элементы массива через пробел:");
string input = Console.ReadLine()!;

// Разделение введенных элементов на массив строк
string[] inputArray = input.Split(' ');

// Создание массива символов на основе введенных элементов
char[] charArray = new char[inputArray.Length];

// Преобразование введенных элементов в массив символов
for (int i = 0; i < inputArray.Length; i++) {
charArray[i] = Convert.ToChar(inputArray[i]);
}

// Инициализация пустой строки
string result = "";

// Преобразование массива символов в строку
foreach (char c in charArray) {
result += c;
}

// Вывод результата
Console.WriteLine(result);
}
}