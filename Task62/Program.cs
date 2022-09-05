// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int[,] SquareMatrix(int m, int n)
{
   
    int i = 0;
    int j = 0;
    int num = 01;
    int[,] matrix = new int[m, n];

    for (j = 0; j < n; j++)
    {
        matrix[0, j] = num;
        num++;
    }

    for (i = 1; i < j; i++)
    {
        matrix[i, n - 1] = num;
        num++;
    }

    for (j = n - 2; j >= 0; j--)
    {
        matrix[n - 1, j] = num;
        num++;
    }

    for (i = n - 2; i > 0; i--)
    {
        matrix[i, 0] = num;
        num++;
    }
    int c = 1;
    int d = 1;
    int s = 0;

    while (num <= m * n)
    {
        while (matrix[c + s, d + s] == 0)
        {
            matrix[c + s, d + s] = num;
            num++;
            d++;
        }
        while (matrix[c + 1 - s, d - 1 - s] == 0)
        {
            matrix[c + 1 - s, d - 1 - s] = num;
            num++;
            c++;
        }
        while (matrix[n - 2 - s, d - 2 - s] == 0)
        {
            matrix[n - 2 - s, d - 2 - s] = num;
            num++;
            d--;
        }
        while (matrix[n - 3, d - 1 + s] == 0)
        {
            matrix[n - 3, d - 1 + s] = num;
            num++;
            n++;
        }
        s++;
        if (num != 0) break;

    }
    num++;
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
        Console.WriteLine(" ]");
    }
}

int[,] array2D = SquareMatrix(4, 4);
PrintMatrix(array2D);
