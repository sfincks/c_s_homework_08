// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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
            matrix[i, j] = 0;
        }

    }
    return matrix;
}

int[,] fillMatrix(int[,]matrix,int row, int col)
{
    //хызы
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


int row = getNumber("Введите количество строк");
int col = getNumber("Введите количество столбцов");
int[,] matrix = generateMatrix(row, col);
printMatrix(matrix);
System.Console.WriteLine();
fillMatrix(matrix,row,col);
printMatrix(matrix);
