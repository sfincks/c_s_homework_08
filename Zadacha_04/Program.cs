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

int[,,] generateMatrix(int x, int y, int z,int min,int max)
{
    Random rng = new Random();     
    int[,,] matrix = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {                
                matrix[i, j, k] = rng.Next(min, max);
            }
        }
    }
    return matrix;
}

// int[,,] rngMatrix(int[,,] matrix,int min, int max)
// {
//     Random rng = new Random();
//     int [,,] copyOfMatrix= new int[matrix.GetLength(0),matrix.GetLength(1),matrix.GetLength(2)];
//     // Array.Copy(matrix,copyOfMatrix,matrix.Length);
//     Array.Fill<int>(copyOfMatrix,,0,matrix.GetLength(0));
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {                
//                 if(matrix[i,j,k]==copyOfMatrix[i,j,k])
//                 {
//                     matrix[i,j,k] = rng.Next(min, max);
//                 }
//             }
//         }
//     }
//     return matrix;
// }

void printMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write(matrix[i, j, k] + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }

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
int max = 30;
int x = getNumber("Введите число первой измерения");
int y = getNumber("Введите число второго измерения");
int z = getNumber("Введите число третьего измерения");

int[,,] matrix = generateMatrix(x, y, z,min,max);
System.Console.WriteLine();
printMatrix(matrix);
// System.Console.WriteLine("________________");
// rngMatrix(matrix);
// printMatrix(matrix);
System.Console.WriteLine();
printIndex(matrix);
