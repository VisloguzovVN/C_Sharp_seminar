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
      foreach(double item in array)
            {
                if(item < minVal) 
                  minVal = item;
                if(item > maxVal) 
                  maxVal = item;
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
            array = new double[] {3.01, 3.01, 3.01, 3.01, 3.01, 3.01, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}