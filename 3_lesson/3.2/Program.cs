// напишите программу, которая по заданному номеру четверти, показывает диапазон возможных
// координат точек в этой четверти (х и у)

void Diapason(int num)
{
    if (num == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (num == 2)
        Console.WriteLine("x < 0, y > 0");
    else if (num == 3)
        Console.WriteLine("x < 0, y < 0");
    else if (num == 4)
        Console.WriteLine("x > 0, y < 0");
    else
        Console.WriteLine("Error");
}

Diapason(1);
Diapason(2);
Diapason(3);
Diapason(4);
Diapason(5);