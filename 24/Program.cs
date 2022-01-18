// 24. Найти кубы чисел от 1 до N

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    int result = i * i * i;
    Console.WriteLine($"{i} в кубе = {result}");
}
