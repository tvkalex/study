/*
Напишите программу, которая на вход принимает одно число (N), а на выходе показывает
все целые числа в промежутке от - N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

/*
System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
int num_2 = -1 * num;
while (num_2 != num + 1)
{
    System.Console.Write(num_2 + " ");
    num_2++;
}
*/

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()!);
for (int i = -N; i <= N; i++)
    Console.Write(i + " ");

/*
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;
while (i<= N)
{
    Console.Write(i + " ");
    i++;
}
*/

/*
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    N = -N;
}
int i = -N;
while (i<= N)
{
    Console.Write(i + " ");
    i++;
}
*/
