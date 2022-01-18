// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool Q(bool X, bool Y)
{
    return (!(X || Y)) == (!X && !Y);
}

Console.WriteLine(Q(true, true));
Console.WriteLine(Q(false, true));
Console.WriteLine(Q(true, false));
Console.WriteLine(Q(false, false));

