// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            matrix[i, j] = rng.Next(0, 10);
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

int[,] sortArrays(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    temp = matrix[i, k];
                    matrix[i, k] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }
    }
    return matrix;
}

int row = getNumber("Введите количество строк");
int col = getNumber("Введите количество столбцов");
System.Console.WriteLine();
int[,] array = generateMatrix(row, col);
printMatrix(array);
System.Console.WriteLine();
int[,] newArray = sortArrays(array);
printMatrix(newArray);

