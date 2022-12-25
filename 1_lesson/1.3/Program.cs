// напишите программу которая на вход принимает одно число N, 
//а на выходе показывает все целые числа в промежутке от -N до N. 2 > -2, -1, 0, 1, 2

Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
int num = int.Parse(a);

int count = - num;

while (count < num)
{
    Console.Write($"{count} ");
    count += 1;
}