//8. Показать четные числа от 1 до N

int N = 10;
int startNumber = 1;

while (startNumber <= N)
{
    if (startNumber % 2 == 0) Console.WriteLine(startNumber);
    startNumber++;
}

int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int size = array.Length;
int i = 0;
while (i < size)
{
    if (array[i]%2 == 0)
    {
        Console.WriteLine(array[i]);
    }
    i++;
}
