// Напишите программу которая на вход принимает 2 числа и выдает какое больше

Console.WriteLine("Введите 1е число: ");
int num1 = int.Parse(Console.ReadLine());
 
Console.WriteLine("Введите 2е число: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine ($"Max = {Math.Max(num1, num2)}");
Console.WriteLine ($"Min = {Math.Min(num1, num2)}");
 