// Задайте двумерный массив размером т×п, заполненный случайными целыми числами.
// m = 3, n = 4.
// 14819
// 5 -233 -2
// 77381

Console.Clear();
System.Console.WriteLine("Введите размер массив M x N");
int m = inputNumber("M = ");
int n = inputNumber("N = ");
int[,] array = new int[m, n]; // 0 символов - одномерный массив, 1 запятая - двумерный массив, 2 запятые - трёхмерный массив
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
{
    array[i, j] = rand.Next(-10, 10);
    System.Console.Write(array[i, j] + " | ");
}
System.Console.WriteLine();
}

int inputNumber(string message)
{
    int number;
    string text;
    while (true)
    {
        Console.Write(message);
        text = Console.ReadLine()!;
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}