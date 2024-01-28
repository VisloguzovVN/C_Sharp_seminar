// 3. Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.

int[,] CreateMatrix(int rowCount, int columsCount) // Функция создания матрицы с элементами от 1 до 999
{
int[,] matrix = new int[rowCount, columsCount];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(1, 11);
}
}
return matrix;
}

void ShowMatrix(int[,] matrix) // Функция вывода матрицы на экран
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j]} ");
}
Console.WriteLine();
}
}

int[,] matrix = CreateMatrix(3, 4); // Задание размера матрицы и инициализация "интересного" числа.
ShowMatrix(matrix);

double[] Average(int[,] array)
{
double sum=0;
double[] newMass = new double[array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
sum=array[i,j]+sum;
}
newMass[i] = sum/array.GetLength(1);
sum = 0;
}
return newMass;
}
void Print(double[] arr)
{
int size = arr.Length;

for (int i = 0; i < size; i++)
Console.Write($"{arr[i]} ");

Console.WriteLine();
}

Print (Average(matrix));