// Вид 1. Void. Ничего не принимают, ничего не возвращают
void Method1()
{
    Console.WriteLine("Метод 1");
}
Method1(); //Пример вызова метода

// Вид 2. Void. Что-то принимают, ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Метод 2");

// Вид 2a
void Method2a(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method2a ("Текст", 4); 
//Method2a (msg: "Текст"', count: 4); // именованные аргументы
Method2a (count: 4, msg: "Метод 2а"); // именованные аргументы, можно менять местами

// Вид 3. Ничего не принимают, что-то возвращают (напр. генератор случайных чисел, дата)
int Method3()
{
    return DateTime.Now.Year;  // процесс
}

int year = Method3();           // сюда положили результат
Console.WriteLine (year);       // здесь вывели результат

// Вид 4. Что-то принимают, что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Метод 4, ");
Console.WriteLine(res);