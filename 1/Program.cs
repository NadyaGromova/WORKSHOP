//1. По двум заданным числам проверять является ли первое квадратом второго

int numberA = 5;
int numberB = 15;
System.Console.WriteLine(Math.Pow(numberA,2) == numberB);

if (Math.Pow(numberA,2) == numberB)
{
    Console.WriteLine ("true");
}
 else
 {
     Console.WriteLine ("false");
 }

