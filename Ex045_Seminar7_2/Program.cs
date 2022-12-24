// Задайте двумерный массив размера т на п, каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0123
// 1234
// 2345

Console.Clear();
int m = inputNumber("Введите значение m: ");
int n = inputNumber("Введите значение n: ");
int[,] arr = FillAndPrintArray(m, n);

int[,] FillAndPrintArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    return array;
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