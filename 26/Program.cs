// 26. Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = numberA;

for (int i = 1; i < numberB; i++)
{
    result *= numberA;
}

Console.WriteLine(result);
