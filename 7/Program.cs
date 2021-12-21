//7. Показать числа от -N до N

int numberA = 5;
int startNumber = numberA * (-1);

while (startNumber <= numberA)
{
    Console.WriteLine($"{startNumber}");
    startNumber++;
}