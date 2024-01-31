// 3. Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
//char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

int CountVowels(string input)
{
char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

int count = 0;
foreach (char c in input)
{
// Проверяем, является ли символ гласной буквой
if (Array.IndexOf(vowels, c) != -1)
{
count++;
}
}

return count;
}

Console.WriteLine("Введите строку из латинских букв в нижнем регистре:");
string inputString = Console.ReadLine();

int result = CountVowels(inputString);
Console.WriteLine($"Количество гласных букв: {result}");

