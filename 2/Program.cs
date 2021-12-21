//2. Даны два числа. Показать большее и меньшее число

int numberA = 7;
int numberB = 4;
int min = numberA;
int max = numberA;

if (numberB>max)
{
    max = numberB;
}
else
{
    min = numberB;
}

Console.WriteLine($"максимальное - {max}");
Console.WriteLine($"минимальное - {min}");


