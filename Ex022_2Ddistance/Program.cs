//Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) - > 5,09
// A (7,-5); B (1,-1) -> 7,21

int[] point = new int[4];
System.Console.WriteLine("Введите x1: ");
point[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите у1: ");
point[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите x2: ");
point[2] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите у2: ");
point[3] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Math.Sqrt(Math.Pow(point[2] - point[0], 2) + Math.Pow(point[3] - point[1], 2)));