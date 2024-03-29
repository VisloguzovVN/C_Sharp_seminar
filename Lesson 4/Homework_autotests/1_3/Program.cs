﻿//Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.

using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
    
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        double minVal = numbers[0];
            foreach(double item in numbers) 
            {
                if(item < minVal) 
                minVal = item;
            }
            return minVal;
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        double maxVal = numbers[0];
        foreach(double item in numbers)
        {
            if(item > maxVal)
            maxVal = item;
        }
        return maxVal;
    }
    
    
    
    public static void PrintResult(double[] array)
    {
            
            double maxVal = array[0];
            double minVal = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > maxVal)
                maxVal = array[i];
                
                if (array[i] <= minVal)
                minVal = array[i];
                
            }


            double dif = maxVal - minVal;
      Console.WriteLine(dif);
    }
}


//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new double[] {-3.01, 3.01, 3.01, 3.01, 3.01, 3.01, 3.01}; // Создание массива
            //{3.01, 3.01, 3.01, 3.01, 3.01, 3.01, 3.01} 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}