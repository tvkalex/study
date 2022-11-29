/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число
квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/

/*
System.Console.WriteLine("Введите числа, которые нужно проверить");
System.Console.WriteLine("Введите число № 1");
int firstNumber = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число № 2");
int secondNumber = int.Parse(Console.ReadLine());
if (secondNumber * secondNumber == firstNumber)
    System.Console.WriteLine("Первое число является квадратом второго");
else
    System.Console.WriteLine("Первое число никак не связано со вторым");
*/

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
