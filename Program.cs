// Задача 23. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7) -> 15,84
// A (7,-5,0); B (1,-1,9) -> 11,53

double GetDistanceXY(double ax, double ay, double az, double bx, double by, double bz) 
{
   double distance = Math.Pow( bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz -az, 2); // возведение в степень
   distance = Math.Sqrt(distance);     //корень из числа
   distance = Math.Round(distance, 3); // округление (сколько оставить символов после запятой)
    return distance;
}

System.Console.WriteLine("Ввежите координату первой точки по оси Х(ах) ");
double ax = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату первой точки по оси Y(ay)");
double ay = double.Parse(Console.ReadLine());
System.Console.WriteLine("Ввежите координату первой точки по оси Z(аz) ");
double az = double.Parse(Console.ReadLine()); 
System.Console.WriteLine("Введите координату второй точки по оси Х(bx) ");
double bx = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату второй точки по оси Y(by)");
double by = double.Parse(Console.ReadLine());
System.Console.WriteLine("Ввежите координату второй точки по оси Z(bz) ");
double bz = double.Parse(Console.ReadLine());


System.Console.WriteLine("расстояние между точками = " + GetDistanceXY(ax, ay, az, bx, by, bz));