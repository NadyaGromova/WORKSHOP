//12.Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100,1000);
Console.WriteLine(number);

int tenth = number/100;
int unit = number%10;

Console.Write($"{tenth}{unit}");
