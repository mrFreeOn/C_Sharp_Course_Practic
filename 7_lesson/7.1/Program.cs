/*создайте двумерный массив m*n и заполните его случайными числами*/

void PrintArray2D(int[,] array)
{   
    int row_size = array.GetLength(0);
    int col_size = array.GetLength(1);
    
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < col_size; j++)
            Console.Write($" {array[i, j], 4} ");
        Console.WriteLine();
    }
}

int[,] FillArray2D(int row, int col)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            arr[i, j] = i + j;

    return arr;
}

Console.WriteLine("Введите количество строк и столбцов массива и диапазон: ");
int[,] arr_1 = FillArray2D(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));

PrintArray2D(arr_1);