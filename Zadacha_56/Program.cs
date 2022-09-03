/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка*/

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

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

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
int[] sumRows = new int[rows];
for (int i = 0; i < resultMatrix.GetLength(0); i++)// строчки
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)// столбцы
    {
        sumRows[i] = sumRows[i] + resultMatrix[i, j];
    }
}
int minSumRows = sumRows[0];
int minRows = 1;
for (int n = 1; n < columns; n++)
    if (sumRows[n] < minSumRows)
    {
        minSumRows = sumRows[n];
        minRows = n + 1;
    }
Console.WriteLine($"Наименьшая сумма элементов {minSumRows} на строке {minRows}");

