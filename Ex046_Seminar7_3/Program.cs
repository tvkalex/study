// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные,
// и замените эти элементы на их квадраты.
// 1 4 7 2
// 5 9 2 3
// 8 42 4
// Новый массив будет выглядеть вот так:
// 1 47 2
// 5 81 2 9
// 8 42 4

Console.Clear();
int m = inputNumber("Введите значение m: ");
int n = inputNumber("Введите значение n: ");
int[,] arr = FillAndPrintArray(m, n);

PrintArray(arr);
PowArray(arr);
Console.WriteLine();
PrintArray(arr);

void PowArray(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i += 2)
    {
        for (int j = 1; j < arr.GetLength(1); j += 2)
        {
            arr[i, j] = (int)Math.Pow(arr[i, j], 2);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " | ");
        }
        System.Console.WriteLine();
    }
}

int[,] FillAndPrintArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
}

int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine()!;
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
