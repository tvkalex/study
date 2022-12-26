// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N= 5-> "1, 2, 3,4, 5"
// N= 6-> "1, 2, 3,4, 5, 6"

// int num = inputNumber("Введите число: ");
// Print(num);

// void Print(int num)
// {
//     if (num != 1)
//     {
//         Print(num - 1);
//     }
//     System.Console.Write(num + " ");
// }
// System.Console.WriteLine();

int inputNumber(string str)
{
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
}

// Задайте значения М и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от М до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M=4; N =8 -> "4, 6, 7, 8"

// System.Console.WriteLine("Введите числа, в промежутке которых нужно вывести натур. числа!");
// int num_1 = inputNumber("Введите 1-ое число: ");
// int num_2 = inputNumber("Введите 2-ое число: ");
// int temp = func(num_1, num_2);
// GetSum(num_1, num_2, temp);
// System.Console.WriteLine();

// int func(int num_1, int num_2)
// {
//     {
//         temp = 1;
//         if (num_1 > num_2)
//         {
//             temp = -1;
//         }
//         return temp;
//     }
// }

// void GetSum(int num_1, int num_2, int temp)
// {
//     {
//         System.Console.Write(num_1 + " ");
//         if (num_1 != num_2)
//         {
//             GetSum(num_1 + temp, num_2, temp);
//         }
//     }
// }

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int Number = inputNumber("Введите натуральное число N: ");
// int SumNumber(int num)
// {
//     if (num == 0)
//     {
//         return num;
//     }
//     return (num % 10 + SumNumber(num / 10));
// }
// System.Console.WriteLine(SumNumber(Number));

// Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.
// A = 3: B = 5 -> 243 (35)
// A = 2; B = 3 -> 8

int A = inputNumber("Введите число: ");
int B = inputNumber("Введите степень: ");
Console.WriteLine(PowAtoB(A, B));
int PowAtoB(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    int result = a * PowAtoB(a, b - 1);
    return result;
}
