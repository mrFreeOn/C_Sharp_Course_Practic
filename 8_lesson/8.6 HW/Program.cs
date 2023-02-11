
/*Задайте двумерный массив. Напишите программу, которая будет находить строку
с наименьшей суммой элементов*/

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

int[] SummRow(int[,] arr)
{
    int[] summ_min = new int[arr.GetLength(0)];
    int summ;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        summ = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
            summ += arr[i, j];

        summ_min[i] = summ;

    }
    return summ_min;
}

void MinRow(int[] array)
{
    int count = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Сумма элементов {i + 1}-й строки: {array[i]}");
        if (array[i] < count)
        {
            count = array[i];
            index = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {index + 1}-й строке");
}

Console.WriteLine("Введите количество строк и столбцов массива и диапазон: ");
int[,] arr_1 = FillArray2D(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));

PrintArray2D(arr_1);
Console.WriteLine();
MinRow(SummRow(arr_1));

