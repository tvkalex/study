// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int num = inputNumber("Ведите число: ");
func(num);
void func(int num)
{
    if (num / 2 != 0)
    func(num / 2);
    System.Console.Write(num % 2);
}
System.Console.WriteLine();

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