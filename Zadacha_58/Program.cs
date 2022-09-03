/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int rows = 4;
int columns = 4;
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)//строчки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}

void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) // столбцы
        {
            Console.Write(inputMatrix[i, m] + "\t"); //"\t" - Tab
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix1 = GetArray(rows, columns);
int[,] resultMatrix2 = GetArray(rows, columns);
Console.WriteLine("1я матрица:");
PrintArray(resultMatrix1);
Console.WriteLine("2я матрица:");
PrintArray(resultMatrix2);
Console.WriteLine("Произведение двух матриц равно:");
int[,] multiplicationMatrix = new int [rows, columns];
for (int i = 0; i < multiplicationMatrix.GetLength(0); i++) // строчки
    {
        for (int m = 0; m < multiplicationMatrix.GetLength(1); m++) // столбцы
        {
            multiplicationMatrix[i,m] = resultMatrix1[i,m]*resultMatrix2[i,m];
            Console.Write(multiplicationMatrix[i, m] + "\t"); //"\t" - Tab
        }
        Console.WriteLine();
    }
