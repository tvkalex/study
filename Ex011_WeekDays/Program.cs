/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

/*
System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!); //второй вариант: int num = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        System.Console.WriteLine("Это понедельник");
        break;
    case 2:
        System.Console.WriteLine("Это вторник");
        break;
    case 3:
        System.Console.WriteLine("Это среда");
        break;
    case 4:
        System.Console.WriteLine("Это четверг");
        break;
    case 5:
        System.Console.WriteLine("Это пятница");
        break;
    case 6:
        System.Console.WriteLine("Это суббота");
        break;
    case 7:
        System.Console.WriteLine("Это воскресенье");
        break;
    default:
        System.Console.WriteLine("А сколько дней в твоей неделе?");
        break;
}
*/

/*
Console.WriteLine("Введите число: ");
int num = Convert. ToInt32(Console. ReadLine ());
if (num == 1)
{
    Console.WriteLine("Понедельник");
}
else if (num == 2)
{
    Console.WriteLine("Вторник");
}
else if (num == 3)
{
    Console.WriteLine("Среда");
}
else if (num == 4)
{
    Console.WriteLine("Четверг");
}
else if (num == 5)
{
    Console.WriteLine ("Пятница");
}
else if (num == 6)
{
    Console.WriteLine("Суббота");
}
else if (num == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Ошибка");
}
*/

string[]DayOfWeek = {"понедельник","вторник","среда","четверг","пятница","суббота","воскресенье"};
Console.WriteLine ("Введите число от 1 до 7");
int number1=Convert.ToInt32(Console.ReadLine ());
number1 = number1 - 1;
Console.WriteLine ("Ваш день недели - ");
Console.WriteLine (DayOfWeek[number1]);