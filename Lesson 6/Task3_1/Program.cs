// Метод для подсчета количества гласных букв в строке
class static int CountVowels(string input)
{
// Создаем массив с гласными буквами
char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

int count = 0;

// Проходим по каждому символу во введенной строке
for (int i = 0; i < input.Length; i++)
{
// Если символ является гласной, увеличиваем счетчик
if (Array.IndexOf(vowels, input[i]) != -1)
{
count++;
}
}

return count;
}
