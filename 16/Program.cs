// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("выходной");
}
else
{
    Console.WriteLine("будни");
}

