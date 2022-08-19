/* Написать программу, которая принимает на вход число (А) и 
выдает сумму чисел от 1 до А
7 -> 28
4 -> 10
8 -> 36 */


/* ----------------------первый вариант--------------------------- */

int Cycle(int a)
{
    int sum = 0;
    for(int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Cycle(number);
Console.Write($"Результат = {sum}");

/* можно сократить так:

Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Результат = {Cycle(number)}"); */

/* _--------второй вариант-----------------
 
/* Console.Write("Ввод числа А: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int i = 1; i <= number; i++)
{
    sum = sum + i;
}
Console.Write($"Результат работы программы = {sum}"); */