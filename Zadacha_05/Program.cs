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

int[,] matrixFlipper(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int rotationCount = n / 2 +1;
    int line = 0;
    int count = 1;
    for (int i = 0; i < rotationCount; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            for (int k = 0; k < n; k++)
            {
                if (matrix[line,k] == 0)
                {
                    matrix[line,k] = count++;
                }
            }
            matrix=rotate(matrix);
        }
        line++;
        n=n-1;
    }
    return matrix;
}

int[,] rotate(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int[,] newMatr = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newMatr[n - 1 - j, i] = matrix[i, j];
        }
    }
    return newMatr;
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j]<10)
            {
                System.Console.Write("0" + matrix[i, j] + "\t");
            }
            else
            {
                System.Console.Write(matrix[i, j] + "\t");
            }

            
        }
        System.Console.WriteLine();
    }
}


int row = getNumber("Введите размер массива");
int col = row;
int[,] matrix = generateMatrix(row, col);
System.Console.WriteLine();
printMatrix(matrix);

matrix = rotate(matrix);
System.Console.WriteLine();
matrix = matrixFlipper(matrix);
printMatrix(matrix);