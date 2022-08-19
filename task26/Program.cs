/* Напишите программу, которая принимает на вход число и выдаёт количество
 цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

/* Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (n > 0)
{
    n = n / 10;
    i += 1;
}
Console.WriteLine(i); */

/* Console.WriteLine("Enter number: ");
int Cycle(int n)
{
    int sum = 0;
    while (n > 0)
    {
    n = n / 10;
    sum += 1;
    }
    return sum;
}
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Cycle(n));
 */

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (number > 0)
{
    number = number / 10;
    count ++;
}

Console.Write(count);

^^^^^