// Написать программу которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным

string Weekand (int num)
{
    if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5) 
        return "нет";
    if (num == 6 || num == 7)
        return "да";
    else
        return "цифра не соответствует диапазону 1-7";   
}
int NumDayWeek = int.Parse(Console.ReadLine());

Console.WriteLine(Weekand(NumDayWeek));