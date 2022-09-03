/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
//Задаем двумерный массив
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)//строчки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) // столбцы
        {
            Console.Write(inputMatrix[i, m] + " "); //"\t" - Tab
        }
        Console.WriteLine();
    }
}
// Упорядочивание по убыванию элементов каждой строки
int[,] OrderArray(int[,] matrix)
{
    int[] max = new int[matrix.GetLength(0)];
        for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            max[i] = matrix[i, k];
            for (int j = k; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max[i])
                {
                    max[i] = matrix[i, j];
                    int temp = matrix[i, k];
                    matrix[i, j] = temp;
                    matrix[i, k] = max[i];
                }
            }
        }
    }
    return matrix;
}
Console.WriteLine("Упорядоченный двумерный массив по убыванию элементов в строках:");
PrintArray(OrderArray(resultMatrix));

