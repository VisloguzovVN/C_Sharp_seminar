//Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

public class HomeworkTask02
{
    public static void Main(string[] args)
    {
        string input = "sKlUrTG2JhGBvD!-";
        string result = input.ToLower();
        Console.WriteLine(result);
    }
}
