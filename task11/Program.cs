/* написать программу, которая выводит случайное трехзначное число
 и удаляет вторую цифру этого числа: 456-> 46, 782 -> 72, 918 -> 98 */

/* int number = new Random().Next(100, 1000);
Console.WriteLine($"Наше случайное число = {number}");
int numberA =number/100;
int numberC = number % 10;
Console.WriteLine(numberA*10 + numberC); */

//int a = new Random().Next(-100, -100);
/* Console.WriteLine($"Наше случайное число = {a}");
int b =a / 100 * 10;
int c = c % 10;
int d = b + c;
Console.WriteLine($"{d}"); */


int number = new Random().Next(100, 1000);
Console.WriteLine($"Для проверки: {number}");
string s = number.ToString();
int first = int.Parse(s[0].ToString());
int last = int.Parse(s[s.Length - 1].ToString());
Console.WriteLine($"{first}{last}");
