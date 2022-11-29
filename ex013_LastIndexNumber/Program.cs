/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе
показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

/*
System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(num % 10);
*/

/*
Console.WriteLine("Введите трехзначное число ");
string number1 = Console.ReadLine()!;
Console.WriteLine("{0}->{1}", number1, number1[2]);
*/

/*
Console.Write("Введите число: ");
String N = Console.ReadLine();
Console.WriteLine(N[2]);
*/

//Решение для числа любой длины. Находит последнюю цифру этого числа.
Console.Write("Введите число: ");
String N = Console.ReadLine();
Console.WriteLine(N[N.Length - 1]);

//Console.WriteLine(N.Length - 1); - для поиска индекса последней цифры в числе