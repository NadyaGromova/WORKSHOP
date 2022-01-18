//21. Программа проверяет пятизначное число на палиндромом.
bool result(int a)
{
    int b = a;
    int number = 0;
    while (a > 0)
    {
        number = number * 10 + a % 10;
        a = a / 10;
    }
    return number == b;
}
Console.WriteLine($"pal = {result(12321)}");
