// 17. По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA==Math.Pow(numberB,2) || numberB==Math.Pow(numberA,2))
{
    Console.WriteLine("является квадратом ");
}

else
{
    Console.WriteLine(" не является квадратом ");
}
