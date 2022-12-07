// Напишите программу, которая принимает на вход _число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(System.Console.ReadLine());
int i = 1;
for (i = 1; i <= n; i++)
{
    System.Console.Write($"{i * i} ");
}
