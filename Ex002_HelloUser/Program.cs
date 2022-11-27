Console.Write("Введите ваше имя ");
string username = Console.ReadLine()!; //Add ! as null forgiving to avoid mistake "Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL." [Ex002_HelloUser]csharp(CS8600)
Console.WriteLine("Привет, ");
Console.WriteLine(username);
Console.Write("Привет, ");
Console.Write(username);