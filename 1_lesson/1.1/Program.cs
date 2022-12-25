//  Напишите программу которая на вход принимает 2 числа и проверяет, 
//  является ли первое число квадратом второго.

Console.WriteLine("Введите 1е число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2е число: ");
int num2 = int.Parse(Console.ReadLine());

if (num2 * num2 == num1)
{
    Console.WriteLine("Да");
}
else
    Console.WriteLine("Нет");


