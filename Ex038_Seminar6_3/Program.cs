// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// вариант 1
int num = inputNumber("Ведите число: ");
func(num);
void func(int num)
{
    if (num / 2 != 0)
        func(num / 2);
    System.Console.Write(num % 2);
}
System.Console.WriteLine();

// вариант 2
int N = inputNumber("Введите число для конвертации: ");
GetBinaryView(N);
System.Console.WriteLine();

void GetBinaryView(int number)
{
    if (number <= 0) return;
    GetBinaryView(number / 2);
    System.Console.Write(number % 2);
}

// вариант 3
int num_2 = inputNumber("Введите десятичное число: ");
int t = num_2;
string s = "";
while (num_2 > 0)
{
    s = Convert.ToString(num_2 % 2) + s;
    num_2 /= 2;
}
System.Console.WriteLine($"Десятичное число {t} = {s} в двоичной CC");

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