/*задайте двумерный массив. Напиите программу, которая поменяет местами 
первую и последнюю строки массива*/

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

void Zamena(int [,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
        (arr[0, j], arr[arr.GetLength(0)-1, j]) = (arr[arr.GetLength(0)-1, j], arr[0, j]);
        
}

Console.WriteLine("Введите количество строк и столбцов массива и диапазон: ");
int[,] arr_1 = FillArray2D(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));

PrintArray2D(arr_1);
Console.WriteLine();
Zamena(arr_1);
PrintArray2D(arr_1);
