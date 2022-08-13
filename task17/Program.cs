/* // написать программу, которая принимает на вход координаты точки (X и Y), причем
X не равен 0 и Y не равен 0 и выдает номер четверти плоскости, в которой
находится эта точка */


int[] point =  new int [2];
Console.WriteLine("Введите координату X: ");
point[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
point[1] = Convert.ToInt32(Console.ReadLine());

if(point[0] > 0 && point[1] > 0)
{
    Console.WriteLine("Первая четверть");
}
else if (point[0] < 0 && point[1] > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if (point[0] < 0 && point[1] < 0)
{
    Console.WriteLine("Третья четверть");
}
else if (point[0] > 0 && point[1] < 0)
{
    Console.WriteLine("Четвертая четверть");
}
else
{
    Console.WriteLine("Точка лежит на оси");
}