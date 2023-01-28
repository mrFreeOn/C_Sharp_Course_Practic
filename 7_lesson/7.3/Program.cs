// задайте двумерный массив. Найдите элементы у которых обе позиции четные и замените эти элементы на их квадраты.

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

int Diagonal(int[,] arr_diag)
{
    int result = 0;
    int j = 0;
    for (int i = 0; i < arr_diag.GetLength(0); i++)
    {
            j = i;
            result += arr_diag[i, j];
    }

    return result;
}
Console.WriteLine("Введите количество строк и столбцов массива и диапазон: ");
int[,] arr_1 = FillArray2D(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));

PrintArray2D(arr_1);
Console.WriteLine();
Console.WriteLine(Diagonal(arr_1));
