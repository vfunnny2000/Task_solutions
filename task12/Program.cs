/* Написать программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если число 2 не кратно 1, то
программа выводит отсток от деления. Пример -> 34, 5 -> не кратно, остаток 4
16, 4 -> кратно.
 */

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA % numberB == 0)
{
    Console.WriteLine("Кратно");   
}
else
{
    Console.WriteLine($"Не кратно, остаток {numberA % numberB}");
}
 
 /* ---------------------------


Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a % b;

if(a % b == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {numberA % numberB}");
} */