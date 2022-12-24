// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

{
    Console.Write("Введите число: ");
    string number = Console.ReadLine()!;
    ushort sum = 0;
    bool point = true;
    char symbol;
    for (int i = 0; i < number.Length; ++i)
    {
        symbol = number[i];
        if (i == 0 && symbol == '-' || symbol == '+') continue;
        if (point && symbol == '.')
        {
            point = false;
            continue;
        }
        if (Char.IsDigit(symbol)) sum += Convert.ToUInt16(symbol.ToString());
        else break;
    }
    Console.WriteLine("Сумма цифр = " + sum);
    Console.ReadKey();
}