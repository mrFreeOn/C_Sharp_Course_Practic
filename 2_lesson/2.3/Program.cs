// напишите програму, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Пример: 161 > да; 7 > нет; 48 > нет...

string Crat (int arg)
{
    if (arg % 7 == 0 && arg % 23 == 0)
        return "да";
    else
        return "нет";
}

int num = int.Parse(Console.ReadLine());
Console.WriteLine(Crat(num));