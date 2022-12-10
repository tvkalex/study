// Напишите программу, которая принимает на вход число (N) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int N = InputNumber("Введите число N: ");
int B = InputNumber("Введите другое: ");

int result = SumA(N);
int result2 = SumA(B);

System.Console.WriteLine($"Сумма чисел от 1 до {N} = {result}");
System.Console.WriteLine($"Сумма чисел от 1 до {B} = {result2}");

int InputNumber(string text)
{
    System.Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumA(int number)
{
    int result = 0;
    for (int i = 0; i <= number; i++)
    {
        result += i; // или result = result + i
    }
    return result;
}
