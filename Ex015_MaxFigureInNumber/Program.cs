// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
// Например:
// • 78 -> 8
// • 12-> 2
// • 85 -> 8

int num = new Random().Next(10, 100); // [10, 100) [10, 99]
System.Console.WriteLine(num);
int num1 = num / 10; // 78 / 10 = 7
int num2 = num % 10; // 78 % 10 = 8
if (num1 > num2)
{
    System.Console.WriteLine(num1);
}
else
{
    System.Console.WriteLine(num2);
}
