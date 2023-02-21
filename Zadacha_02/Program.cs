// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int findMaxValueRow(int[,] matrix)
{
    int[] count = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        count[i] = sum;
        System.Console.WriteLine(sum);
    }
    int min = 0;
    int minIndex = 0;
    for (int k = 0; k < count.Length; k++)
    {
        if (count[k] > min)
        {
            min = count[k];
            minIndex = k+1;
        }
        
    }
    return minIndex;
}



int row = getNumber("Введите количество строк");
int col = getNumber("Введите количество столбцов");
System.Console.WriteLine();
int[,] array = generateMatrix(row, col);
printMatrix(array);
System.Console.WriteLine();
System.Console.WriteLine($"Наименьшая сумма элементов в строке № {findMaxValueRow(array)}");