//

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

void Input(int[,] arr_serch)
{
    Console.Write("Введите искомое значение: ");
    int serch_number = int.Parse(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < arr_serch.GetLength(0); i++)
        for (int j = 0; j < arr_serch.GetLength(1); j++)
        {
            if (arr_serch[i, j] == serch_number)
            {
                Console.WriteLine($"Введенный элемент {serch_number}, результат: [{i + 1}, {j + 1}]");
                count++;
                break;
            }
        }
    if (count == 0) Console.Write($"Введенный элемент {serch_number}, результат: такого элемента нет.");
}
Console.WriteLine("Введите количество строк и столбцов массива и диапазон: ");
int[,] arr_1 = FillArray2D(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));

PrintArray2D(arr_1);
Console.WriteLine();
Input(arr_1);
