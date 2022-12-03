// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// • 34, 5 - > не кратно, остаток 4
// • 16, 4 -> кратно
//======
// System.Console.WriteLine("Введите первое числ: ");
// int num1 = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);
// if (num1 / num2 == num2)
// {
//     System.Console.WriteLine("кратно");
// }
// else
// {
//     System.Console.WriteLine($"не кратно, остаток {num1 % num2}");
// }
//======
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 % num2 == 0)
// {
//     System.Console.WriteLine("кратно");
// }
// else
// {
//     System.Console.WriteLine($"не кратно, остаток {num1 % num2}");
// }
//======
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
string result = (num1 % num2 == 0) ? "кратно" : ($"не кратно, остаток {num1 % num2}");
System.Console.WriteLine(result);
