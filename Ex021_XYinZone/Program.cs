//Напишите программу, которая по заданному номеру четверти
//показывает диапазон возможных координат точек в этой четверти (х и у).

string[] part = { "x > 0; y > 0", "x < 0; y > 0", "x < 0; y < 0", "x > 0; y < 0" };
System.Console.WriteLine("Введите номер четверти в виде цифры от 1 до 4: ");
int n = int.Parse(System.Console.ReadLine()!);
if (n == 1)
{
    System.Console.WriteLine(part[0]);
}
else if (n == 2)
{
    System.Console.WriteLine(part[1]);
}
else if (n == 3)
{
    System.Console.WriteLine(part[2]);
}

else if (n == 4)
{
        System.Console.WriteLine(part[3]);
}
