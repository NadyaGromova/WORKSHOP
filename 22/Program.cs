// 22. Найти расстояние между точками в пространстве 2D/3D

//22. Найти расстояние между точками в пространстве 2D/3D
//2D:
// double Distance(double x1, double x2, double y1, double y2)
// {
//     double dis = 0;

//     dis = Math.Sqrt((Math.Pow ((x2-x1),2))+(Math.Pow((y2-y1),2)));
//     return dis;
// }

// Console.WriteLine(Distance (1,5,1,1));



//3D:
double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double dis = 0;

    dis = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)) + (Math.Pow((z2 - z1), 2)));
    return dis;
}

Console.WriteLine(Distance(1,2,3,4,5,6));