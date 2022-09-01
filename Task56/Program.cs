// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
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


void SumElemRow(int[,] matrix, int[] sum)
{
    int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[k] += matrix[i, j];
           
        }
         k++;
        }
}
void NumRowMinSum(int[] sum)
{
    int index = 0;
     int min = sum[0];
    for (int k = 0; k < sum.Length; k++)
    {
               if (sum[k] < min)
        {
            min = sum[k];
            index = k;
        }
           }
Console.WriteLine($"Наименьшая сумма элементов {min} в строку номер: {index + 1}");
}

int[,] array2D = CreateMatrixRndInt(m, n, -9, 9);
PrintMatrix(array2D);
System.Console.WriteLine();
int[] sum1 = new int[1 * m];
SumElemRow(array2D, sum1);
NumRowMinSum(sum1);
