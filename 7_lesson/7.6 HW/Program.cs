//напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void Search(int[,] arr_search)
{
    Console.WriteLine("Введите номер строки и номер столбца искомого значения: ");
    int search_row = int.Parse(Console.ReadLine());
    int search_col = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (search_row <= arr_search.GetLength(0) && search_col <= arr_search.GetLength(1) 
            && search_col >= 0 && search_row >= 0)
        Console.WriteLine($"Искомый элемент: {arr_search[search_row-1, search_col-1]}");
    else  
        Console.WriteLine("Элемент с введенной позицией в массиве отсутсвует.");
}
Console.WriteLine("Введите количество строк и столбцов массива и диапазон: ");
int[,] arr_1 = FillArray2D(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));

PrintArray2D(arr_1);
Console.WriteLine();
Search(arr_1);
