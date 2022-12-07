//Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X # 0 и Y # 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// System.Console.WriteLine("Введите координату Х: ");
// int x = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите координату Y: ");
// int y = Convert.ToInt32(System.Console.ReadLine());
// if (x > 0 && y > 0)
// {
//     System.Console.WriteLine("Точка находится в четверти 1");
// }
// else if (x > 0 && y < 0)
// {
//     System.Console.WriteLine("Точка находится в четверти 4");
// }
// else if (x < 0 && y > 0)
// {
//     System.Console.WriteLine("Точка находится в четверти 2");
// }
// else if (x < 0 && y < 0)
// {
//     System.Console.WriteLine("Точка находится в четверти 3");
// }
//else
//{
//    System.Console.WriteLine("Точка находится на оси");
//}

int[] point = new int[2];
System.Console.WriteLine("Введите координату X: ");
point[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y: ");
point[1] = Convert.ToInt32(Console.ReadLine());
if (point[0] > 0 && point[1] > 0)
{
    System.Console.WriteLine("Точка лежит в первой четверти");
}
else if (point[0] > 0 && point[1] < 0)
{
    System.Console.WriteLine("Точка лежит в четвертой четверти");
}
else if (point[0] < 0 && point[1] < 0)
{
    System.Console.WriteLine("Точка лежит в третьей четверти");
}
else if (point[0] < 0 && point[1] > 0)
{
System.Console.WriteLine("Точка лежит во второй четверти");
}
else
{
    System.Console.WriteLine("Точка находится на оси");
}


//проверка кол-ва знаков в стринговом значении
// string text = "слово";
// System.Console.WriteLine(text.Length);