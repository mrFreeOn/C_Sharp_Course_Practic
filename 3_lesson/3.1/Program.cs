// Напишите программу, которая принимает на вход координаты точки (х и у),
// причем х != 0 и у != 0 и выдает номер четверти плоскости, в которой находится эта точка 
//(1,2,3,4 - против часовой стрелки).

void Quaters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0 or y = 0");

    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");
}
Quaters(0, 9);
Quaters(1, 9);
Quaters(-1, 9);
Quaters(-1, -9);
Quaters(1, -9);