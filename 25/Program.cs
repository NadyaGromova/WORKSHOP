// 25. Найти сумму чисел от 1 до А

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = 1; i <= number; i++)
{
    result += i;
}

Console.WriteLine(result);