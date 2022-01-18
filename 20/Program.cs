// 20. Задать номер четверти, показать диапазоны для возможных координат
string Result(int qua)
{
    string Demonstrate = $"В четверти {qua} X - принимает значения";
    if (qua == 1 | qua == 4) Demonstrate += $" больше 0. Y - принимает значения";
    if (qua == 3 | qua == 2) Demonstrate += $" меньше 0. Y - принимает значения ";
    if (qua == 1 | qua == 2) Demonstrate += $" больше 0.";
    if (qua == 3 | qua == 4) Demonstrate += $" меньше 0.";
    return Demonstrate;
}

Console.WriteLine (Result(3));