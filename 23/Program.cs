// 23. Показать таблицу квадратов чисел от 1 до N

int[] Fillarray(int numbers)
{
    int[] collection = new int[numbers];
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = i + 1;
    }
    return collection;
}

void PrintArray(int[] N)
{
    for (int count = 0; count < N.Length; count++)
    {
        Console.WriteLine($"{N[count]}^2 = {Math.Pow(N[count], 2)}");
    }
}

PrintArray(Fillarray(10));