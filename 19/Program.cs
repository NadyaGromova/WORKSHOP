// 19.  Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int Space(int x, int y)
{
    int quarter = 0;

    if (x > 0 && y > 0)
    {
        quarter = 1;
    }
    else
    {
        if (x < 0 && y > 0)
        {
            quarter = 2;
        }
        else
        {
            if (x < 0 && y < 0)
            {
                quarter = 3;
            }
            else
            {
                quarter = 4;
            }
        }
    }
return quarter;
}

int result = Space (2,-5);
Console.WriteLine (result);
