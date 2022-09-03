/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int oneDimention = 2;
int twoDimention = 2;
int threeDimention = 2;

int[,,] GetArray(int p, int r, int s)
{
    int[,,] matrix = new int[p, r, s];
    for (int l = 0; l < matrix.GetLength(0); l++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                matrix[l, i, j] = new Random().Next(10, 100);
            }
        }
    }
    return matrix;
}

void PrintArray(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) // столбцы
        {
            for (int n = 0; n < inputMatrix.GetLength(2); n++) // столбцы
            {
                Console.Write($"{inputMatrix[i, m, n]}({i},{m},{n})  "); //"\t" - Tab
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine($"Массив размером {oneDimention}x{twoDimention}x{threeDimention}:");
int[,,] resultMatrix = GetArray(oneDimention, twoDimention, threeDimention);
PrintArray(resultMatrix);


/* Попытка сделать двузнвачные неповторяющиеся элементы массива

int[,,] GetArray(int p, int r, int s)
{
    int[,,] matrix = new int[p, r, s];
    for (int l = 0; l < matrix.GetLength(0); l++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                matrix[l, i, j] = new Random().Next(10, 100);
            }
        }
    }

    int[,,] newMatrix = new int[p, r, s];
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int m = 0; m < matrix.GetLength(1); m++)
        {
            for (int n = 0; n < matrix.GetLength(2); n++)
            {

                int number = matrix[k, m, n];
                for (int l = 1; l < matrix.GetLength(0); l++)
                {
                    for (int i = 0; i < matrix.GetLength(1); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(2); j++)
                        {
                            if (matrix[l, i, j] != number) newMatrix[k, m, n] = number;
                            else return GetArray(p, r, s);
                        }
                    }
                }
            }
        }
    }
    return newMatrix;
}*/