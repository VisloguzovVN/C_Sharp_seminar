using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
 
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    
    public class Task_01
    {

        public const int MIN = 1;
        public const int MAX = 100;

        public const int minRange = 10;
        public const int maxRange = 90;

       public static void Main(string[] args) 
       {
        System.Console.Write("Введите размерность генерируемого массива: ");

        int arraySize = GetArraySizeFromConsole();
        while (arraySize < 0) 
        {
            arraySize = GetArraySizeFromConsole();
        }

        int[] array = GetArrayWithRandomValue(arraySize);

        System.Console.WriteLine("Оригинальный массив:");
        System.Console.WriteLine(PrintArray(numbers));

        System.Console.WriteLine($"Количество элементов входящих в диапазон от {minRange} до {maxRange}:");
        System.Console.WriteLine(CountElementInRange(minRange, maxRange, numbers));
       }
       
        public static int GetArraySizeFromConsole() 
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            } 
            catch (Exception)
                {
                System.Console.WriteLine("Введеное значение не ядляется числом. Попробуйте снова.");
                }
            return -1;
        }
        public static int[] GetArrayWithRandomValue(int size) 
        {
            int[] array = new int[size];
            for(int i = 0; i < size; i++) 
            {
                array[i] = new Random().Next(MIN, MAX);
            }
            return array;

    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
         //Введите сюда свое решение
          int count = 0;
            foreach(int item in numbers) 
            {
                if(minRange <= item & item <= maxRange) count++;
            }
            return count;
    }
    
    public static void PrintResult(int[] array)
    {
        
          //Введите сюда свое решение
           string result = "";
            foreach(int item in array) 
            {
                result = result + item + " ";
            }
            return result;

    }
        }
    

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}
    }