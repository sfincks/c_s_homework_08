// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int getNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] generateMatrix(int[,] array, int x, int y, int z, int min, int max)
{
    Random rng = new Random();

    int[,,] matrix = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                Boolean flag = true;
                while (flag)
                {
                    int r = rng.Next(min, max);
                    if (array[1, r - min] == 1)
                    {
                        matrix[i, j, k] = r;
                        array[1, r - min] = 0;
                        flag = false;
                    }
                    else if (array[1, r - min] == 0)
                    {

                    }

                }
            }
        }
    }
    return matrix;
}

int[,] simpleMatrix(int row, int col)
{
    int sum = 10;
    int[,] matrix = new int[row, col];
    Random rng = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (i == 0) { matrix[i, j] = sum; sum++; }
            else { matrix[i, j] = 1; }
        }
    }
    return matrix;
}

void printIndex(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write(matrix[i, j, k] + $"({i},{j},{k})" + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }

}

int min = 10;
int max = 100;
int x = getNumber("Введите число первой измерения");
int y = getNumber("Введите число второго измерения");
int z = getNumber("Введите число третьего измерения");

int[,] array = simpleMatrix(2, max - min);
int[,,] matrix = generateMatrix(array, x, y, z, min, max);
System.Console.WriteLine();
printIndex(matrix);
