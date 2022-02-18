// 46. Написать программу масштабирования фигуры
using static System.Console;

string MyInput(string msg)
{
    Write(msg);
    return ReadLine() ?? string.Empty;
}

double[] StringConvert(string stringDouble, char[] splitChar, out bool sign)
{
    string[] tmp = stringDouble.Split(splitChar, StringSplitOptions.RemoveEmptyEntries);
    double[] result = new double[tmp.Length];
    bool flag = false;
    double temp = 0;
    for (int i = 0; i < tmp.Length; i++)
    {
        flag = double.TryParse(tmp[i], out temp);
        if (!flag)
        {
            WriteLine($"Неверный ввод: {tmp[i]}");
            sign = false;
            return result;
        }
        result[i] = temp;
    }
    sign = true;
    return result;
}

void ScalingCoordinates(double[] coordinates, double coefficient)
{
    for (int i = 0; i < coordinates.Length; i++)
        coordinates[i] *= coefficient;
}

void PrintArray(double[] array)
{
    int k = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}\t");
        if (k % 7 == 0)
            WriteLine();
        k++;
    }
    WriteLine();
}

char[] splitFormat = { ' ', ',', '(', ')', '_' };

Console.Clear();

while (true)
{
    bool sign = true;
    string answer = MyInput("Введите координаты: ");
    if (answer.Length == 0)
        break;
    double[] coordinates = StringConvert(answer, splitFormat, out sign);
    WriteLine(sign);
    if (!sign)
        continue;
    Write("Введите коэффициент: ");
    string coefficient = ReadLine() ?? string.Empty;
    bool flag = double.TryParse(coefficient, out double coefficientScaling);
    if (!flag)
    {
        WriteLine($"Неверный ввод коэффициента: {coefficient}");
        continue;
    }
    WriteLine("Введены координаты");
    PrintArray(coordinates);
    ScalingCoordinates(coordinates, coefficientScaling);
    WriteLine("Координаты после масштабирования");
    PrintArray(coordinates);
}
