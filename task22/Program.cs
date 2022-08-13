/* написать программу, которая принимает на вход число (N) и выдает таблицу
квадратов чисел от 1 до N.
5 -> 1, 4. 9, 16, 25
2 -> 1, 4
 */

Console.WriteLine(" Enter your number: ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
int count = 1;
if (N == 0)
{
    Console.WriteLine("0");
}

else
{
    while(count <=N)
    {
        Console.WriteLine(Math.Pow(count, 2));
        count++;
    }
}

// int number = Convert.ToInt32(Console.ReaLIne());
/* int count = 1;
while (count <= number)
{
    Console.WriteLine(count*count);
    count++;
} */