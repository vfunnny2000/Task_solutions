/* написать программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2 D пространстве.
A (3, 6); B (2, 1) -> 5,09
A (7, -5); B (1, -1)  -> 7,21 */

/* Console.WriteLine("Введите число х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
// double length = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2))
Console.WriteLine(length);  */

//
double[] A = new double[2];
double[] B = new double[2];
Console.WriteLine("Введите x1: ");
A[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y1: ");
A[1] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите x2: ");
B[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y2: ");
B[1] = Convert.ToDouble(Console.ReadLine());

double length = Math.Sqrt(Math.Pow(B[0] - A[0], 2) + Math.Pow(B[1] - A[1], 2));
Console.WriteLine(length);


