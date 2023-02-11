

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


void MinElement()
{
    int[,] arr = new int[12, 10];
    //int[,] arr2 = new int [11, 9];
    arr = FillArray2D(arr.GetLength(0), arr.GetLength(1), 0, 9);
    PrintArray2D(arr);
    (int, int) minIndex = (0, 0);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[minIndex[j], minIndex[i]] > arr[i, j])
                minIndex = (i, j);
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == minIndex.Item1 | j == minIndex.Item2)
                continue;
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    MinElement();
}
