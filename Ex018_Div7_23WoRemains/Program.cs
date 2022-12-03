// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

System.Console.Write("Введите число: ");
int num = int.Parse(System.Console.ReadLine()!);
string result = (num % 7 == 0 && num % 23 == 0) ? "Да" : "Нет";
System.Console.WriteLine(result);

