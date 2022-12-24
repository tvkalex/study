// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


int num_1 = inputNumber("Введите 1-ое число: ");
int num_2 = inputNumber("Введите 2-ое число: ");
int num_3 = inputNumber("Введите 3-ое число: ");
Triangle(num_1, num_2, num_3);

void Triangle(int num_1, int num_2, int num_3)
{
    if ((num_1 > (num_2 + num_3)) || (num_2 > (num_1 + num_3)) || (num_3 > (num_1 + num_2)))
        System.Console.WriteLine("Треугольника с такими сторонами не существует!");
    else
        System.Console.WriteLine("Есть такой треугольник!");
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