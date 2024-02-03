//Задайте произвольную строку. Выясните, является ли она палиндромом.

public class HomeworkTask03
{
public static void Main(string[] args)
    {
    string input = "рвал дед лавр";
    bool isPalindrome = IsPalindrome(input);
    Console.WriteLine(isPalindrome ? "Палиндром" : "Не палиндром");
    }
    public static bool IsPalindrome(string str)
    {
        string normalized = new
        string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    return normalized.SequenceEqual(normalized.Reverse());
    }
}