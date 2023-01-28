﻿// задайте двумерный массив. Найдите элементы у которых обе позиции четные и замените эти элементы на их квадраты.

/*создайте двумерный массив m*n и заполните его случайными числами*/

void PrintArray2D(int[,] array)
{
    int row_size = array.GetLength(0);
    int col_size = array.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < col_size; j++)
            Console.Write($" {array[i, j],4} ");
        Console.WriteLine();
    }
}

int[,] FillArray2D(int row, int col, int from, int to)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

int[,] LevelUp(int[,] arr_pow)
{
    for (int i = 1; i < arr_pow.GetLength(0); i+=2)
        for (int j = 1; j < arr_pow.GetLength(1); j += 2)
            arr_pow[i, j] *= arr_pow[i, j];
    /*for (int j = 0; j < arr_pow.GetLength(1); j++)
        if (i % 2 != 0 && j % 2 != 0)
            arr_pow[i, j] = arr_pow[i, j] * arr_pow[i, j];
        else
            arr_pow[i, j] = arr_pow[i, j];*/

    return arr_pow;
}
Console.WriteLine("Введите количество строк и столбцов массива и диапазон: ");
int[,] arr_1 = FillArray2D(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));

PrintArray2D(arr_1);
Console.WriteLine();
PrintArray2D(LevelUp(arr_1));