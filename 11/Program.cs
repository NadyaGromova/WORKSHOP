// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int N = new Random().Next(10, 100);
Console.WriteLine(N);

int tenth = N / 10;
int unit = N % 10;

if (tenth > unit)
{
    Console.WriteLine(tenth);
}

else
{
    Console.WriteLine(unit);
}
