/*Напишите программу, которая будет создавать копию заданного двумерного
 массива с помощью поэлементного копирования*/


void PrintArray2D(int[,] array)
{
    int col = array.GetLength(1);
    int row = array.GetLength(0);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            Console.Write($"{array[i, j]} ");
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

int[,] Clone(int[,] array)
{
    int col = array.GetLength(1);
    int row = array.GetLength(0);
    int[,] clone_arr = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            clone_arr[i, j] = array[i, j];
    }
    return clone_arr;
}

Console.WriteLine("Введите количество строк и столбцов массива и диапазон: ");
int[,] arr_1 = FillArray2D(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));
Console.WriteLine("исходный массив");
PrintArray2D(arr_1);
Console.WriteLine("новый массив");
int [,] arr_2 = Clone(arr_1);
PrintArray2D(arr_2);

