void FillArray(int[] collection) //создание массива автозаполнения случайными числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //создание массива вывода на экран
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) //создание массива поиска индекса элемента массива
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //-1 выводится для индикации ошибки в случае ввода числа, отсутствующего в массиве
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 8);
Console.WriteLine(pos);