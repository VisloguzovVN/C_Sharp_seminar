int a = int.Parse(Console.ReadLine()!);
int secondNumber = a / 10 % 10;
int thirdNumber = a % 10;
Console.WriteLine(Math.Pow(secondNumber,thirdNumber));
