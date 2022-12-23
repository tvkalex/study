// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();
int m = inputNumber("Введите значение м: ");
int n = inputNumber("Введите значение n: ");
PrintArray(FillArray(m, n, out int result)); System.Console.WriteLine($"Cумма элементов по диагонали: {result}");

int inputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine()!;
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

int[,] FillArray(int m, int n, out int result)
{
    result = 0;
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 10);
            if (i == j)
                result += arr[i, j];
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " | " + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}