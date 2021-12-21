// 4. Найти максимальное из трех чисел

int numberA = 2;
int numberB = 6;
int numberC = 10;
int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine(max);
