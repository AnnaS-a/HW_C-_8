// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.Write("Введите число строк матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число глубины матрицы: ");
int s = Convert.ToInt32(Console.ReadLine());

int[,,] Matrix3D(int m, int n, int s)
{
    int[,,] matrix = new int[m, n, s];
    int count = 10;
    if (count < 100)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i, j, k] = count;
                    count++;
                }
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("[");
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k],4}({j},{k},{i}),");
                else Console.Write($"{matrix[i, j, k],4}({j},{k},{i}) ");
            }
            Console.WriteLine("]");
        }
    }
}

if (m*n*s < 100)
    {
        int[,,] array3D = Matrix3D(m, n, s);
        PrintMatrix(array3D);
    }
    else
{
     Console.WriteLine("Введите меньшие размеры матрицы");
}

   







