/* Написать программу, которая по заданному диапозонному номеру четверти, 
показывает диапозон возможных координат точек в этой четверти (X и Y) */


Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("x > 0  y >0");
}

else if (number == 2)
{
    Console.WriteLine("x < 0   y > 0");
}
else if (number == 3)
{
    Console.WriteLine("x < 0   y < 0");
}
else if (number == 4)
{
    Console.WriteLine("x > 0   y < 0");
}
else
{
    Console.WriteLine("Неверная четверть");
}

/* **************через массив***** */

/* Console.WriteLine("Eneter quater number: ");
int quater = Convert.ToInt32(Console.ReadLine());
string[] arr = {"x > 0; y > 0", "x < 0; y > 0", "X < 0; y < 0", "x > 0; y <0"};

if (quater >= 1 && quater <= 4)
{
    Console.WriteLine(arr[quater-1]);
}
else
{
    Console.WriteLine("Такой четверти нет")
} */