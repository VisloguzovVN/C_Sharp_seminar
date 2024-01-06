Console.Write("Write natural number N:  ");
int N = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (N > 0)
{
    result = result*10 + N % 10;
    N /= 10;
}
if (result < 10)
{
Console.WriteLine(N);
}
else
{
    while (result > 0)
    {
        int Digit = result % 10;
        result /= 10;
        if (result > 0)
        {
            Console.Write(Digit + ",");
        }
        else
        {
            Console.WriteLine(Digit);
        }
    }
}
