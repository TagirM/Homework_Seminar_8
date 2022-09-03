/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int rowsAndColumns = 5;
Console.WriteLine($"Спиральная матрица c размером {rowsAndColumns}x{rowsAndColumns}:");
int[,] matrix = new int[rowsAndColumns, rowsAndColumns];
for (int i = 0; i < matrix.GetLength(0); i++)//строчки
{
    for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
    {
        int ik = i + 1;
        int jk = j + 1;
        int switcher = (jk - ik + rowsAndColumns) / rowsAndColumns;
        int Ic = Math.Abs(ik - rowsAndColumns / 2 - 1) + (ik - 1) / (rowsAndColumns / 2) * ((rowsAndColumns - 1) % 2);
        int Jc = Math.Abs(jk - rowsAndColumns / 2 - 1) + (jk - 1) / (rowsAndColumns / 2) * ((rowsAndColumns - 1) % 2);
        int Ring = rowsAndColumns / 2 - (Math.Abs(Ic - Jc) + Ic + Jc) / 2;
        int Xs = ik - Ring + jk - Ring - 1;
        int Coef = 4 * Ring * (rowsAndColumns - Ring);
        matrix[i, j] = Coef + switcher * Xs + Math.Abs(switcher - 1) * (4 * (rowsAndColumns - 2 * Ring) - 2 - Xs); ;
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

