// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

System.Console.Write("Введите первое число: ");
int num1 = int.Parse(System.Console.ReadLine()!);
System.Console.Write("Введите второе число: ");
int num2 = int.Parse(System.Console.ReadLine()!);
string result = (num1 * num1 == num2 || num2 * num2 == num1) ? "Да" : "Нет";
System.Console.WriteLine(result);
