// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

Console.Clear();
int[,] arrayOld = GetArr();

FindMinElementArray(arrayOld, out int x, out int y);
PrintArray(FillNewArray(arrayOld));


void FindMinElementArray(int[,] arrayOld, out int x, out int y)
{
    int min = arrayOld[0, 0];
    x = 0;
    y = 0;

    for (int i = 0; i < arrayOld.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOld.GetLength(1); j++)
        {
            if (min > arrayOld[i, j])
            {
                min = arrayOld[i, j];
                x = i;
                y = j;
            }
        }
    }
}

int[,] FillNewArray(int[,] arrayOld)
{
    int[,] arrayNew = new int[arrayOld.GetLength(0) - 1, arrayOld.GetLength(1) - 1];
    int n = 0;
    int k = 0;

    for (int i = 0; i < arrayOld.GetLength(0); i++)
    {
        if (i == x)
        {
            continue;
        }
        for (int j = 0; j < arrayOld.GetLength(1); j++)
        {
            if (j == y)
            {
                continue;
            }
            arrayNew[n, k] = arrayOld[i, j];
            k++;
        }
        k = 0;
        n++;
    }
    return arrayNew;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] GetArr()
{
    int rows = 5;
    int columns = 5;
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            Console.Write(arr[i, j] + "     ");
        }
        Console.WriteLine();
    }
    return arr;
}
