Console.Write("Write natural number N:  ");
int N = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (N > 0)
{
    result = (result*10 + N % 10) - 10;
    N /= 10;
}
Console.Write(result);
if (N < 10)
{
Console.WriteLine(N);
}
else
{
    while (N > 0)
    {
        int Digit = N % 10;
        N /= 10;
        if (N > 0)
        {
            Console.Write(Digit + ",");
        }
        else
        {
            Console.WriteLine(Digit);
        }
    }
}
