// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

int numberA = 361;
int numberB = 6;
int rest = numberA % numberB;

if (rest == 0) Console.WriteLine($"число {numberA} кратно числу {numberB}");
else
{
    Console.WriteLine(rest);
}
