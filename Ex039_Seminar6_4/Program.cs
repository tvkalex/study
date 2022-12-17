// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5->01123
// Если N=3->011
// Если N=7->0112358

// Console.Clear();
// int num_1 = 0, num_2 = 1;
// int temp;
// int num = inputNumber("Введите число: ");

// for (int i = 0; i < num; i++)
// {
//     System.Console.Write(num_1 + " ");
//     temp = num_1;
//     num_1 = num_2;
//     num_2 = temp + num_2;

// }
// System.Console.WriteLine();

int n = inputNumber("Введите число n: ");
int f1 = 0;
int f2 = 1;
int count = 0;
System.Console.Write($"{f1} ");
System.Console.Write($"{f2} ");

for (int i = 0; i < n - 2; i++)
{
    count = f1 + f2;
    System.Console.Write($"{count} ");
    f1 = f2;
    f2 = count;
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