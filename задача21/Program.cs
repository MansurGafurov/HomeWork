// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координоты точки А ");
Console.Write("x1 = ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 = ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координоты точки B ");
Console.Write("x2 = ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 = ");
double z2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine( "Коордмноты точки А: " + "X = " +x1+ ", Y = " +y1+ ", Z = " +z1 );
Console.WriteLine( "Координаты точки B: " + "X = " +x2+ ", Y = " +y2+ ", Z = " +z2 );

double d = Math.Sqrt( Math.Pow((x2 -x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2 ));
double D1 = Math.Round(d , 2);

Console.WriteLine("Расстояние между точками = "  + D1 ); 

