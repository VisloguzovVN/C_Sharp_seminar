// 2. На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.

// Метод строки ToCharArray() не использовать.

char[] strToCharArr(string str)
{
int Length = str.Length;
char[] arr = new char[Length];
for (int i = 0; i < Length; i++)
arr[i] = str[i];
return arr;
}
string str1 = Console.ReadLine()!;
char[] arr1 = strToCharArr(str1);
Console.WriteLine(arr1);
foreach (var item in arr1)
{
Console.Write(item + " ");
}