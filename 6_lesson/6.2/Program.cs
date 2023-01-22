/* Наипшите программу, которая будет реобразовывать десятичное число в двоичное.
45 > 101101, 3 > 11, 2 > 10*/

string TwoInTen(int x)
{
    string result = "";
    while(x > 0)
    {
        result = x % 2 + result;
        x /= 2;
    }
    return result;
}
Console.WriteLine(TwoInTen(int.Parse(Console.ReadLine())));