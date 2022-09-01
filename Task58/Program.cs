// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();
Console.WriteLine("Введите число строк 1 матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов 1 матрицы (строк 2 матрицы): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов 2 матрицы: ");
int s = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt1(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
int[,] CreateMatrixRndInt2(int n, int s, int min, int max)
{
    int[,] matrix = new int[n, s];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int m = matrix1.GetLength(0);
    int s = matrix2.GetLength(1);
    int[,] result = new int[m, s];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < s; j++)
        {
            for (int k = 0; k < s; k++)
            {
                result[i, j] += (matrix1[i, k] * matrix2[k, j]);
            }
        }
    }
    return result;
}

int[,] arrayA = CreateMatrixRndInt1(m, n, -9, 9);
PrintMatrix(arrayA);
Console.WriteLine();
int[,] arrayB = CreateMatrixRndInt2(n, s, -9, 9);
PrintMatrix(arrayB);
Console.WriteLine();
Console.WriteLine("Результирующая матрица:");
int[,] multiplicationMatrix = MultiplicationMatrix(arrayA, arrayB);
PrintMatrix(multiplicationMatrix);

