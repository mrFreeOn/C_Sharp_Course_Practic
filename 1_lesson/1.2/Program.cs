// Напиите программу, которая будет выдавать название дня недели по заданному номеру

Console.WriteLine("Введите номер дня недели (1-7): ");
int num = int.Parse(Console.ReadLine());

string[] DayOfWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

if ( num<=7 )
{
    Console.WriteLine(DayOfWeek[num-1]);
}
else
    Console.WriteLine("вы ввели невtрное число!");
