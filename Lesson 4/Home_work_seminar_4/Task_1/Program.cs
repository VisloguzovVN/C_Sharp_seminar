// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.Write("Введите целое число (для выхода введите 'q'):");
            string input = Console.ReadLine();

            if(input == "q")
                break;
        
            int number = 0;
            bool isValidNumber = int.TryParse(input, out number);

            if(isValidNumber && CalculateSumofDigits(number) % 2 == 0)
            break;
        }
    }

    static int CalculateSumofDigits(int number)
    {
        int sum = 0;
        number = Math.Abs(number);

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}