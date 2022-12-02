// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// int num = new Random().Next(100, 1000);
// System.Console.WriteLine(num);
// int num1 = num / 100;
// int num2 = num / 10;
// int num3 = num % 10;
// System.Console.WriteLine($"{num1}{num3}");

// int num = new Random().Next(100, 1000);
// System.Console.WriteLine(num);
// int num1 = num / 100;
// int num2 = num % 10;
// System.Console.WriteLine($"{num1}{num2}");


int num = new Random().Next(100, 1000);
System.Console.WriteLine(num);
System.Console.WriteLine(num / 100 * 10 + num % 10);

// int num = new Random().Next(100, 1000);
// System.Console.WriteLine(num);
// string chr = Convert.ToString(num);
// System.Console.WriteLine($"{chr [0]}{chr [^1]}");
// знак $ позволяет выводить значения переменных в строке
// ($"{chr [0]}{chr [^1]}") вместо (chr [0] + "" + chr [^1])


// вывод первой и последней буквы слова. ^1 означает array.Length - 1
// string word = "hello";
// System.Console.WriteLine($"{word [0]}{word [^1]}"); 
