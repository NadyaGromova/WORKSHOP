// 47. Написать программу копирования массива

int[] createArray(int sizeArray, int min, int max)
{
    int[] arrayToReturn = new int[sizeArray];
    Random rnd = new Random();
    for (int i = 0; i < sizeArray; i++)
    {
        arrayToReturn[i] = rnd.Next(min, max);
    }
    return arrayToReturn;
}

void ShowArray(int[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write($"{arrayToShow[i]}\t");
    }
    Console.WriteLine();
}

int[] copyArray(int[] arrayToCopy)
{
    int[] CopyArray = new int[arrayToCopy.Length];
    for (int i = 0; i < arrayToCopy.Length; i++)
    {
        CopyArray[i] = arrayToCopy[i];
    }
    return CopyArray;
}

int[] testArray = createArray(10, 0, 10);
ShowArray(testArray);

int [] resultArray = copyArray(testArray);
testArray[3] = 20;
ShowArray(testArray);
ShowArray(resultArray);


