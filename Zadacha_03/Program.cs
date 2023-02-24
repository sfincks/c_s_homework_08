// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором;
// int[m, n] array*int[n, l] array = int[m, l] array

int getNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] generateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rng = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rng.Next(1, 5);
        }
    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] matrixSum(int[,] matrix1, int[,] matrix2)
{   int summ;
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            summ = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                summ += (matrix1[i, k] * matrix2[k, j]);
            }
            result[i,j] = summ;
        }
    }
    return result;
}


System.Console.WriteLine("Операция умножения двух матриц выполнима только в том случае,"
                       + "если число столбцов в первом сомножителе равно числу строк во втором");
int a = getNumber("Введите число строк первой матрицы");
int b = getNumber("Введите число столбцов первой матрицы");
int c = getNumber("Введите число строк второй матрицы");    //мб оставить только б т.к. б должно ровняться с
if (b != c)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Колличество столбцов первой матрицы должно быть равно количеству строк второй матрицы");
    System.Console.WriteLine();
    return;
}
int d = getNumber("Введите число столбцов второй матрицы");


int[,] matrix1 = generateMatrix(a, b);
int[,] matrix2 = generateMatrix(c, d);
System.Console.WriteLine();
printMatrix(matrix1);
System.Console.WriteLine();
printMatrix(matrix2);
System.Console.WriteLine();
int[,] matrix12 = matrixSum(matrix1, matrix2);
printMatrix(matrix12);
System.Console.WriteLine();
// explain(matrix1,matrix2);

// void explain(int[,] matrix1, int[,] matrix2)
// {   int summ;
//     int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             summ = 0;
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//             {   
//                 summ += (matrix1[i, k] * matrix2[k, j]);
//                 System.Console.Write($"{matrix1[i, k]}*{matrix2[k, j]}+={summ} ");
//             }
//             result[i,j] = summ;
//             System.Console.Write("\t");
//         }
//         System.Console.WriteLine();
//     }
    
// }