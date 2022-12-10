// Напишите программу, которая принимает на вход число (N) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int N = InputNumber("Введите число N: ");
// int B = InputNumber("Введите другое: ");

// int result = SumA(N);
// int result2 = SumA(B);

// System.Console.WriteLine($"Сумма чисел от 1 до {N} = {result}");
// System.Console.WriteLine($"Сумма чисел от 1 до {B} = {result2}");

// int InputNumber(string text)
// {
//     System.Console.WriteLine(text);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int SumA(int number)
// {
//     int result = 0;
//     for (int i = 0; i <= number; i++)
//     {
//         result += i; // или result = result + i
//     }
//     return result;
// }

//=====================

// Задача 26: Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int inputNumber()
{
    int number;
    string text;
    while (true)
    {
        Console.Write("Введите число: ");
        text = Console.ReadLine()!;
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

// int result = inputNumber();
// int func(int number)
// {
//     return Convert.ToString (number).Length;//string text = Convert.ToString (number);
//                                             //int len = text.Length;
//                                             //return len;
// }
// System.Console.WriteLine($"Количество цифр в введенном числе: {func(result)}");

//======================

// Напишите программу, которая принимает на вход число N и
// выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

//int N = inputNumber(); // используется метод, сделанный выше
//int Fact(int n) // новый метод вычисления факториала
// {
//     int res = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         res *= i;
//     }
//     return res;
// }
//System.Console.WriteLine(Fact(N));

//System.Console.WriteLine(Fact(inputNumber()));// решение в одну строчку с 2-мя методами

// int Factorial(int n)
// {
//     if (n == 1) return 1;
//     return n * Factorial(n - 1); // рекурсия
// }
// Console.WriteLine(Factorial(inputNumber()));

//Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

// int[] arr = new int[8];
// Random rand = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rand.Next(0, 2);
// }
// System.Console.WriteLine(string.Join(" | ", arr));

//===

System.Console.WriteLine("Введите размер массива");
int arrLength = inputNumber();
int[] arr = Auto(arrLength);
System.Console.WriteLine(string.Join(" | ", arr));

int[] Auto(int len)
{
    int[] arr = new int[len];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 2);
    }
    return arr;
}
