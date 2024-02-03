//(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены 
//в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

public class HomeworkTask04
{
    public static void Main(string[] args)
    {
        string input = "Здравствуй Друг";
        string result = ReverseWords(input);
        Console.WriteLine(result);
    }
    public static string ReverseWords(string str)
    {
    string[] words = str.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
    }
}
