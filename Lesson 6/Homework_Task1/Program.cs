//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

public class HomeworkTask01
{
    public static void Main(string[] args)
    {
        char[,] charArray = new char[,] { { 'k', 'f' }, { 's', 'k' } };
        string result = CreateStringFromArray(charArray);
        Console.WriteLine(result);
    }
        public static string CreateStringFromArray(char[,] array)
        {
            string result = "";
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        result += array[i, j];
                    }
                }
                return result;
        }
}